using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;

namespace LocalizerTrial.Api.Localization;

public static class LocalizationRegistrer
{
    public static void RegisterLocalizationOptions(this IServiceCollection services)
    {
        services.AddSingleton<IStringLocalizerFactory, CustomStringLocalizerFactory>();

        services.AddSingleton<IResourceNamesCache, ResourceNamesCache>();
        
        services.AddLocalization(options => options.ResourcesPath = ResxPathConstants.CurrentPath);
        
        services.Configure<RequestLocalizationOptions>(options =>
        {
            var supportedCultures = new[]
            {
                new CultureInfo(SupportedCultures.Turkish), 
                new CultureInfo(SupportedCultures.English), 
            };
            
            options.DefaultRequestCulture = new RequestCulture(SupportedCultures.Turkish);
            
            options.SupportedCultures = supportedCultures;
            options.SupportedUICultures = supportedCultures;
            
            options.RequestCultureProviders.Insert(0, new AcceptLanguageHeaderRequestCultureProvider());
        });
    }
}