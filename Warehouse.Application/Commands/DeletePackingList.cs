using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands
{
    public record DeletePackingList(Guid Id) : ICommand;
}
