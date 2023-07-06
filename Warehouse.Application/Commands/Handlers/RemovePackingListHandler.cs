using Warehouse.Application.Exceptions;
using Warehouse.Domain.Repositories;
using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands.Handlers
{
    internal sealed class RemovePackingListHandler : ICommandHandler<RemovePackingList>
    {
        private readonly IPackingListRepository _repository;

        public RemovePackingListHandler(IPackingListRepository repository) => _repository = repository;

        public async Task HandleAsync(RemovePackingList command)
        {
            var packingList = await _repository.GetAsync(command.Id);

            if (packingList is null)
            {
                throw new PackingListNotFoundExcepiotn(command.Id);
            }

            await _repository.DeleteAsync(packingList);
        }
    }
}
