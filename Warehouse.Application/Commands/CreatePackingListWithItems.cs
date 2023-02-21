using Warehouse.Domain.Consts;
using Warehouse.Shared.Abstractions.Commands;

namespace Warehouse.Application.Commands
{
    public record CreatePackingListWithItems(Guid Id, string Name, ushort Days, Gender Gender, LocalizationWriteModel Localization) : ICommand;

    public record LocalizationWriteModel(string City, string Country);
}
