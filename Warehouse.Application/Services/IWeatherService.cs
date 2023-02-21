using Warehouse.Application.DTO.External;
using Warehouse.Domain.ValueObjects;

namespace Warehouse.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDto> GetWeatherAsync(Localization localization);
    }
}
