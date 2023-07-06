using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Application.Services;
using Warehouse.Infrastructure.EF;
using Warehouse.Infrastructure.Logging;
using Warehouse.Infrastructure.Services;
using Warehouse.Shared.Abstractions.Commands;
using Warehouse.Shared.Queries;

namespace Warehouse.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPostgres(configuration);
            services.AddQueries();
            services.AddSingleton<IWeatherService, DumbWeatherService>();

            services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

            return services;
        }
    }
}
