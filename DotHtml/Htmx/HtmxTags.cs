namespace DotHtml.Htmx;

public static class HtmxTags
{
    public static HtmlTag InstallHtmxScript()
    {
        // <script src="https://cdn.jsdelivr.net/npm/htmx.org@2.0.8/dist/htmx.min.js" integrity="sha384-/TgkGk7p307TH7EXJDuUlgG3Ce1UVolAOFopFekQkkXihi5u/6OCvVKyz1W+idaz" crossorigin="anonymous"></script>
        return Tags.script(src:"https://cdn.jsdelivr.net/npm/htmx.org@2.0.8/dist/htmx.min.js", integrity: "/TgkGk7p307TH7EXJDuUlgG3Ce1UVolAOFopFekQkkXihi5u/6OCvVKyz1W+idaz", crossorigin: "anonymous");
    }
}