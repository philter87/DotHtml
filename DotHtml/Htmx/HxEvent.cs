namespace DotHtml.Htmx;

/// <summary>
/// Common HTML event listener events that can trigger HTMX requests.
/// </summary>
public enum HxEvent
{
    /// <summary>Element or window has been scrolled into view</summary>
    Revealed,
    /// <summary>Element is clicked</summary>
    Click,
    /// <summary>Element is double-clicked</summary>
    DoubleClick,
    /// <summary>Mouse pointer enters element</summary>
    MouseEnter,
    /// <summary>Mouse pointer leaves element</summary>
    MouseLeave,
    /// <summary>Element receives focus</summary>
    Focus,
    /// <summary>Element loses focus</summary>
    Blur,
    /// <summary>Input value changes (for input, select, textarea)</summary>
    Change,
    /// <summary>User is typing in input (fires multiple times during input)</summary>
    Input,
    /// <summary>Key is pressed down</summary>
    KeyDown,
    /// <summary>Key is pressed up</summary>
    KeyUp,
    /// <summary>Form is submitted</summary>
    Submit,
    /// <summary>Element is loaded</summary>
    Load,
    /// <summary>Element is scrolling</summary>
    Scroll
}