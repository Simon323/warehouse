using Warehouse.Domain.ValueObjects;

namespace Warehouse.Domain.Policies
{
    public interface IPackingItemPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<PackingItem> GenerateItems(PolicyData data);
    }
}
