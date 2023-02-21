using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Policies.Temperature
{
    internal sealed class LowTemperaturePoilcy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Scarf", 1),
                new("Winter hat", 1),
                new("Gloves", 1),
                new("Warm jacket", 1),
            };

        public bool IsApplicable(PolicyData data) => data.Temperature < 10D;
    }
}
