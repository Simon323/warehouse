using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Domain.Exceptions
{
    public class EmptyPackingListNameExcepion : WarehouseExcepion
    {
        public EmptyPackingListNameExcepion() : base("packing list name is empty")
        {
        }
    }
}
