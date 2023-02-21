using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands
{
    public record AddPackingItem(Guid PackingListItem, string Name, uint Quantity) : ICommand;
}
