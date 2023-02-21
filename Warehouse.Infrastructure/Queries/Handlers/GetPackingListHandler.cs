using Warehouse.Application.DTO;
using Warehouse.Application.Queries;
using Warehouse.Shared.Abstractions.Queries;

namespace Warehouse.Infrastructure.Queries.Handlers
{
    public class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
    {
        public Task<PackingListDto> HandleAsync(GetPackingList query)
        {
            return null;
        }
    }
}
