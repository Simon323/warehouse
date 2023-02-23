using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse.Domain.Entities;
using Warehouse.Domain.ValueObjects;

namespace Warehouse.Infrastructure.EF.Config
{
    internal sealed class WriteConfiguration : IEntityTypeConfiguration<PackingList>, IEntityTypeConfiguration<PackingItem>
    {
        public void Configure(EntityTypeBuilder<PackingList> builder)
        {
            builder.HasKey(x => x.Id);

            var localizationConverter = new ValueConverter<Localization, string>(l => l.ToString(), l => Localization.Create(l));

            var packingListNameConverter = new ValueConverter<PackingListName, string>(p => p.Value, p => new PackingListName(p));

            builder
                .Property(p => p.Id)
                .HasConversion(id => id.Value, id => new PackingListId(id));

            builder
                .Property(typeof(Localization), "_localization")
                .HasConversion(localizationConverter)
                .HasColumnName("Localization");

            builder
                .Property(typeof(PackingListName), "_name")
                .HasConversion(packingListNameConverter)
                .HasColumnName("Name");

            builder
                .HasMany(typeof(PackingItem), "_items");

            builder.ToTable("PackingLists");
        }

        public void Configure(EntityTypeBuilder<PackingItem> builder)
        {
            builder.Property<Guid>("Id");
            builder.Property(p => p.Name);
            builder.Property(p => p.Quantity);
            builder.Property(p => p.IsPacked);
            builder.ToTable("PackingItems");
        }
    }
}
