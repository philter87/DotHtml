namespace DotHtml;

public interface INodeVisitor
{
    public Task<HtmlNode> Visit(HtmlNode node);
}