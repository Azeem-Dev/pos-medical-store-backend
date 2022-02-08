using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pharmacy_pos.datalayer.Repository;
using pharmacy_pos.datalayer.Repository.Product;
using pharmacy_pos.datalayer.Repository.ProductType;
using pharmacy_pos.datalayer.Repository.Purchase;
using pharmacy_pos.datalayer.Repository.Sale;
using pharmacy_pos.datalayer.Repository.Supplier;
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
            services.AddTransient<IPurchaseRepository, PurchaseRepository>();
            services.AddTransient<ISaleRepository, SaleRepository>();
            services.AddTransient<ISupplierRepository, SupplierRepository>();
            services.EfLayerRegisterar_RegisterServices(configuration);
            return services;
        }
    }
}
