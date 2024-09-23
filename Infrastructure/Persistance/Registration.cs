using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Context;

namespace Persistance;

public static class Registration
{
    public static void AddPersistance(this IServiceCollection serviceCollection,IConfiguration configuration)
    {
        serviceCollection.AddDbContext<AppDbContext>(opt=>opt.UseNpgsql(configuration.GetConnectionString("PostgreSQL")));
    }
}