using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pharmacy_pos.datalayer.Registerar;
using pharmacy_pos.servicelayer.Services.Product;
using pharmacy_pos.servicelayer.Services.ProductType;
using pharmacy_pos.servicelayer.Services.Purchase;
using pharmacy_pos.servicelayer.Services.Sale;
using pharmacy_pos.servicelayer.Services.Supplier;

namespace pharmacy_pos.servicelayer.Registerar
{
    public static class ServiceLayerRegisterar
    {
        public static IServiceCollection ServiceLayerRegisterar_RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProductTypeService, ProductTypeService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IPurchaseService, PurchaseService>();
            services.AddTransient<ISaleService, SaleService>();
            services.AddTransient<ISupplierService, SupplierService>();
            services.DataLayerRegisterar_RegisterServices(configuration);
            return services;
        }
    }
}
