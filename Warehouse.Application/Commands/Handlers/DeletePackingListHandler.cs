using Warehouse.Application.Exceptions;
using Warehouse.Domain.Repositories;
using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands.Handlers
{
    internal sealed class DeletePackingListHandler : ICommandHandler<DeletePackingList>
    {
        private readonly IPackingListRepository _repository;

        public DeletePackingListHandler(IPackingListRepository repository) => _repository = repository;

        public async Task HandleAsync(DeletePackingList command)
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
