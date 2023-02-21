using Warehouse.Application.Exceptions;
using Warehouse.Domain.Repositories;
using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands.Handlers
{
    public class RemovePackingItemHandler : ICommandHandler<RemovePackingItem>
    {
        private readonly IPackingListRepository _repository;

        public RemovePackingItemHandler(IPackingListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(RemovePackingItem command)
        {
            var packingList = await _repository.GetAsync(command.PackingListId);

            if (packingList is null)
            {
                throw new PackingListNotFoundExcepiotn(command.PackingListId);
            }

            packingList.RemoveItem(command.Name);

            await _repository.UpdateAsync(packingList);
        }
    }
}
