using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Policies
{
    public record PolicyData(TravelDays Days, Consts.Gender Gender, ValueObjects.Temperature Temperature, Localization Localization);
}
