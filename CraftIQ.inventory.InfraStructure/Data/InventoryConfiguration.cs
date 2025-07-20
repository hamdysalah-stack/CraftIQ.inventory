using CraftIQ.inventory.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CraftIQ.inventory.InfraStructure.Data.Config
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.Property(p => p.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(p => p.Location)
                   .HasMaxLength(200);

            builder.Property(p => p.Name)
                   .HasMaxLength(50);
        }
    }
}
