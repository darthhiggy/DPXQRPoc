using Amazon.SQS;
using DPXQRPoc.Core.Helpers;
using DPXQRPoc.Data.DbContexts;
using DPXQRPoc.Data.ExtensionMethods;

namespace DPXQRPoc.Helpers;

public static class ServiceSetup
{
    public static void ConfigureService(this IServiceCollection services, HostBuilderContext context)
    {
        services.AddHostedService<Worker>();
        services.AddDbContext<DPXPocDbContext>();
        services.AddRepositories();
        services.ConfigureMediatR();
        services.ConfigureAutoMapper();
        services.ConfigureServicesForAws(context);
    }
    
    private static void ConfigureServicesForAws(this IServiceCollection services, HostBuilderContext context)
    {
        services.AddDefaultAWSOptions(context.Configuration.GetAWSOptions());
        services.AddAWSService<IAmazonSQS>();
    }
}
