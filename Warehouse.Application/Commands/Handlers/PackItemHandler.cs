using Warehouse.Application.Exceptions;
using Warehouse.Domain.Repositories;
using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands.Handlers
{
    public class PackItemHandler : ICommandHandler<PackItem>
    {
        private readonly IPackingListRepository _repository;

        public PackItemHandler(IPackingListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(PackItem command)
        {
            var packingList = await _repository.GetAsync(command.PackingListId);

            if (packingList is null)
            {
                throw new PackingListNotFoundExcepiotn(command.PackingListId);
            }

            packingList.PackItem(command.Name);

            await _repository.UpdateAsync(packingList);
        }
    }
}
