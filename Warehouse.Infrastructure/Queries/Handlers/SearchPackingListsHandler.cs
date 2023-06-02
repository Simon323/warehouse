using Microsoft.EntityFrameworkCore;
using Warehouse.Application.DTO;
using Warehouse.Application.Queries;
using Warehouse.Infrastructure.EF.Contexts;
using Warehouse.Infrastructure.EF.Models;
using Warehouse.Shared.Abstractions.Queries;

namespace Warehouse.Infrastructure.Queries.Handlers
{
    internal sealed class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
    {
        private readonly DbSet<PackingListReadModel> _packingLists;

        public SearchPackingListsHandler(ReadDbContext context)
            => _packingLists = context.PackingList;

        public async Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
        {
            var dbQuery = _packingLists
                .Include(pl => pl.Items)
                .AsQueryable();

            if (query.SearchPhrase is not null)
            {
                dbQuery = dbQuery.Where(pl => Microsoft.EntityFrameworkCore.EF.Functions.ILike(pl.Name, $"%{query.SearchPhrase}%"));
            }

            return await dbQuery
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
