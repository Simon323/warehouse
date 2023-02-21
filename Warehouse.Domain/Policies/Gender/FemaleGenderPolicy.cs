using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Policies.Gender
{
    internal class FemaleGenderPolicy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data) => new List<PackingItem>
        {
            new PackingItem("Book", 1),
            new PackingItem("Pen", 2),
            new PackingItem("Eyeliner", 3),
        };

        public bool IsApplicable(PolicyData data) => data.Gender is Consts.Gender.Female;
    }
}
