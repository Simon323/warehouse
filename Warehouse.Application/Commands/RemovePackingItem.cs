using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands
{
    public record RemovePackingItem(Guid PackingListId, string Name) : ICommand;
}
