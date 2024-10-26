using Cupom.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cupom.Infrastructure
{
    public static class InfrastructureModules
    {
        private static IConfiguration _configuratio = null!;
        public static IServiceCollection AddInfrastructur(this IServiceCollection services, IConfiguration configuration)
        {
            _configuratio = configuration;
            services.AddDbase();

            return services;
        }

        private static IServiceCollection AddDbase(this IServiceCollection services) {

            services.AddDbContext<DbContextCp>(x =>
            {
                x.UseSqlServer(_configuratio.GetConnectionString("sqlServer"));
            });

             return services;
        }
    }
}
