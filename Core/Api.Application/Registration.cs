using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Application2;

public static class Registration
{
    public static void AddApplication(this IServiceCollection serviceCollection)
    {
        var assembly = Assembly.GetExecutingAssembly();
        serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
    }
}