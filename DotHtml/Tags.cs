namespace DotHtml;

public static partial class Tags
{
    public static HtmlTag body(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("body").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag a(string? @class = null, string? href = null, string? target = null, string? download = null, string? rel = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("a").Attr("class",@class).Attr("href",href).Attr("target",target).Attr("download",download).Attr("rel",rel).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag audio(string? @class = null, string? src = null, bool? controls = null, bool? autoplay = null, bool? loop = null, bool? muted = null, string? preload = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("audio").Attr("class",@class).Attr("src",src).Attr("controls",controls).Attr("autoplay",autoplay).Attr("loop",loop).Attr("muted",muted).Attr("preload",preload).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag dl(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("dl").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag li(string? @class = null, string? value = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("li").Attr("class",@class).Attr("value",value).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag br(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("br").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag aside(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("aside").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag article(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("article").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag main(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("main").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag kbd(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("kbd").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag code(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("code").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag track(string? @class = null, string? src = null, string? kind = null, string? srclang = null, string? label = null, bool? @default = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("track").Attr("class",@class).Attr("src",src).Attr("kind",kind).Attr("srclang",srclang).Attr("label",label).Attr("default",@default).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag tbody(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("tbody").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag head(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("head").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag th(string? @class = null, string? colspan = null, string? rowspan = null, string? scope = null, string? headers = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("th").Attr("class",@class).Attr("colspan",colspan).Attr("rowspan",rowspan).Attr("scope",scope).Attr("headers",headers).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag div(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("div").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag h4(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("h4").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag del(string? @class = null, string? cite = null, string? datetime = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("del").Attr("class",@class).Attr("cite",cite).Attr("datetime",datetime).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag fieldset(string? @class = null, bool? disabled = null, string? name = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("fieldset").Attr("class",@class).Attr("disabled",disabled).Attr("name",name).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag summary(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("summary").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag title(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("title").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag dialog(string? @class = null, bool? open = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("dialog").Attr("class",@class).Attr("open",open).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag td(string? @class = null, string? colspan = null, string? rowspan = null, string? headers = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("td").Attr("class",@class).Attr("colspan",colspan).Attr("rowspan",rowspan).Attr("headers",headers).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag i(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("i").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag figure(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("figure").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag sub(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("sub").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag h2(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("h2").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag output(string? @class = null, string? name = null, string? @for = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("output").Attr("class",@class).Attr("name",name).Attr("for",@for).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag table(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("table").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag abbr(string? @class = null, string? title = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("abbr").Attr("class",@class).Attr("title",title).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag textarea(string? @class = null, string? name = null, string? value = null, string? rows = null, string? cols = null, string? placeholder = null, string? autocomplete = null, bool? required = null, bool? disabled = null, bool? @readonly = null, string? maxlength = null, string? minlength = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("textarea").Attr("class",@class).Attr("name",name).Attr("value",value).Attr("rows",rows).Attr("cols",cols).Attr("placeholder",placeholder).Attr("autocomplete",autocomplete).Attr("required",required).Attr("disabled",disabled).Attr("readonly",@readonly).Attr("maxlength",maxlength).Attr("minlength",minlength).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag dt(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("dt").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag mark(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("mark").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag svg(string? @class = null, string? svg = null, string? width = null, string? height = null, string? viewBox = null, string? xmlns = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("svg").Attr("class",@class).Attr("svg",svg).Attr("width",width).Attr("height",height).Attr("viewBox",viewBox).Attr("xmlns",xmlns).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag hr(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("hr").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag sup(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("sup").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag tr(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("tr").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag figcaption(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("figcaption").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag strong(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("strong").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag label(string? @class = null, string? @for = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("label").Attr("class",@class).Attr("for",@for).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag link(string? @class = null, string? href = null, string? rel = null, string? @as = null, bool? crossorigin = null, string? type = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("link").Attr("class",@class).Attr("href",href).Attr("rel",rel).Attr("as",@as).Attr("crossorigin",crossorigin).Attr("type",type).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag p(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("p").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag footer(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("footer").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag datalist(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("datalist").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag input(string? @class = null, string? type = null, string? name = null, string? oninput = null, string? value = null, string? autocomplete = null, string? placeholder = null, bool? disabled = null, bool? @checked = null, bool? required = null, bool? @readonly = null, string? min = null, string? max = null, string? step = null, string? pattern = null, string? maxlength = null, string? minlength = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("input").Attr("class",@class).Attr("type",type).Attr("name",name).Attr("oninput",oninput).Attr("value",value).Attr("autocomplete",autocomplete).Attr("placeholder",placeholder).Attr("disabled",disabled).Attr("checked",@checked).Attr("required",required).Attr("readonly",@readonly).Attr("min",min).Attr("max",max).Attr("step",step).Attr("pattern",pattern).Attr("maxlength",maxlength).Attr("minlength",minlength).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag details(string? @class = null, bool? open = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("details").Attr("class",@class).Attr("open",open).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag thead(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("thead").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag ul(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("ul").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag h5(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("h5").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag source(string? @class = null, string? src = null, string? type = null, string? srcset = null, string? media = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("source").Attr("class",@class).Attr("src",src).Attr("type",type).Attr("srcset",srcset).Attr("media",media).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag blockquote(string? @class = null, string? cite = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("blockquote").Attr("class",@class).Attr("cite",cite).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag iframe(string? @class = null, string? src = null, string? width = null, string? height = null, string? name = null, string? sandbox = null, string? allow = null, string? loading = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("iframe").Attr("class",@class).Attr("src",src).Attr("width",width).Attr("height",height).Attr("name",name).Attr("sandbox",sandbox).Attr("allow",allow).Attr("loading",loading).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag nav(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("nav").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag dd(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("dd").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag img(string? @class = null, string? src = null, string? alt = null, string? width = null, string? height = null, string? loading = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("img").Attr("class",@class).Attr("src",src).Attr("alt",alt).Attr("width",width).Attr("height",height).Attr("loading",loading).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag canvas(string? @class = null, string? width = null, string? height = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("canvas").Attr("class",@class).Attr("width",width).Attr("height",height).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag small(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("small").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag section(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("section").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag cite(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("cite").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag ol(string? @class = null, string? type = null, string? start = null, bool? reversed = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("ol").Attr("class",@class).Attr("type",type).Attr("start",start).Attr("reversed",reversed).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag span(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("span").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag time(string? @class = null, string? datetime = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("time").Attr("class",@class).Attr("datetime",datetime).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag picture(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("picture").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag h3(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("h3").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag button(string? @class = null, string? name = null, string? type = null, string? value = null, bool? disabled = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("button").Attr("class",@class).Attr("name",name).Attr("type",type).Attr("value",value).Attr("disabled",disabled).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag h6(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("h6").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag video(string? @class = null, string? src = null, string? width = null, string? height = null, bool? controls = null, bool? autoplay = null, bool? loop = null, bool? muted = null, string? poster = null, string? preload = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("video").Attr("class",@class).Attr("src",src).Attr("width",width).Attr("height",height).Attr("controls",controls).Attr("autoplay",autoplay).Attr("loop",loop).Attr("muted",muted).Attr("poster",poster).Attr("preload",preload).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag ins(string? @class = null, string? cite = null, string? datetime = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("ins").Attr("class",@class).Attr("cite",cite).Attr("datetime",datetime).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag em(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("em").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag meta(string? @class = null, string? name = null, string? content = null, string? charset = null, string? property = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("meta").Attr("class",@class).Attr("name",name).Attr("content",content).Attr("charset",charset).Attr("property",property).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag template(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("template").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag header(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("header").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag form(string? @class = null, string? onsubmit = null, string? name = null, string? action = null, string? method = null, string? enctype = null, string? target = null, bool? novalidate = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("form").Attr("class",@class).Attr("onsubmit",onsubmit).Attr("name",name).Attr("action",action).Attr("method",method).Attr("enctype",enctype).Attr("target",target).Attr("novalidate",novalidate).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag pre(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("pre").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag select(string? @class = null, string? name = null, bool? multiple = null, bool? required = null, bool? disabled = null, string? size = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("select").Attr("class",@class).Attr("name",name).Attr("multiple",multiple).Attr("required",required).Attr("disabled",disabled).Attr("size",size).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag html(string? @class = null, string? lang = null, string? xmlns = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("html").Attr("class",@class).Attr("lang",lang).Attr("xmlns",xmlns).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag style(string? @class = null, string? type = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("style").Attr("class",@class).Attr("type",type).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag h1(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("h1").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag progress(string? @class = null, string? value = null, string? max = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("progress").Attr("class",@class).Attr("value",value).Attr("max",max).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag legend(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("legend").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag option(string? @class = null, string? value = null, bool? disabled = null, bool? selected = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("option").Attr("class",@class).Attr("value",value).Attr("disabled",disabled).Attr("selected",selected).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }

    public static HtmlTag noscript(string? @class = null, string? style = null, string? id = null, bool? hidden = null, string? onclick = null, string? role = null, string? tabindex = null)
    {
        return new HtmlTag("noscript").Attr("class",@class).Attr("style",style).Attr("id",id).Attr("hidden",hidden).Attr("onclick",onclick).Attr("role",role).Attr("tabindex",tabindex);
    }
}
