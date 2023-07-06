using Microsoft.Extensions.DependencyInjection;
using Warehouse.Shared.Services;

namespace Warehouse.Shared
{
    public static class Extensions
    {
        public static IServiceCollection AddShared(this IServiceCollection services)
        {
            services.AddHostedService<AppInitializer>();
            return services;
        }
    }
}
