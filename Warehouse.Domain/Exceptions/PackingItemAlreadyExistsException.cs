using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Domain.Exceptions
{
    public class PackingItemAlreadyExistsException : WarehouseExcepion
    {


        public PackingItemAlreadyExistsException(string listName, string itemName)
            : base($"Packing list '{listName}' already defined item '{itemName}'")
        {
        }
    }
}
