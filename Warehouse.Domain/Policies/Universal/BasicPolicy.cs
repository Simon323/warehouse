using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Policies.Universal
{
    internal sealed class BasicPolicy : IPackingItemsPolicy
    {
        private const uint MaximumQuantityOfClothes = 7;

        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new ("Pants", Math.Min(data.Days, MaximumQuantityOfClothes)),
                new ("Socks", Math.Min(data.Days, MaximumQuantityOfClothes)),
                new ("T-Shirt", Math.Min(data.Days, MaximumQuantityOfClothes)),
                new ("Trousers", data.Days < 7 ? 1u : 2u),
                new ("Towel", 1),
                new ("Bag pack", 1)
            };

        public bool IsApplicable(PolicyData _) => true;
    }
}
