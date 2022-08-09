using Warehouse.Domain.Consts;
using Warehouse.Domain.Entities;
using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Factories
{
    public interface IPackingListFactory
    {
        PackingList Create(PackingListId id, PackingListName name, Localization localization);
        PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, TravelDays days, Gender gender, Temperature temperature, Localization localization);
    }
}
