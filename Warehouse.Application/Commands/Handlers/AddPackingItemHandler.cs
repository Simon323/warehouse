using Warehouse.Application.Exceptions;
using Warehouse.Domain.Repositories;
using Warehouse.Domain.ValueObjects;
using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands.Handlers
{
    public class AddPackingItemHandler : ICommandHandler<AddPackingItem>
    {
        private readonly IPackingListRepository _repository;

        public AddPackingItemHandler(IPackingListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(AddPackingItem command)
        {
            var packingList = await _repository.GetAsync(command.PackingListId);

            if (packingList is null)
            {
                throw new PackingListNotFoundExcepiotn(command.PackingListId);
            }

            var packingItem = new PackingItem(command.Name, command.Quantity);
            packingList.AddItem(packingItem);

            await _repository.UpdateAsync(packingList);
        }
    }
}
