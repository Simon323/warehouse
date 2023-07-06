using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands
{
    public record RemovePackingList(Guid Id) : ICommand;
}
