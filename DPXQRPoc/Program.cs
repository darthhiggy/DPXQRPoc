using DPXQRPoc.Helpers;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) => {
        services.ConfigureService(context);
    })
    .Build();

await host.RunAsync();
