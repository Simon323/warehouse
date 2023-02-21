using Warehouse.Application.DTO;
using Warehouse.Shared.Abstractions.Queries;

namespace Warehouse.Application.Queries.Handlers
{
    public class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
    {
        //private readonly IPackingListRepository _repository;

        //public GetPackingListHandler(IPackingListRepository repository)
        //    => _repository = repository;

        public Task<PackingListDto> HandleAsync(GetPackingList query)
        {
            //var packingList = await _repository.GetAsync(query.Id);
            //return packingList?.AsDto();
            return null;
        }
    }
}
