namespace ECommerce.Application.Extensions;

using ECommerce.Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void RegisterApplication(this IServiceCollection services)
    {
        var applicationAssembly = typeof(IAssemblyReference).Assembly;

        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(applicationAssembly));
    }
}
