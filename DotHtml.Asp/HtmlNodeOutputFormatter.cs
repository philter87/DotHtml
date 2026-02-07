using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System.Text;

namespace DotHtml.Asp;

/// <summary>
/// Output formatter that enables returning HtmlNode directly from controller actions.
/// </summary>
public class HtmlNodeOutputFormatter : TextOutputFormatter
{
    public HtmlNodeOutputFormatter()
    {
        SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/html"));
        SupportedEncodings.Add(Encoding.UTF8);
        SupportedEncodings.Add(Encoding.Unicode);
    }

    protected override bool CanWriteType(Type? type)
    {
        return type != null && typeof(HtmlNode).IsAssignableFrom(type);
    }

    public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
    {
        var htmlNode = context.Object as HtmlNode;
        
        if (htmlNode == null)
        {
            return;
        }

        var html = htmlNode.ToHtml();
        var response = context.HttpContext.Response;
        
        await using var writer = context.WriterFactory(response.Body, selectedEncoding);
        await writer.WriteAsync(html);
    }
}

