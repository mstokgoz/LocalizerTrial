using System.Reflection;
using System.Resources;
using Microsoft.Extensions.Localization;

namespace LocalizerTrial.Api.Localization;

public class CustomStringLocalizerFactory(
    IResourceNamesCache resourceNamesCache,
    ILoggerFactory loggerFactory)
    : IStringLocalizerFactory
{
    public IStringLocalizer Create(Type resourceSource)
    {
        var className = resourceSource.GetTypeInfo().Name;
        
        var resourcePath = $"{ResxPathConstants.ProjectLibrary}.{ResxPathConstants.CurrentPath}.{className}";

        var logger = loggerFactory.CreateLogger<ResourceManagerStringLocalizer>();

        return new ResourceManagerStringLocalizer(
            new ResourceManager(resourcePath, resourceSource.Assembly),
            resourceSource.Assembly,
            resourcePath,
            resourceNamesCache,
            logger
        );
    }

    public IStringLocalizer Create(string baseName, string location)
    {
        var logger = loggerFactory.CreateLogger<ResourceManagerStringLocalizer>();

        return new ResourceManagerStringLocalizer(
            new ResourceManager(baseName, Assembly.Load(location)),
            Assembly.Load(location),
            baseName,
            resourceNamesCache,
            logger
        );
    }
}