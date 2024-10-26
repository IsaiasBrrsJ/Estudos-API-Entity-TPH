using Cumpom.Application.Services;
using Cumpom.Core.Abstractions;
using Cumpom.Core.Repositories;
using Cupom.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Cumpom.Application
{
    public static class ApplicationModules
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .RepositoryService()
                .AddServicesApplication();

            return services;
        }
        private static IServiceCollection RepositoryService(this IServiceCollection services)
        {
            services.AddTransient<IClientRepositories, ClientRepositories>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
        private static IServiceCollection AddServicesApplication(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();

            return services;
        }
    }
}
