using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Domain.Exceptions
{
    public class InvalidTravelDaysException : WarehouseExcepion
    {
        public ushort Days { get; }

        public InvalidTravelDaysException(ushort days) : base($"Value '{days}' is invalid travel days.") => Days = days;
    }
}
