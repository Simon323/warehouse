using Warehouse.Application.DTO;
using Warehouse.Application.Queries;
using Warehouse.Shared.Abstractions.Queries;

namespace Warehouse.Infrastructure.Queries.Handlers
{
    public class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
    {
        public Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
        {
            return null;
        }
    }
}
