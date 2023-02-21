using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Application.Exceptions
{
    public class PackingListNotFoundExcepiotn : WarehouseExcepion
    {
        public Guid Name { get; }

        public PackingListNotFoundExcepiotn(Guid name)
            : base($"Packing list with name '{name}' not found.")
        {
            Name = name;
        }

    }
}
