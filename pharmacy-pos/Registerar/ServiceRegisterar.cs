using pharmacy_pos.servicelayer.Registerar;
namespace pharmacy_pos.api.Registerar
{
    public static class ServiceRegisterar
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.ServiceLayerRegisterar_RegisterServices(configuration);
            return services;
        }
    }
}
