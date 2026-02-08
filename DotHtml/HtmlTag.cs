using System.Collections;
using System.Text;

namespace DotHtml;

public class HtmlTag(string tag) : HtmlNode, IEnumerable<HtmlNode>
{
    public Dictionary<string, object> Attributes { get; } = new();
    public List<HtmlNode> Children { get; } = [];

    private bool? _allowRawHtml; 
    
    public static HtmlTag operator << (HtmlTag parent, HtmlNode? child)
        => child == null ? parent : parent.Add(child);
    
    public static HtmlTag operator << (HtmlTag parent, IEnumerable<HtmlNode?> child)
        => parent.Add(child.OfType<HtmlNode>().ToList());
    
    
    public HtmlTag AllowRawHtml(bool allow = true)
    {
        _allowRawHtml = allow;
        return this;
    }

    public override async Task<HtmlNode> Accept(INodeVisitor visitor)
    {
        await visitor.Visit(this);
        for (var index = 0; index < Children.Count; index++)
        {
            var child = Children[index];
            Children[index] = await child.Accept(visitor);
        }
        return this;
    }

    public override string ToHtml(bool allowRawHtml = false)
    {
        var b = new StringBuilder();
        foreach (var child in Children)
        {
            // Use the local _allowRawHtml if set, otherwise use the parameter
            b.Append(child.ToHtml(_allowRawHtml ?? allowRawHtml));
        }
        
        return string.IsNullOrEmpty(tag) 
            ? b.ToString() 
            : $"<{tag}{CreateAttributes()}>{b}</{tag}>";
    }

    private string CreateAttributes()
    {
        return Attributes.Count == 0
            ? ""
            : " " + string.Join(" ", Attributes.Select(CreateAttribute));
    }

    private static string CreateAttribute(KeyValuePair<string, object> kv)
    {
        return kv.Value switch
        {
            bool boolVal => boolVal ? kv.Key : "",
            string strVal when strVal.Contains('"') => kv.Key + "='" + kv.Value + "'",
            _ => kv.Key + "=\"" + kv.Value + "\""
        };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<HtmlNode> GetEnumerator()
    {
        return Children.GetEnumerator();
    }

    public HtmlTag Add(HtmlNode? node)
    {
        if (node != null)
        {
            Children.Add(node);
        }
        return this;
    }
    

    public HtmlTag Attr(string name, object? value)
    {
        if (value == null)
        {
            return this;
        }

        Attributes[name] = value;
        return this;
    }

    public override string ToString()
    {
        return $"<{tag}{CreateAttributes()}>";
    }
    
}
