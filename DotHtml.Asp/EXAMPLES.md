# Quick Start Examples

## Minimal API Example

Create a new minimal API project and add DotHtml:

```bash
dotnet new web -n MyHtmlApp
cd MyHtmlApp
dotnet add reference ../DotHtml/DotHtml.csproj
dotnet add reference ../DotHtml.Web/DotHtml.Web.csproj
```

Then update `Program.cs`:

```csharp
using DotHtml.Web;
using static DotHtml.Tags;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simple homepage
app.MapGet("/", () => Html.From(
    html() << [
        head() << [
            title() << ["My HTML App"],
            new HtmlTag("style") << [
                "body { font-family: sans-serif; margin: 40px; }"
            ]
        ],
        body() << [
            h1() << ["Welcome!"],
            p() << ["This HTML is generated with DotHtml"],
            a(href: "/about") << ["About"]
        ]
    ]
));

// About page
app.MapGet("/about", () =>
{
    var page = div() << [
        h1() << ["About"],
        p() << ["Built with DotHtml.Web"],
        a(href: "/") << ["← Home"]
    ];
    
    return page.ToResult();
});

app.Run();
```

## MVC Controller Example

Add to your MVC project:

```bash
dotnet add reference ../DotHtml/DotHtml.csproj
dotnet add reference ../DotHtml.Web/DotHtml.Web.csproj
```

Update `Program.cs`:

```csharp
builder.Services.AddControllersWithViews()
    .AddDotHtml();  // Enable returning HtmlNode directly
```

Create a controller:

```csharp
using DotHtml;
using DotHtml.Web;
using Microsoft.AspNetCore.Mvc;
using static DotHtml.Tags;

public class HomeController : Controller
{
    // Option 1: Return HtmlNode directly
    public HtmlNode Index()
    {
        return Layout("Home",
            h1() << ["Welcome to my site!"],
            p() << ["No Razor views needed!"]
        );
    }
    
    // Option 2: Return IActionResult
    public IActionResult About()
    {
        var page = div() << [
            h1() << ["About"],
            p() << ["Using DotHtml in MVC"]
        ];
        
        return this.Html(page);
    }
    
    private static HtmlNode Layout(string pageTitle, params HtmlNode[] content)
    {
        return html() << [
            head() << [
                title() << [pageTitle],
                new HtmlTag("link")
                    .Attr("rel", "stylesheet")
                    .Attr("href", "/styles.css")
            ],
            body() << [
                nav() << [
                    a(href: "/") << ["Home"],
                    a(href: "/about") << ["About"]
                ],
                main() << content.ToList()
            ]
        ];
    }
}
```

## HTMX Todo List Example

```csharp
using DotHtml.Web;
using static DotHtml.Tags;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todos = new List<string> { "Sample todo" };

app.MapGet("/", () => Html.From(
    html() << [
        head() << [
            title() << ["HTMX Todo"],
            new HtmlTag("script")
                .Attr("src", "https://unpkg.com/htmx.org@1.9.10")
        ],
        body() << [
            h1() << ["My Todos"],
            
            form()
                .Attr("hx-post", "/todos")
                .Attr("hx-target", "#todos")
                .Attr("hx-swap", "beforeend") << [
                input(type: "text", name: "task", required: true),
                button(type: "submit") << ["Add"]
            ],
            
            ul(id: "todos") << [
                ..todos.Select(todo =>
                    li() << [todo]
                )
            ]
        ]
    ]
));

app.MapPost("/todos", (string task) =>
{
    todos.Add(task);
    return Html.From(li() << [task]);
});

app.Run();
```

## Component Pattern

Create reusable components:

```csharp
public static class Components
{
    public static HtmlTag Card(string title, string content, string? link = null)
    {
        return div(@class: "card") << [
            div(@class: "card-header") << [
                h3() << [title]
            ],
            div(@class: "card-body") << [
                p() << [content]
            ],
            link != null 
                ? div(@class: "card-footer") << [
                    a(href: link) << ["Learn more →"]
                ]
                : null
        ];
    }
    
    public static HtmlTag Button(string text, string variant = "primary", string? href = null)
    {
        var className = $"btn btn-{variant}";
        return href != null
            ? a(@class: className, href: href) << [text]
            : button(@class: className) << [text];
    }
}

// Usage
app.MapGet("/", () => Html.From(
    div(@class: "container") << [
        Components.Card("Welcome", "Start building with DotHtml!", "/docs"),
        Components.Button("Get Started", "success", "/start")
    ]
));
```

## Tips

1. **Use `new HtmlTag("tagname")` for tags not yet generated** (like `<script>`, `<style>`, etc.)

2. **Use `.Attr()` for custom attributes** (HTMX, Alpine.js, etc.):
   ```csharp
   div().Attr("x-data", "{ count: 0 }")
   ```

3. **Use spread operator for collections**:
   ```csharp
   ul() << [
       ..items.Select(item => li() << [item.Name])
   ]
   ```

4. **Create layout helpers** to keep your code DRY

5. **Return fragments for HTMX** - just return the HTML snippet you need:
   ```csharp
   app.MapPost("/item", () => Html.From(
       li() << ["New item"]
   ));
   ```

