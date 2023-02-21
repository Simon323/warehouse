using Microsoft.Extensions.DependencyInjection;
using Warehouse.Shared.Queries;

namespace Warehouse.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddQueries();

            return services;
        }
    }
}
