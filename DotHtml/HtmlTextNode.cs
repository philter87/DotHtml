using System.Net;

namespace DotHtml;

public class HtmlTextNode(string content) : HtmlNode
{
    public override string ToHtml(bool allowRawHtml = false)
    {
        return allowRawHtml ? content : WebUtility.HtmlEncode(content);
    }

    public override string ToString()
    {
        return content;
    }
}