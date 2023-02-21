using Warehouse.Application.DTO;
using Warehouse.Shared.Abstractions.Queries;

namespace Warehouse.Application.Queries
{
    public class GetPackingList : IQuery<PackingListDto>
    {
        public Guid Id { get; set; }
    }
}
