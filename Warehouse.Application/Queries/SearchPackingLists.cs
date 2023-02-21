using Warehouse.Application.DTO;
using Warehouse.Shared.Abstractions.Queries;

namespace Warehouse.Application.Queries
{
    public class SearchPackingLists : IQuery<IEnumerable<PackingListDto>>
    {
        public string SearchPhrase { get; set; }
    }
}
