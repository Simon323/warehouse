using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Policies.Temperature
{
    internal sealed class HighTemperaturePoilcy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Hat", 1),
                new("Sunglasses", 1),
                new("Cream", 1)
            };

        public bool IsApplicable(PolicyData data) => data.Temperature > 25D;
    }
}
