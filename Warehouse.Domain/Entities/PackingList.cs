using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Entities
{
    public class PackingList
    {
        public Guid Id { get; private set; }

        private PackingListName _name;

        private string _localization;

        internal PackingList(Guid id, PackingListName name, string localization)
        {
            this.Id = id;
            this._name = name;
            this._localization = localization;
        }
    }
}
