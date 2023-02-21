using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Application.Exceptions
{
    public class PackingListAlreadyExistsException : WarehouseExcepion
    {
        public string Name { get; }

        public PackingListAlreadyExistsException(string name)
            : base($"Packing list with name '{name}' already exists.")
        {
            Name = name;
        }
    }
}
