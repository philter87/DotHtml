using DotHtml.Htmx;

namespace DotHtml;

/// <summary>
/// Extension methods for HTMX attributes on HTML tags.
/// HTMX allows you to access AJAX, CSS Transitions, WebSockets and Server Sent Events
/// directly in HTML, using attributes, so you can build modern user interfaces
/// with the simplicity and power of hypertext.
/// </summary>
public static class HtmxExtensions
{
    /// <summary>
    /// Issues a GET request to the specified URL.
    /// </summary>
    /// <param name="tag">The HTML tag to apply the attribute to.</param>
    /// <param name="name">The URL endpoint to GET from.</param>
    /// <returns>The modified HTML tag for method chaining.</returns>
    /// <example>
    /// <code>
    /// button().HxGet("/api/users")
    /// </code>
    /// </example>
    public static HtmlTag HxGet(this HtmlTag tag, string name)
    {
        return tag.Attr("hx-get", name);
    }

    /// <summary>
    /// Issues a POST request to the specified URL.
    /// </summary>
    /// <param name="tag">The HTML tag to apply the attribute to.</param>
    /// <param name="name">The URL endpoint to POST to.</param>
    /// <returns>The modified HTML tag for method chaining.</returns>
    /// <example>
    /// <code>
    /// button().HxPost("/api/users")
    /// </code>
    /// </example>
    public static HtmlTag HxPost(this HtmlTag tag, string name)
    {
        return tag.Attr("hx-post", name);
    }

    /// <summary>
    /// Issues a PATCH request to the specified URL.
    /// </summary>
    /// <param name="tag">The HTML tag to apply the attribute to.</param>
    /// <param name="name">The URL endpoint to PATCH.</param>
    /// <returns>The modified HTML tag for method chaining.</returns>
    /// <example>
    /// <code>
    /// button().HxPatch("/api/users/123")
    /// </code>
    /// </example>
    public static HtmlTag HxPatch(this HtmlTag tag, string name)
    {
        return tag.Attr("hx-patch", name);
    }

    /// <summary>
    /// Issues a PUT request to the specified URL.
    /// </summary>
    /// <param name="tag">The HTML tag to apply the attribute to.</param>
    /// <param name="name">The URL endpoint to PUT to.</param>
    /// <returns>The modified HTML tag for method chaining.</returns>
    /// <example>
    /// <code>
    /// button().HxPut("/api/users/123")
    /// </code>
    /// </example>
    public static HtmlTag HxPut(this HtmlTag tag, string name)
    {
        return tag.Attr("hx-put", name);
    }

    /// <summary>
    /// Issues a DELETE request to the specified URL.
    /// </summary>
    /// <param name="tag">The HTML tag to apply the attribute to.</param>
    /// <param name="name">The URL endpoint to DELETE.</param>
    /// <returns>The modified HTML tag for method chaining.</returns>
    /// <example>
    /// <code>
    /// button().HxDelete("/api/users/123")
    /// </code>
    /// </example>
    public static HtmlTag HxSwap(this HtmlTag tag, string strategy)
    {
        return tag.Attr("hx-swap", strategy);
    }

    /// <summary>
    /// Specifies how the response content should be swapped into the DOM.
    /// </summary>
    /// <param name="tag">The HTML tag to apply the attribute to.</param>
    /// <param name="strategy">The swap strategy to use (InnerHTML, OuterHTML, BeforeBegin, AfterBegin, BeforeEnd, AfterEnd, Delete, None).</param>
    /// <returns>The modified HTML tag for method chaining.</returns>
    /// <remarks>
    /// The swap strategy determines where and how the response HTML is inserted:
    /// <list type="table">
    /// <item>
    /// <term>InnerHTML</term>
    /// <description>Replace inner html (default)</description>
    /// </item>
    /// <item>
    /// <term>OuterHTML</term>
    /// <description>Replace entire target element</description>
    /// </item>
    /// <item>
    /// <term>BeforeBegin</term>
    /// <description>Insert before the target element</description>
    /// </item>
    /// <item>
    /// <term>AfterBegin</term>
    /// <description>Insert before first child of target</description>
    /// </item>
    /// <item>
    /// <term>BeforeEnd</term>
    /// <description>Insert after last child of target</description>
    /// </item>
    /// <item>
    /// <term>AfterEnd</term>
    /// <description>Insert after the target element</description>
    /// </item>
    /// <item>
    /// <term>Delete</term>
    /// <description>Delete the target element</description>
    /// </item>
    /// <item>
    /// <term>None</term>
    /// <description>Do not swap the target</description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <example>
    /// <code>
    /// button().HxGet("/api/users").HxSwap(HxSwapStrategy.OuterHTML)
    /// </code>
    /// </example>
    public static HtmlTag HxSwap(this HtmlTag tag, Swap strategy)
    {
        var strategyString = strategy switch
        {
            Swap.InnerHTML => "innerHTML",
            Swap.OuterHTML => "outerHTML",
            Swap.BeforeBegin => "beforebegin",
            Swap.AfterBegin => "afterbegin",
            Swap.BeforeEnd => "beforeend",
            Swap.AfterEnd => "afterend",
            Swap.Delete => "delete",
            Swap.None => "none",
            _ => "innerHTML"
        };
        return tag.Attr("hx-swap", strategyString);
    }

    /// <summary>
    /// Specifies what event or events trigger the HTMX request.
    /// </summary>
    /// <param name="tag">The HTML tag to apply the attribute to.</param>
    /// <param name="trigger">The trigger specification. Can be an event name or a complex trigger expression.</param>
    /// <returns>The modified HTML tag for method chaining.</returns>
    /// <remarks>
    /// Common trigger values include:
    /// <list type="table">
    /// <item>
    /// <term>click</term>
    /// <description>Trigger on element click (default for buttons)</description>
    /// </item>
    /// <item>
    /// <term>change</term>
    /// <description>Trigger when input value changes (default for inputs)</description>
    /// </item>
    /// <item>
    /// <term>submit</term>
    /// <description>Trigger on form submission</description>
    /// </item>
    /// <item>
    /// <term>load</term>
    /// <description>Trigger when the element is loaded</description>
    /// </item>
    /// <item>
    /// <term>revealed</term>
    /// <description>Trigger when the element is scrolled into view</description>
    /// </item>
    /// <item>
    /// <term>intersect</term>
    /// <description>Trigger when the element intersects the viewport (Intersection Observer)</description>
    /// </item>
    /// <item>
    /// <term>mouseenter</term>
    /// <description>Trigger when mouse enters the element</description>
    /// </item>
    /// <item>
    /// <term>mouseleave</term>
    /// <description>Trigger when mouse leaves the element</description>
    /// </item>
    /// <item>
    /// <term>focus</term>
    /// <description>Trigger when input receives focus</description>
    /// </item>
    /// <item>
    /// <term>blur</term>
    /// <description>Trigger when input loses focus</description>
    /// </item>
    /// </list>
    /// 
    /// Advanced trigger modifiers:
    /// <list type="table">
    /// <item>
    /// <term>once</term>
    /// <description>Only trigger once: "click once"</description>
    /// </item>
    /// <item>
    /// <term>changed</term>
    /// <description>Only trigger if value changed: "change changed"</description>
    /// </item>
    /// <item>
    /// <term>delay</term>
    /// <description>Delay the request: "click delay:1s"</description>
    /// </item>
    /// <item>
    /// <term>throttle</term>
    /// <description>Throttle requests: "input throttle:500ms"</description>
    /// </item>
    /// <item>
    /// <term>from</term>
    /// <description>Listen for events from a different element: "click from:.my-class"</description>
    /// </item>
    /// <item>
    /// <term>target</term>
    /// <description>Specify the target for the swap: "click target:#my-div"</description>
    /// </item>
    /// <item>
    /// <term>filter</term>
    /// <description>Add a filter expression: "click [keyCode==13]"</description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <example>
    /// <code>
    /// // Simple click trigger
    /// button().HxTrigger("click")
    /// 
    /// // Change event on input
    /// input().HxTrigger("change")
    /// 
    /// // Only trigger once
    /// button().HxTrigger("click once")
    /// 
    /// // Delay before sending request
    /// button().HxTrigger("click delay:500ms")
    /// 
    /// // Throttle repeated requests
    /// input().HxTrigger("input throttle:1s")
    /// 
    /// // Only trigger on Enter key
    /// input().HxTrigger("keyup [keyCode==13]")
    /// 
    /// // Listen to events from another element
    /// div().HxTrigger("click from:.my-button")
    /// 
    /// // Load content when scrolled into view
    /// div().HxTrigger("revealed")
    /// </code>
    /// </example>
    public static HtmlTag HxTrigger(this HtmlTag tag, string trigger)
    {
        return tag.Attr("hx-trigger", trigger);
    }

    /// <summary>
    /// Specifies what event or events trigger the HTMX request using a type-safe enum with optional modifiers.
    /// </summary>
    /// <param name="tag">The HTML tag to apply the attribute to.</param>
    /// <param name="event">The event trigger type (e.g., Click, Change, KeyUp, etc.).</param>
    /// <param name="modifiers">Optional trigger modifiers that control trigger behavior. Can be combined with spaces.</param>
    /// <returns>The modified HTML tag for method chaining.</returns>
    /// <remarks>
    /// Trigger modifiers allow you to customize when and how triggers fire. Common modifiers include:
    /// <list type="table">
    /// <item>
    /// <term>once</term>
    /// <description>Trigger only once, then remove the trigger. Example: "once"</description>
    /// </item>
    /// <item>
    /// <term>changed</term>
    /// <description>Only trigger if the value of the element changes. Useful for input/change events. Example: "changed"</description>
    /// </item>
    /// <item>
    /// <term>delay:Xs</term>
    /// <description>Delay the request by X seconds (or other time units like ms). Example: "delay:1s" or "delay:500ms"</description>
    /// </item>
    /// <item>
    /// <term>throttle:Xs</term>
    /// <description>Throttle the request, firing at most once every X seconds. Useful for frequent events like typing. Example: "throttle:1s"</description>
    /// </item>
    /// <item>
    /// <term>debounce:Xs</term>
    /// <description>Debounce the request, waiting X seconds after the last event before firing. Example: "debounce:500ms"</description>
    /// </item>
    /// <item>
    /// <term>from:SELECTOR</term>
    /// <description>Listen for the trigger event from a different element. Example: "from:.my-button" or "from:#my-div"</description>
    /// </item>
    /// <item>
    /// <term>target:SELECTOR</term>
    /// <description>Specify a different target element for the swap. Example: "target:#my-container"</description>
    /// </item>
    /// <item>
    /// <term>[FILTER]</term>
    /// <description>Add a JavaScript filter expression. The request only fires if the expression is truthy. Example: "[keyCode==13]" (Enter key), "[ctrlKey]" (Ctrl pressed)</description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <example>
    /// <code>
    /// // Using enum with various modifiers
    /// 
    /// // Only trigger once
    /// button().HxTrigger(HxEvent.Click, "once")
    /// 
    /// // Delay before sending request
    /// button().HxTrigger(HxEvent.Click, "delay:500ms")
    /// 
    /// // Throttle repeated requests
    /// input().HxTrigger(HxEvent.Input, "throttle:1s")
    /// 
    /// // Debounce for search inputs
    /// input().HxTrigger(HxEvent.Input, "debounce:500ms")
    /// 
    /// // Only trigger if value changed
    /// input().HxTrigger(HxEvent.Change, "changed")
    /// 
    /// // Only trigger on Enter key
    /// input().HxTrigger(HxEvent.KeyUp, "[keyCode==13]")
    /// 
    /// // Only trigger if Ctrl+Enter is pressed
    /// input().HxTrigger(HxEvent.KeyUp, "[keyCode==13 &amp;&amp; ctrlKey]")
    /// 
    /// // Listen to events from another element
    /// div().HxTrigger(HxEvent.Click, "from:.my-button")
    /// 
    /// // Combine multiple modifiers
    /// input().HxTrigger(HxEvent.Input, "throttle:1s changed")
    /// 
    /// // Swap into a different target
    /// button().HxTrigger(HxEvent.Click, "target:#my-container")
    /// </code>
    /// </example>
    public static HtmlTag HxTrigger(this HtmlTag tag, HxEvent @event, string? modifiers = "")
    {
        return tag.Attr("hx-trigger", $"{@event.ToString().ToLower()} {modifiers}");
    }
    
    
}
