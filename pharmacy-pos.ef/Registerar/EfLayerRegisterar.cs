using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pharmacy_pos.ef.Data;

namespace pharmacy_pos.ef.Registerar
{
    public static class EfLayerRegisterar
    {
        public static IServiceCollection EfLayerRegisterar_RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(option => option.UseSqlServer(
                                                            configuration.GetConnectionString("DefaultConnection"),
                                                            x => x.MigrationsAssembly("pharmacy-pos.ef")
                                                            )
                                                          );
            return services;
        }
    }
}
