# DotHtml.Web

ASP.NET Core integration for DotHtml, making it easy to return HTML from controllers and minimal APIs.

## Installation

```bash
dotnet add package DotHtml.Web
```

## Features

- Return `HtmlNode` objects directly from MVC controllers
- Extension methods for easy HTML responses in minimal APIs
- Automatic content negotiation support
- Type-safe HTML generation with IntelliSense

## Usage

### MVC Controllers

#### Option 1: Return HtmlNode directly (with formatter)

First, configure your application to use the DotHtml formatter:

```csharp
// Program.cs
builder.Services.AddControllersWithViews()
    .AddDotHtml();  // Enable automatic HtmlNode formatting
```

Then you can return `HtmlNode` directly from your controllers:

```csharp
using DotHtml;
using Microsoft.AspNetCore.Mvc;
using static DotHtml.Tags;

public class HomeController : Controller
{
    public HtmlNode Index()
    {
        return html() << [
            head() << [
                title() << ["My App"]
            ],
            body() << [
                h1() << ["Welcome!"],
                p() << ["This is returned directly as HtmlNode"]
            ]
        ];
    }
    
    public HtmlNode Users()
    {
        var users = GetUsers();
        
        return div(@class: "user-list") << [
            ..users.Select(user => 
                div(@class: "user-card") << [
                    h3() << [user.Name],
                    p() << [user.Email]
                ]
            )
        ];
    }
}
```

#### Option 2: Use the Html() extension method

```csharp
using DotHtml.Web;
using Microsoft.AspNetCore.Mvc;
using static DotHtml.Tags;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var page = div() << [
            h1() << ["Welcome!"],
            p() << ["Using Html() extension method"]
        ];
        
        return this.Html(page);
    }
}
```

### Minimal APIs

#### Option 1: Use the ToResult() extension method

```csharp
using DotHtml.Web;
using static DotHtml.Tags;

var app = builder.Build();

app.MapGet("/", () =>
{
    var page = html() << [
        head() << [title() << ["Minimal API"]],
        body() << [
            h1() << ["Hello from Minimal API!"],
            p() << ["Using ToResult() extension"]
        ]
    ];
    
    return page.ToResult();
});

app.MapGet("/users/{id}", (int id) =>
{
    var user = GetUser(id);
    
    var html = div(@class: "user-profile") << [
        h2() << [user.Name],
        p() << [$"Email: {user.Email}"]
    ];
    
    return html.ToResult();
});
```

#### Option 2: Use the Html.From() helper

```csharp
using DotHtml.Web;
using static DotHtml.Tags;

app.MapGet("/", () =>
{
    var page = div() << [
        h1() << ["Hello!"],
        p() << ["Using Html.From() helper"]
    ];
    
    return Html.From(page);
});

// With custom status code
app.MapGet("/error", () =>
{
    var error = div(@class: "error") << [
        h1() << ["404 - Not Found"],
        p() << ["The page you're looking for doesn't exist"]
    ];
    
    return Html.From(error, statusCode: 404);
});
```

### HTMX Integration

DotHtml.Web works perfectly with HTMX for returning HTML fragments:

```csharp
using DotHtml.Web;
using static DotHtml.Tags;

app.MapPost("/todos", (string task) =>
{
    var newTodo = CreateTodo(task);
    
    var todoHtml = li(id: $"todo-{newTodo.Id}") << [
        span() << [newTodo.Task],
        button(
            hx_delete: $"/todos/{newTodo.Id}",
            hx_target: $"#todo-{newTodo.Id}",
            hx_swap: "outerHTML"
        ) << ["Delete"]
    ];
    
    return todoHtml.ToResult();
});

app.MapDelete("/todos/{id}", (int id) =>
{
    DeleteTodo(id);
    return Html.From(new HtmlTextNode("")); // Empty response for HTMX
});
```

### Raw HTML Support

When you need to include pre-rendered HTML or scripts:

```csharp
var page = div() << [
    h1() << ["My Page"],
    new HtmlTextNode("<script>console.log('raw html');</script>")
];

// In controllers:
return this.Html(page, allowRawHtml: true);

// In minimal APIs:
return page.ToResult(allowRawHtml: true);

// Or:
return Html.From(page, allowRawHtml: true);
```

## API Reference

### ServiceCollectionExtensions

- `AddDotHtml()` - Adds DotHtml output formatter to MVC

### HtmlExtensions

- `Html(this ControllerBase, HtmlNode, bool allowRawHtml = false)` - Creates HtmlResult for controllers
- `ToResult(this HtmlNode, bool allowRawHtml = false)` - Creates IResult for minimal APIs

### Html (Static Class)

- `From(HtmlNode, bool allowRawHtml = false)` - Creates IResult from HtmlNode
- `From(HtmlNode, int statusCode, bool allowRawHtml = false)` - Creates IResult with status code

### HtmlResult

- Implements `IActionResult`
- Returns HTML content with proper content type

### HtmlNodeOutputFormatter

- Output formatter for automatic content negotiation
- Enables returning `HtmlNode` directly from controller actions

## Examples

### Complete MVC Example

```csharp
// Program.cs
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddDotHtml();
var app = builder.Build();
app.MapControllers();
app.Run();

// Controllers/HomeController.cs
using DotHtml;
using Microsoft.AspNetCore.Mvc;
using static DotHtml.Tags;

public class HomeController : Controller
{
    public HtmlNode Index()
    {
        return Layout("Home", 
            h1() << ["Welcome!"],
            p() << ["This is my homepage"]
        );
    }
    
    private static HtmlNode Layout(string title, params HtmlNode[] content)
    {
        return html() << [
            head() << [
                title() << [title],
                link(rel: "stylesheet", href: "/styles.css")
            ],
            body() << [
                nav() << [
                    a(href: "/") << ["Home"],
                    a(href: "/about") << ["About"]
                ],
                main() << content
            ]
        ];
    }
}
```

### Complete Minimal API Example

```csharp
using DotHtml.Web;
using static DotHtml.Tags;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Html.From(
    html() << [
        head() << [title() << ["My App"]],
        body() << [
            h1() << ["Hello World!"],
            a(href: "/about") << ["About"]
        ]
    ]
));

app.MapGet("/about", () => Html.From(
    div() << [
        h1() << ["About"],
        p() << ["Built with DotHtml"]
    ]
));

app.Run();
```

## Benefits

- ✅ **Clean API** - Return HTML directly without wrapping in Content()
- ✅ **Type-safe** - Full IntelliSense and compile-time checking
- ✅ **Flexible** - Works with both MVC and minimal APIs
- ✅ **Simple** - No complex configuration required
- ✅ **HTMX-friendly** - Perfect for returning HTML fragments

## License

MIT License - see LICENSE file for details

