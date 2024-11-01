using Microsoft.Extensions.Options;

namespace LocalizerTrial.Api.Localization;

public static class LocalizationMiddleware
{
    public static void UseLocalization(this IApplicationBuilder app)
    {
        var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>()?.Value;
        
        app.UseRequestLocalization(options);
    }
}