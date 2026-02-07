using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotHtml.Asp;

/// <summary>
/// Extension methods for working with HtmlNode in ASP.NET Core.
/// </summary>
public static class HtmlExtensions
{
    /// <summary>
    /// Creates an HtmlResult from an HtmlNode for use in MVC controllers.
    /// </summary>
    /// <param name="controller">The controller instance.</param>
    /// <param name="htmlNode">The HTML node to render.</param>
    /// <param name="allowRawHtml">Whether to allow raw HTML content.</param>
    /// <returns>An HtmlResult that renders the HTML node.</returns>
    public static HtmlResult Html(this ControllerBase controller, HtmlNode htmlNode, bool allowRawHtml = false)
    {
        return new HtmlResult(htmlNode, allowRawHtml);
    }

    /// <summary>
    /// Creates an IResult from an HtmlNode for use in minimal APIs.
    /// </summary>
    /// <param name="htmlNode">The HTML node to render.</param>
    /// <param name="allowRawHtml">Whether to allow raw HTML content.</param>
    /// <returns>An IResult that renders the HTML node.</returns>
    public static IResult ToResult(this HtmlNode htmlNode, bool allowRawHtml = false)
    {
        var html = htmlNode.ToHtml(allowRawHtml);
        return Results.Content(html, "text/html; charset=utf-8");
    }
}

