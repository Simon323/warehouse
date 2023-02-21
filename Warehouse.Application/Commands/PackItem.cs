using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands
{
    public record PackItem(Guid PackingListId, string Name) : ICommand;
}
