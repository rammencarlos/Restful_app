using Microsoft.Extensions.DependencyInjection;
using API.Domain.Interfaces.Services.Product;
using API.Service.Services;

namespace API.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProductService, ProductService>();
        }
    }
}
