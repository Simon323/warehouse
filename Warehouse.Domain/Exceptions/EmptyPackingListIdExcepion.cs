using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Domain.Exceptions
{
    public class EmptyPackingListIdExcepion : WarehouseExcepion
    {
        public EmptyPackingListIdExcepion() : base("Packing list ID cannot be empty.")
        {
        }
    }
}
