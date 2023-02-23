using Microsoft.EntityFrameworkCore;
using Warehouse.Infrastructure.EF.Config;
using Warehouse.Infrastructure.EF.Models;

namespace Warehouse.Infrastructure.EF.Contexts
{
    internal sealed class ReadDbContext : DbContext
    {
        public DbSet<PackingListReadModel> PackingList { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("packing");

            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<PackingListReadModel>(configuration);
            modelBuilder.ApplyConfiguration<PackingItemReadModel>(configuration);
        }
    }
}
