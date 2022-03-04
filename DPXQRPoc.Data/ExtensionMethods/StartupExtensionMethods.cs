using DPXQRPoc.Data.Repositories;
using DPXQRPoc.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DPXQRPoc.Data.ExtensionMethods;

public static class StartupExtensionMethods
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IIsoTimestampRepository, IsoTimestampRepository>();
    }
}
