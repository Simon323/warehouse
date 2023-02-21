using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Policies.Gender
{
    internal class MaleGenderPolicy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data) => new List<PackingItem>
        {
            new PackingItem("PC", 1),
            new PackingItem("Phone", 2),
            new PackingItem("Watch", (uint)Math.Ceiling(data.Days/7m)),
        };

        public bool IsApplicable(PolicyData data) => data.Gender is Consts.Gender.Male;
    }
}