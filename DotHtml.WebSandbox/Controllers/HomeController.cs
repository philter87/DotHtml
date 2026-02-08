using DotHtml.Htmx;
using Microsoft.AspNetCore.Mvc;
using static DotHtml.Tags;
using static DotHtml.WebSandbox.Controllers.Components;

namespace DotHtml.WebSandbox.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public HtmlNode Get()
    {
        return Layout([
            div().HxGet("/content") << "Hello, World! Click me!"
        ]);
    }
    
    [HttpGet("content")]
    public HtmlNode GetContent()
    {
        return div().HxGet("/") << "Aw";
    }
    

}