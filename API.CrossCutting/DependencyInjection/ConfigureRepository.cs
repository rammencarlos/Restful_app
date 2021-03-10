using System;
using Microsoft.Extensions.DependencyInjection;
using API.Data.Implementation;
using API.Domain.Interfaces;
using API.Domain.Repository;

namespace API.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            //Podriamos usar un repositorio generico
            //serviceCollection.AddScoped(typeof(IRepository<>),ProductImplementation);

            serviceCollection.AddScoped<IProductRepository, ProductImplementation>();
        }
    }
      
}
