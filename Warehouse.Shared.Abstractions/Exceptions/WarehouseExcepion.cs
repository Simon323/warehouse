namespace Warehouse.Shared.Abstractions.Exceptions
{
    public abstract class WarehouseExcepion : Exception
    {
        protected WarehouseExcepion(string message) : base(message)
        {

        }
    }
}
