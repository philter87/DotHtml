# DotHtml
> A fun and simple way to generate HTML in C# with type-safety and IntelliSense support
DotHtml is a lightweight alternative to Razor that makes it easy to create reusable HTML components directly in C#. No more context-switching between C# and markup - write everything in type-safe C# and let your IDE help you catch errors before runtime.

## Why DotHtml?
**Traditional HTML:**
```html
<div class="center-button">
    <button class="btn btn-primary" onclick="doSomething()">
        Click Me!
    </button>
</div>
```
**DotHtml:**
```csharp
using static DotHtml.Tags;

div("center-button") << [
    button("btn btn-primary", onclick: "doSomething()") << [
        "Click Me!"
    ]
]
```
### Key Benefits
- **🛡️ Type-safety** - Your editor warns you about issues at design time
- **🔧 Flexibility** - Everything is possible with code - loops, conditionals, LINQ, etc.
- **♻️ Reusability** - Easy to create and reuse components as C# methods
- **🎯 IntelliSense** - Full autocomplete support for HTML tags and attributes
- **🚀 No compilation overhead** - No special build steps or view compilation

## Quick Start
### Installation

```bash
dotnet add package DotHtml

# And for Asp.NET Core integration:
dotnet add package DotHtml.Asp
```

### Basic Usage
```csharp
using static DotHtml.Tags;

var html = div("container") << [
    h1() << ["Welcome to DotHtml"],
    p() << ["Generate HTML the fun way!"]
].ToHtml();
```
## Creating Components
One of DotHtml's best features is how naturally it supports component creation. Components are just C# methods:
```csharp
using static DotHtml.Tags;

public static class Components
{
    public static HtmlTag Card(string title, string content)
    {
        return div("card") << [
            div("card-header") << [
                h3() << [title]
            ],
            div(@class: "card-body") << [
                p() << [content]
            ]
        ];
    }
    
    public static HtmlTag Button(string text, string variant = "primary")
    {
        return button(@class: $"btn btn-{variant}") << [text];
    }
}
// Usage
var page = div() << [
    Components.Card("Hello", "This is a reusable card!"),
    Components.Button("Click Me", "success")
];
```
## Integration Examples
### ASP.NET Core MVC Controllers
DotHtml works seamlessly with traditional MVC controllers. Just return the HTML as a `ContentResult`:
```csharp
using Microsoft.AspNetCore.Mvc;
using static DotHtml.Tags;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        var html = html() << [
            head() << [
                title() << ["My App"],
                link(href: "/styles.css", rel: "stylesheet")
            ],
            body() << [
                div(@class: "container") << [
                    h1() << ["Welcome!"],
                    p() << ["Built with DotHtml"]
                ]
            ]
        ];
        return Content(html.ToHtml(), "text/html");
    }
    public IActionResult UserList(List<User> users)
    {
        var html = div(@class: "user-list") << [
            ..users.Select(user => 
                div(@class: "user-card") << [
                    h3() << [user.Name],
                    p() << [user.Email]
                ]
            )
        ];
        return Content(html.ToHtml(), "text/html");
    }
}
```
### Minimal APIs
DotHtml is perfect for minimal APIs - keep your routes and HTML generation in the same place:
```csharp
using Microsoft.AspNetCore.Builder;
using static DotHtml.Tags;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => 
{
    var page = html() << [
        head() << [
            title() << ["Minimal API with DotHtml"]
        ],
        body() << [
            h1() << ["Hello from Minimal API!"],
            p() << ["No controllers needed!"]
        ]
    ];
    return Results.Content(page.ToHtml(), "text/html");
});
app.MapGet("/users/{id}", (int id) =>
{
    var user = GetUser(id); // Your data access logic
    var html = div(@class: "user-profile") << [
        h2() << [user.Name],
        p() << [$"Email: {user.Email}"],
        p() << [$"Member since: {user.CreatedAt:yyyy}"]
    ];
    return Results.Content(html.ToHtml(), "text/html");
});
app.Run();
```
### API Endpoints for HTMX
DotHtml shines when paired with **HTMX** - return small HTML fragments from your endpoints:
```csharp
app.MapPost("/todos", (string task) =>
{
    var newTodo = CreateTodo(task);
    var todoHtml = li(id: $"todo-{newTodo.Id}", @class: "todo-item") << [
        span() << [newTodo.Task],
        button(
            @class: "btn-delete",
            hx_delete: $"/todos/{newTodo.Id}",
            hx_target: $"#todo-{newTodo.Id}",
            hx_swap: "outerHTML"
        ) << ["Delete"]
    ];
    return Results.Content(todoHtml.ToHtml(), "text/html");
});
app.MapDelete("/todos/{id}", (int id) =>
{
    DeleteTodo(id);
    return Results.Content("", "text/html"); // HTMX will remove the element
});
```
Full HTMX example with a todo list:
```csharp
using static DotHtml.Tags;
app.MapGet("/", () =>
{
    var page = html() << [
        head() << [
            title() << ["HTMX + DotHtml Todo"],
            script(src: "https://unpkg.com/htmx.org@1.9.10")
        ],
        body() << [
            div(@class: "container") << [
                h1() << ["My Todos"],
                form(hx_post: "/todos", hx_target: "#todo-list", hx_swap: "beforeend") << [
                    input(type: "text", name: "task", placeholder: "New todo..."),
                    button(type: "submit") << ["Add"]
                ],
                ul(id: "todo-list") << [
                    ..GetTodos().Select(todo =>
                        li(id: $"todo-{todo.Id}") << [
                            span() << [todo.Task],
                            button(
                                hx_delete: $"/todos/{todo.Id}",
                                hx_target: $"#todo-{todo.Id}",
                                hx_swap: "outerHTML"
                            ) << ["×"]
                        ]
                    )
                ]
            ]
        ]
    ];
    return Results.Content(page.ToHtml(), "text/html");
});
```
## Alpine.js Integration
DotHtml works beautifully with **Alpine.js** for adding interactivity:
```csharp
using static DotHtml.Tags;
var page = html() << [
    head() << [
        script(src: "https://cdn.jsdelivr.net/npm/alpinejs@3.x.x/dist/cdn.min.js", defer: true)
    ],
    body() << [
        div(x_data: "{ count: 0 }") << [
            h1(x_text: "count"),
            button(x_on_click: "count++") << ["Increment"],
            button(x_on_click: "count--") << ["Decrement"]
        ],
        // Dropdown example
        div(x_data: "{ open: false }", @class: "dropdown") << [
            button(x_on_click: "open = !open") << ["Toggle Menu"],
            div(x_show: "open", @class: "menu") << [
                a(href: "/profile") << ["Profile"],
                a(href: "/settings") << ["Settings"],
                a(href: "/logout") << ["Logout"]
            ]
        ]
    ]
];
```
## Advanced Features
### Dynamic Content with LINQ
```csharp
var users = GetUsers();
var userGrid = div(@class: "grid") << [
    ..users
        .Where(u => u.IsActive)
        .OrderBy(u => u.Name)
        .Select(u => 
            div(@class: "card") << [
                h3() << [u.Name],
                p() << [u.Email]
            ]
        )
];
```
### Conditional Rendering
```csharp
var nav = nav() << [
    a(href: "/") << ["Home"],
    a(href: "/about") << ["About"],
    ..( isLoggedIn ? [
        a(href: "/profile") << ["Profile"],
        a(href: "/logout") << ["Logout"]
    ] : [
        a(href: "/login") << ["Login"]
    ])
];
```
### Nested Components
```csharp
public static HtmlTag Layout(string title, params HtmlNode[] content)
{
    return html() << [
        head() << [
            title() << [title],
            link(rel: "stylesheet", href: "/style.css")
        ],
        body() << [
            Header(),
            main() << content,
            Footer()
        ]
    ];
}
public static HtmlTag Header()
{
    return header() << [
        nav() << [
            a(href: "/") << ["Home"],
            a(href: "/about") << ["About"]
        ]
    ];
}
// Usage
var page = Layout("Welcome", 
    h1() << ["Welcome"],
    p() << ["This is the content"]
);
```
### Raw HTML Support
For cases where you need to include pre-rendered HTML:
```csharp
var html = div() << [
    new HtmlTextNode("<script>alert('hello')</script>")
].AllowRawHtml();
```
## API Reference
### Common HTML Tags
All standard HTML5 tags are available as methods:
- `div()`, `span()`, `p()`, `a()`, `button()`, `input()`
- `h1()`, `h2()`, `h3()`, `h4()`, `h5()`, `h6()`
- `ul()`, `ol()`, `li()`, `table()`, `tr()`, `td()`, `th()`
- `form()`, `label()`, `select()`, `option()`, `textarea()`
- `header()`, `footer()`, `nav()`, `main()`, `section()`, `article()`
- And many more...
### Common Attributes
All tags support these common attributes:
- `@class` - CSS classes
- `id` - Element ID
- `style` - Inline styles
- `hidden` - Hidden attribute
- `onclick`, `onchange`, `oninput` - Event handlers
- `role`, `tabindex` - Accessibility attributes
Specific tags have their own specialized attributes (e.g., `href` for `<a>`, `src` for `<img>`, etc.)
### Methods
- `ToHtml()` - Converts the tag tree to an HTML string
- `<<` operator - Adds children to a tag
- `Attr(name, value)` - Sets an attribute dynamically
- `AllowRawHtml()` - Allows raw HTML in child nodes
## Why Not Razor?
Razor is great, but DotHtml offers some unique advantages:
- ✅ **No separate files** - Keep your HTML generation with your logic
- ✅ **Better IntelliSense** - Full C# autocomplete and type checking
- ✅ **Easier refactoring** - Rename a component? Your IDE updates all usages
- ✅ **No magic strings** - Catch typos at compile time
- ✅ **Perfect for APIs** - Generate HTML fragments without view compilation overhead
- ✅ **Simple mental model** - It's just C# methods returning HTML
## Performance
DotHtml is designed to be lightweight and fast. Since it's just C# code generating strings, there's no view compilation or parsing overhead. For most web applications, the performance is more than adequate.
## Contributing
Contributions are welcome! Please feel free to submit issues and pull requests.
## License
MIT License - see LICENSE file for details
---
**Happy HTML generation! 🎉**
