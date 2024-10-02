using Api.Application2.Interfaces.AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Mapper;


    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
