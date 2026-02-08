namespace DotHtml;

public partial class Tags
{
    public static HtmlTag script(string? @class = null, string? type = null, string? src = null, bool? defer = null, string? crossorigin = null, string? integrity = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("script").Attr("class",@class).Attr("type",type).Attr("src",src).Attr("crossorigin", crossorigin).Attr("integrity", integrity).Attr("defer",defer).Attr("style",style).Attr("id",id).Attr("hidden",hidden)
            .Attr("onclick",onclick)
            .Attr("role",role)
            .Attr("tabindex",tabindex)
            .AllowRawHtml();
    }
}