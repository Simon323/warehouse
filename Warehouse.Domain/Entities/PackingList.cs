using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Entities
{
    public class PackingList
    {
        public Guid Id { get; private set; }

        private PackingListName _name;

        private Localization _localization;

        internal PackingList(Guid id, PackingListName name, Localization localization)
        {
            this.Id = id;
            this._name = name;
            this._localization = localization;
        }
    }
}

//https://youtu.be/NzcZcim9tp8?t=4742