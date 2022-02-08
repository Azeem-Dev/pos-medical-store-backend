using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pharmacy_pos.datalayer.Repository;
using pharmacy_pos.datalayer.Repository.Product;
using pharmacy_pos.datalayer.Repository.ProductType;
using pharmacy_pos.ef.Registerar;

namespace pharmacy_pos.datalayer.Registerar
{
    public static class DataLayerRegisterar
    {
        public static IServiceCollection DataLayerRegisterar_RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(DataLayerRegisterar));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IProductTypeRepo,ProductTypeRepo>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.EfLayerRegisterar_RegisterServices(configuration);
            return services;
        }
    }
}
