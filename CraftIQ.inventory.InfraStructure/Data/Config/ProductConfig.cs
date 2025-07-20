using CraftIQ.inventory.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CraftIQ.inventory.InfraStructure.Data.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Id from BaseEntity is the primary key
            builder.HasKey(p => p.Id);

            builder.Property(p => p.ProductId)
                .IsRequired();

            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(250)
                .IsRequired();

            // Configure decimal properties with precision and scale
            builder.Property(p => p.UnitPrice)
                .HasPrecision(18, 2);

            builder.Property(p => p.TaxCost)
                .HasPrecision(18, 2);

            builder.Property(p => p.ProfitPerUnit)
                .HasPrecision(18, 2);

            builder.Property(p => p.ProductionCost)
                .HasPrecision(18, 2);

            // Configure relationship with Category
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
