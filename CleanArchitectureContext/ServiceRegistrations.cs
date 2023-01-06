using CleanArchitectureApplication.Repositories.Persistance;
using CleanArchitectureContext.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureContext
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MainDatabase>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MSSQL-ConnectionString")));

            //generic way of registering repositories
            services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
            
            return services;
        }
    }
}
