using DotHtml.Htmx;
using static DotHtml.Tags;

namespace DotHtml.WebSandbox.Controllers;

public static class Components
{
    public static HtmlTag Layout(List<HtmlNode> children)
    {
        return html() << [
            head() << [
                HtmxTags.InstallHtmxScript()
            ],
            body() << [
                p() << "Header",
                children,
                p() << "Footer"
            ]
        ];
    }
}