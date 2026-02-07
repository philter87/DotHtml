using Microsoft.Extensions.DependencyInjection;

namespace DotHtml.Asp;

/// <summary>
/// Extension methods for configuring DotHtml in ASP.NET Core applications.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds DotHtml support to MVC, allowing controllers to return HtmlNode objects directly.
    /// </summary>
    /// <param name="builder">The IMvcBuilder to configure.</param>
    /// <returns>The IMvcBuilder for chaining.</returns>
    public static IMvcBuilder AddDotHtml(this IMvcBuilder builder)
    {
        builder.AddMvcOptions(options =>
        {
            options.OutputFormatters.Insert(0, new HtmlNodeOutputFormatter());
        });

        return builder;
    }
}

