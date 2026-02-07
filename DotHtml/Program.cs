
namespace DotHtml;

public static class Program
{
    const string FactoryClassName = "Tags";
    const string BaseClass = nameof(HtmlTag);
    const string Namespace = "DotHtml";

    public static void Main()
    {
        var sourceCode = $"""
                           namespace {Namespace};

                           {AddStaticMethodsToTagsClass(TagsMeta.Tags)}
                           
                           """;
        
        
        var outputPath = Path.Combine(Directory.GetCurrentDirectory(),"..", "..", "..", FactoryClassName + ".cs");

        Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
        File.WriteAllText(outputPath, sourceCode);

        Console.WriteLine($"Generated: {outputPath}");
    }

    private static string AddStaticMethodsToTagsClass(IDictionary<string, List<string>> tags)
    {
        return $$"""
                 public static partial class {{FactoryClassName}}
                 {
                 {{AddStaticMethods(tags)}}
                 }
                 """;
    }
    
    private static string AddStaticMethods(IDictionary<string, List<string>> tags)
    {
        return string.Join("\n\n", tags.Select(kv => AddStaticMethod(kv.Key, kv.Value)));
    }
    private static string AddStaticMethod(string tag, List<string> attributesShort)
    {
        var attributes = Convert(attributesShort);
        
        return $$"""
                     public static {{BaseClass}} {{tag}}({{CreateParameters(attributes)}})
                     {
                         return new {{BaseClass}}("{{tag}}"){{AddAttributes(attributes)}};
                     }
                 """;
    }

    private static string AddAttributes(List<HtmlAttribute> attributes)
    {
        return string.Join("", attributes.Select(attr => attr.AsAddAttribute()));
    }

    private static string CreateParameters(List<HtmlAttribute> attributes)
    {
        return string.Join(", ", attributes.Select(a => a.AsParameter()));
    }

    private static List<HtmlAttribute> Convert(List<string> attributes)
    {
        return attributes
            .Distinct()
            .Select(attr => new HtmlAttribute(attr))
            .ToList();
    }
    
    private sealed class HtmlAttribute
    {
        public HtmlAttribute(string shorthand)
        {
            var words = shorthand.Split('=');
            HtmlName = words[0];
            FieldName = HtmlName; 
            Type = words.Length == 1 ? "string" : words[1];
        }

        private string FieldName { get; }
        private string HtmlName { get; }
        private string Type { get; }

        public string AsParameter()
        {
            return $"{Type}? {FieldName} = null";
        }

        public string AsAddAttribute()
        {
            var name = HtmlName.Replace("@", "");
            return $".{nameof(HtmlTag.Attr)}(\"{name}\",{FieldName})";
        }
    }
}