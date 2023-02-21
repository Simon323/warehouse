﻿namespace Warehouse.Infrastructure.EF.Models
{
    public class PackingItemReadModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public uint Quantity { get; set; }

        public bool IsPacked { get; set; }

        public PackingListReadModel PackingList { get; set; }
    }
}