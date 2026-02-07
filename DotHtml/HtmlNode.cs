namespace DotHtml;

public abstract class HtmlNode
{
    public virtual Task<HtmlNode> Accept(INodeVisitor visitor)
    {
        return visitor.Visit(this);
    }
    
    public abstract string ToHtml(bool allowRawHtml = false);
    
    public static implicit operator HtmlNode(string text) => new HtmlTextNode(text);
    public static implicit operator HtmlNode(int val) => new HtmlTextNode(val+"");
    
    // Handle arrays
    public static implicit operator HtmlNode(List<HtmlNode> children) => new HtmlTagList(children);
    public static implicit operator HtmlNode(List<HtmlTag> children) => new HtmlTagList(children);
}