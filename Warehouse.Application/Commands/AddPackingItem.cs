using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands
{
    public record AddPackingItem(Guid PackingListId, string Name, uint Quantity) : ICommand;
}
