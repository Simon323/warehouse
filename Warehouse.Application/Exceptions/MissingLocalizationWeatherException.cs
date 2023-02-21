using Warehouse.Domain.ValueObjects;
using Warehouse.Shared.Abstractions.Exceptions;

namespace Warehouse.Application.Exceptions
{
    public class MissingLocalizationWeatherException : WarehouseExcepion
    {
        public Localization Localization { get; }

        public MissingLocalizationWeatherException(Localization localization)
            : base($"Couldn't fetch weather data for localization '{localization.Country}/{localization.City}'.")
        {
            Localization = localization;
        }
    }
}
