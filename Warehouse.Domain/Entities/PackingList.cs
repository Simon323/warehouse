using Warehouse.Domain.Exceptions;
using Warehouse.Domain.ValueObjects;
using Warehouse.Shared.Abstractions.Domain;

namespace Warehouse.Domain.Entities
{
    public class PackingList : AggregateRoot<Guid>
    {
        public PackingListId Id { get; private set; }

        private PackingListName _name;

        private Localization _localization;

        private readonly LinkedList<PackingItem> _items = new();

        internal PackingList(Guid id, PackingListName name, Localization localization, LinkedList<PackingItem> items)
        {
            this.Id = id;
            this._name = name;
            this._localization = localization;
            this._items = items;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExists = this._items.Any(x => x.Name == item.Name);

            if (alreadyExists)
            {
                throw new PackingItemAlreadyExistsException(this._name, item.Name);
            }

            this._items.AddLast(item);
        }
    }
}