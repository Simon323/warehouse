using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Infrastructure.EF.Contexts;
using Warehouse.Infrastructure.EF.Options;
using Warehouse.Shared.Options;

namespace Warehouse.Infrastructure.EF
{
    internal static class Extensions
    {
        public static IServiceCollection AddPostgres(this IServiceCollection services, IConfiguration configuration)
        {
            var options = configuration.GetOptions<PostgresOptions>("Postgres");
            services.AddDbContext<ReadDbContext>(ctx =>
                ctx.UseNpgsql(options.ConnectionString));
            services.AddDbContext<WriteDbContext>(ctx =>
                ctx.UseNpgsql(options.ConnectionString));

            return services;
        }
    }
}
