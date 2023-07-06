using Warehouse.Application.DTO.External;
using Warehouse.Application.Services;
using Warehouse.Domain.ValueObjects;

namespace Warehouse.Infrastructure.Services
{
    internal sealed class DumbWeatherService : IWeatherService
    {
        public Task<WeatherDto> GetWeatherAsync(Localization localization)
            => Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
    }
}
