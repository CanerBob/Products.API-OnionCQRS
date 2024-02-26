using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace API.Application;
public static class Registiration
{
    public static void AddApplication(this IServiceCollection services) 
    {
        var assembly= Assembly.GetExecutingAssembly();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
    }
}
