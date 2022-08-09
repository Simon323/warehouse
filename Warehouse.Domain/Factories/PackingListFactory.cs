using Warehouse.Domain.Consts;
using Warehouse.Domain.Entities;
using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Factories
{
    public class PackingListFactory : IPackingListFactory
    {
        public PackingList Create(PackingListId id, PackingListName name, Localization localization)
        {
            throw new NotImplementedException();
        }

        public PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, TravelDays days, Gender gender, Temperature temperature, Localization localization)
        {
            throw new NotImplementedException();
        }
    }
}
