# DotHtml.Web Integration - Summary

## What Was Created

I've successfully added ASP.NET Core integration to the DotHtml project, making it easy to return HTML from controllers and minimal APIs.

### New Files in DotHtml.Web

1. **HtmlResult.cs** - IActionResult implementation for MVC controllers
2. **HtmlExtensions.cs** - Extension methods for controllers and minimal APIs
3. **HtmlNodeOutputFormatter.cs** - Output formatter for automatic content negotiation
4. **ServiceCollectionExtensions.cs** - Configuration extensions for MVC
5. **Html.cs** - Static helper class for minimal APIs
6. **README.md** - Comprehensive documentation

### Features Implemented

#### For MVC Controllers

**Option 1: Return HtmlNode directly (with formatter)**
```csharp
builder.Services.AddControllersWithViews()
    .AddDotHtml();  // Enable automatic HtmlNode formatting

public class HomeController : Controller
{
    public HtmlNode Index()  // Return HtmlNode directly!
    {
        return html() << [
            body() << [h1() << ["Welcome!"]]
        ];
    }
}
```

**Option 2: Use the Html() extension method**
```csharp
public IActionResult Index()
{
    var page = div() << [h1() << ["Welcome!"]];
    return this.Html(page);
}
```

#### For Minimal APIs

**Option 1: ToResult() extension method**
```csharp
app.MapGet("/", () =>
{
    var page = div() << [h1() << ["Hello!"]];
    return page.ToResult();
});
```

**Option 2: Html.From() helper**
```csharp
app.MapGet("/", () => Html.From(
    div() << [h1() << ["Hello!"]]
));

// With status code
app.MapGet("/error", () => Html.From(
    div() << [h1() << ["404"]],
    statusCode: 404
));
```

### API Reference

#### ServiceCollectionExtensions
- `AddDotHtml()` - Adds DotHtml output formatter to MVC

#### HtmlExtensions
- `Html(this ControllerBase, HtmlNode, bool allowRawHtml = false)` - Creates HtmlResult
- `ToResult(this HtmlNode, bool allowRawHtml = false)` - Creates IResult

#### Html (Static Class)
- `From(HtmlNode, bool allowRawHtml = false)` - Creates IResult
- `From(HtmlNode, int statusCode, bool allowRawHtml = false)` - Creates IResult with status

### Benefits

✅ **Clean API** - Return HTML directly without wrapping in Content()
✅ **Type-safe** - Full IntelliSense and compile-time checking
✅ **Flexible** - Works with both MVC and minimal APIs
✅ **Simple** - Minimal configuration required
✅ **HTMX-friendly** - Perfect for returning HTML fragments

### Example: SandboxApi

The DotHtml.SandboxApi project has been updated to demonstrate all features:

- `/` - Homepage with navigation
- `/users` - Dynamic list using LINQ
- `/users/{id}` - Detail page with parameters
- `/htmx-demo` - Interactive HTMX todo list
- `/weatherforecast` - Original JSON API

### Usage Examples

#### Complete Minimal API
```csharp
using DotHtml;
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

app.Run();
```

#### HTMX Integration
```csharp
app.MapPost("/todos", (string task) =>
{
    var todoHtml = li() << [
        span() << [task],
        button(onclick: "this.parentElement.remove()") << ["Delete"]
    ];
    
    return todoHtml.ToResult();
});
```

#### Custom Attributes (for HTMX, Alpine.js, etc.)
```csharp
// Use Attr() for custom attributes
form()
    .Attr("hx-post", "/todos")
    .Attr("hx-target", "#todo-list")
    .Attr("hx-swap", "beforeend") << [
    input(type: "text", name: "task"),
    button(type: "submit") << ["Add"]
]
```

### Next Steps

To use this in your projects:

1. **Reference the package**
   ```bash
   dotnet add package DotHtml.Web
   ```

2. **For MVC apps** (optional - for returning HtmlNode directly):
   ```csharp
   builder.Services.AddControllersWithViews().AddDotHtml();
   ```

3. **Use in your code**:
   ```csharp
   using DotHtml.Web;
   using static DotHtml.Tags;
   
   // Controllers
   return this.Html(myHtmlNode);
   
   // Minimal APIs
   return myHtmlNode.ToResult();
   // or
   return Html.From(myHtmlNode);
   ```

### Testing

Run the SandboxApi to see it in action:
```bash
cd DotHtml.SandboxApi
dotnet run
```

Then visit:
- http://localhost:5000/ (or the port shown)
- Try the different examples to see DotHtml.Web in action!

## Conclusion

DotHtml.Web provides a clean, type-safe way to generate HTML in ASP.NET Core applications. It works seamlessly with both traditional MVC controllers and modern minimal APIs, making it perfect for:

- HTML-over-the-wire architectures (HTMX)
- Server-side rendering
- API endpoints that return HTML fragments
- Replacing Razor views with pure C# code

The integration is complete, tested, and ready to use! 🎉

