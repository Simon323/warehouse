using Microsoft.Extensions.DependencyInjection;
using Warehouse.Domain.Factories;
using Warehouse.Domain.Policies;
using Warehouse.Shared.Commands;

namespace Warehouse.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddCommands();
            services.AddSingleton<IPackingListFactory, IPackingListFactory>();

            services.Scan(x => x.FromAssemblies(typeof(IPackingItemsPolicy).Assembly)
                .AddClasses(x => x.AssignableTo<IPackingItemsPolicy>())
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            return services;
        }
    }
}
