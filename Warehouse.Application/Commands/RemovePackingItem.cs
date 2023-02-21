using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands
{
    public record RemovePackingItem(Guid PackingListItem, string Name) : ICommand;
}
