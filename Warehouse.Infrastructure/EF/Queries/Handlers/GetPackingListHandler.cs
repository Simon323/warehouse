using Microsoft.EntityFrameworkCore;
using Warehouse.Application.DTO;
using Warehouse.Application.Queries;
using Warehouse.Infrastructure.EF.Contexts;
using Warehouse.Infrastructure.EF.Models;
using Warehouse.Shared.Abstractions.Queries;

namespace Warehouse.Infrastructure.EF.Queries.Handlers
{
    internal sealed class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
    {
        private readonly DbSet<PackingListReadModel> _packingLists;

        public GetPackingListHandler(ReadDbContext context)
            => _packingLists = context.PackingList;

        public Task<PackingListDto> HandleAsync(GetPackingList query)
            => _packingLists
                .Include(pl => pl.Items)
                .Where(pl => pl.Id == query.Id)
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .SingleOrDefaultAsync();
    }
}
