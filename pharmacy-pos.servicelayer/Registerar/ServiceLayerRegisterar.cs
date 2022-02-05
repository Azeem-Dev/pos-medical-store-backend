using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pharmacy_pos.datalayer.Registerar;
using pharmacy_pos.servicelayer.Services.ProductType;

namespace pharmacy_pos.servicelayer.Registerar
{
    public static class ServiceLayerRegisterar
    {
        public static IServiceCollection ServiceLayerRegisterar_RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProductTypeService, ProductTypeService>();
            services.DataLayerRegisterar_RegisterServices(configuration);
            return services;
        }
    }
}
