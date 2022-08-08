using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Domain.Exceptions
{
    public class EmptyPackingListItemNameException : WarehouseExcepion
    {
        public EmptyPackingListItemNameException() : base("Packing item name cannot be empty.")
        {
        }
    }
}
