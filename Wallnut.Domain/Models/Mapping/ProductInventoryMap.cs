using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class ProductInventoryMap : EntityTypeConfiguration<ProductInventory>
    {
        public ProductInventoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.LocationID });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Shelf)
                .HasMaxLength(10);


            // Relationships
            this.HasRequired(t => t.Location)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.LocationID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
