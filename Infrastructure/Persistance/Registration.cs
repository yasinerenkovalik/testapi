using Api.Application.Interfaces.Repositories;
using Api.Application.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Persistence.Context;
using Persistence.Repositories;
using Persistence.UnitOfWorks;


namespace Persistence 
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<AppDbContext>(); // PostgreSQL bağlantı dizesini kullanıyoruz
            serviceCollection.AddScoped(typeof(IReadRepository<>),typeof(ReadRepository<>));
            serviceCollection.AddScoped(typeof(IWriteRepository<>),typeof(WriteRepository<>));
            serviceCollection.AddScoped<IUnitOfWorks, UnitOfWork>();
        }
    }
}