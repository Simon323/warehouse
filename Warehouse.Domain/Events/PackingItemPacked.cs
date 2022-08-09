using Warehouse.Domain.Entities;
using Warehouse.Domain.ValueObjects;
using Warehouse.Shared.Abstractions.Domain;

namespace Warehouse.Domain.Events
{
    public record PackingItemPacked(PackingList PackingList, PackingItem PackingItem) : IDomainEvent;
}
