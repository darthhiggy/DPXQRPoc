using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DPXQRPoc.Core.Helpers;

public static class Startup
{
    public static void ConfigureMediatR(this IServiceCollection services)
    {
        services.AddMediatR(typeof(Startup));
    }

    public static void ConfigureAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Startup));
    }
}
