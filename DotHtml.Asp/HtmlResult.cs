using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotHtml.Asp;

/// <summary>
/// An action result that returns HTML content from an HtmlNode.
/// </summary>
public class HtmlResult : IActionResult
{
    private readonly HtmlNode _htmlNode;
    private readonly bool _allowRawHtml;

    public HtmlResult(HtmlNode htmlNode, bool allowRawHtml = false)
    {
        _htmlNode = htmlNode ?? throw new ArgumentNullException(nameof(htmlNode));
        _allowRawHtml = allowRawHtml;
    }

    public async Task ExecuteResultAsync(ActionContext context)
    {
        var response = context.HttpContext.Response;
        response.ContentType = "text/html; charset=utf-8";
        
        var html = _htmlNode.ToHtml(_allowRawHtml);
        await response.WriteAsync(html);
    }
}

