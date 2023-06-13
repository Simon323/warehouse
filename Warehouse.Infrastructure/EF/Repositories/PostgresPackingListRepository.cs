using Microsoft.EntityFrameworkCore;
using Warehouse.Domain.Entities;
using Warehouse.Domain.Repositories;
using Warehouse.Domain.ValueObjects;
using Warehouse.Infrastructure.EF.Contexts;

namespace Warehouse.Infrastructure.EF.Repositories
{
    internal sealed class PostgresPackingListRepository : IPackingListRepository
    {
        private readonly DbSet<PackingList> _packingLists;
        private readonly WriteDbContext _writeDbContext;

        public PostgresPackingListRepository(WriteDbContext writeDbContext)
        {
            _packingLists = writeDbContext.PackingLists;
            _writeDbContext = writeDbContext;
        }

        public async Task AddAsync(PackingList packingList)
        {
            await _packingLists.AddAsync(packingList);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(PackingList packingList)
        {
            _packingLists.Remove(packingList);
            await _writeDbContext.SaveChangesAsync();
        }

        public Task<PackingList> GetAsync(PackingListId id)
            => _packingLists.Include("_items").SingleOrDefaultAsync(pl => pl.Id == id);

        public async Task UpdateAsync(PackingList packingList)
        {
            _packingLists.Update(packingList);
            await _writeDbContext.SaveChangesAsync();
        }
    }
}
