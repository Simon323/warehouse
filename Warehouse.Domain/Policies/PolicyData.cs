using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Policies
{
    public record PolicyData(TravelDays Days, Consts.Gender Gender, Temperature Temperature, Localization Localization);
}
