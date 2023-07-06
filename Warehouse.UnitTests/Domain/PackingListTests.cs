using Shouldly;
using Warehouse.Domain.Entities;
using Warehouse.Domain.Events;
using Warehouse.Domain.Exceptions;
using Warehouse.Domain.Factories;
using Warehouse.Domain.Policies;
using Warehouse.Domain.ValueObjects;

namespace Warehouse.UnitTests.Domain
{
    public class PackingListTests
    {
        [Fact]
        public void AddItem_Throws_PackingItemAlreadyExistsException_When_There_Is_Already_Item_With_The_Same_Name()
        {
            // ARRANGE
            var packingList = GetPackingList();
            packingList.AddItem(new PackingItem("Item 1", 1));

            // ACT
            var exception = Record.Exception(() => packingList.AddItem(new PackingItem("Item 1", 1)));

            // ASSERT
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<PackingItemAlreadyExistsException>();
        }

        [Fact]
        public void AddItem_Adds_PackingItemAdded_Domain_Event_On_Success()
        {
            // ARRANGE
            var packingList = GetPackingList();

            // ACT
            var exception = Record.Exception(() => packingList.AddItem(new PackingItem("Item 1", 1)));

            // ASSERT
            exception.ShouldBeNull();
            packingList.Events.Count().ShouldBe(1);

            var @event = packingList.Events.FirstOrDefault() as PackingItemAdded;

            @event.ShouldNotBeNull();
            @event.PackingItem.Name.ShouldBe("Item 1");
        }

        #region ARRANGE

        private PackingList GetPackingList()
        {
            var packingList = _factory.Create(Guid.NewGuid(), "MyList", Localization.Create("Warsaw, Poland"));
            packingList.ClearEvents();
            return packingList;
        }

        private readonly IPackingListFactory _factory;

        public PackingListTests()
        {
            _factory = new PackingListFactory(Enumerable.Empty<IPackingItemsPolicy>());
        }

        #endregion
    }
}
