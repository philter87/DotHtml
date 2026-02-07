using System.Text;

namespace DotHtml;

public class HtmlTagList() : HtmlTag("")
{
    public HtmlTagList(IEnumerable<HtmlNode> children)
        : this()
    {
        Children.AddRange(children);
    }

    public override string ToHtml(bool allowRawHtml = false)
    {
        var b = new StringBuilder();
        foreach (var child in Children)
        {
            b.Append(child.ToHtml(allowRawHtml));
        }
        return b.ToString();
    }
}