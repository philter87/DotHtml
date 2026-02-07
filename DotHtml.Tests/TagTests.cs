using FluentAssertions;
using Xunit;
using static DotHtml.Tags;

namespace DotHtml.Tests;

public class TagTests
{
    [Fact]
    public void Should_ReturnValidHtml_When_UsingHtmlTagsAndText()
    {
        // Arrange
        var div = new HtmlTag("div") << [
            new HtmlTag("p") << ["Apple"],
            "Hello, World!"
        ];
        
        // Act
        var html = div.ToHtml();
        
        // Assert
        html.Should().Be("<div><p>Apple</p>Hello, World!</div>");
    }
    
    [Fact]
    public void Should_ReturnValidHtml_When_UsingHtmlTagsAndAttributes()
    {
        // Arrange
        var div = new HtmlTag("div").Attr("class","no-class") << [
            "Hello, World!"
        ];
        
        // Act
        var html = div.ToHtml();
        
        // Assert
        html.Should().Be("""<div class="no-class">Hello, World!</div>""");
    }
    
    [Fact]
    public void Should_ReturnValidHtml_When_UsingStaticMethods()
    {
        // Arrange
        var tag = div("no-class", style: "width: 10px") << [
            p() << "Hello",
            "World!"
        ];
        
        // Act
        var html = tag.ToHtml();
        
        // Assert
        html.Should().Be("""<div class="no-class" style="width: 10px"><p>Hello</p>World!</div>""");
    }
    
    [Fact]
    public void Should_NotAllowXss_When_UsingDefaults()
    {
        // Arrange
        var tag = div() << [
            "<script>alert('XSS');</script>"
        ];
        
        // Act
        var html = tag.ToHtml();
        
        // Assert
        html.Should().Be("<div>&lt;script&gt;alert(&#39;XSS&#39;);&lt;/script&gt;</div>");
    }
    
    [Fact]
    public void Should_AllowHtmlAndXss_When_True()
    {
        // Arrange
        var tag = div() << [
            "<script>alert('XSS');</script>"
        ];
        
        // Act
        var html = tag.ToHtml(true);
        
        // Assert
        html.Should().Be("<div><script>alert('XSS');</script></div>");
    }
    
    
    [Fact]
    public void Should_AllowHtmlAndXss_When_AllowingRawHtml()
    {
        // Arrange
        var tag = div().AllowRawHtml() << [
            "<script>alert('XSS');</script>"
        ];
        
        // Act
        var html = tag.ToHtml();
        
        // Assert
        html.Should().Be("<div><script>alert('XSS');</script></div>");
    }
    
    [Fact]
    public void Should_IgnoreNullValues_When_AddedAsChild()
    {
        // Arrange
        string? nullString = null;
        var tag = div() << [
            p() << "Hello World!", 
            null, 
            p() << nullString, 
            p() << "Bla"
        ];
        
        // Act
        var html = tag.ToHtml();
        
        // Assert
        html.Should().Be("<div><p>Hello World!</p><p></p><p>Bla</p></div>");
    }
}