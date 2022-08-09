using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Domain.Exceptions
{
    public class PackingItemNotFoundException : WarehouseExcepion
    {
        public string ItemName { get; }

        public PackingItemNotFoundException(string itemName)
            : base($"Packing item 'itemName' was not found.") => ItemName = itemName;
    }
}
