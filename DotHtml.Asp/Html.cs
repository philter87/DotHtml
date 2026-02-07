using Microsoft.AspNetCore.Http;

namespace DotHtml.Asp;

/// <summary>
/// Helper class for creating HTML results in minimal APIs and other scenarios.
/// </summary>
public static class Html
{
    /// <summary>
    /// Creates an IResult from an HtmlNode for use in minimal APIs.
    /// </summary>
    /// <param name="htmlNode">The HTML node to render.</param>
    /// <param name="allowRawHtml">Whether to allow raw HTML content.</param>
    /// <returns>An IResult that renders the HTML node.</returns>
    public static IResult From(HtmlNode htmlNode, bool allowRawHtml = false)
    {
        var html = htmlNode.ToHtml(allowRawHtml);
        return Results.Content(html, "text/html; charset=utf-8");
    }

    /// <summary>
    /// Creates an IResult from an HtmlNode with a specific status code.
    /// </summary>
    /// <param name="htmlNode">The HTML node to render.</param>
    /// <param name="statusCode">The HTTP status code.</param>
    /// <param name="allowRawHtml">Whether to allow raw HTML content.</param>
    /// <returns>An IResult that renders the HTML node with the specified status code.</returns>
    public static IResult From(HtmlNode htmlNode, int statusCode, bool allowRawHtml = false)
    {
        var html = htmlNode.ToHtml(allowRawHtml);
        return Results.Content(html, "text/html; charset=utf-8", statusCode: statusCode);
    }
}

