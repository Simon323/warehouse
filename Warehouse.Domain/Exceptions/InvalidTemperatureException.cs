using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Domain.Exceptions
{
    public class InvalidTemperatureException : WarehouseExcepion
    {
        public double Value { get; }

        public InvalidTemperatureException(double value) : base($"Value '{value}' is invalid temperature.") => Value = value;
    }
}
