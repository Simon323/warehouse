using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Application.Services;
using Warehouse.Domain.Repositories;
using Warehouse.Infrastructure.EF.Contexts;
using Warehouse.Infrastructure.EF.Options;
using Warehouse.Infrastructure.EF.Repositories;
using Warehouse.Infrastructure.EF.Services;
using Warehouse.Shared.Options;

namespace Warehouse.Infrastructure.EF
{
    internal static class Extensions
    {
        public static IServiceCollection AddPostgres(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPackingListRepository, PostgresPackingListRepository>();
            services.AddScoped<IPackingListReadService, PostgresPackingListReadService>();

            var options = configuration.GetOptions<PostgresOptions>("Postgres");
            services.AddDbContext<ReadDbContext>(ctx =>
                ctx.UseNpgsql(options.ConnectionString));
            services.AddDbContext<WriteDbContext>(ctx =>
                ctx.UseNpgsql(options.ConnectionString));

            return services;
        }
    }
}
