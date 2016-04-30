using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class ProductVendorMap : EntityTypeConfiguration<ProductVendor>
    {
        public ProductVendorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.BusinessEntityID });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitMeasureCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);


            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductVendors)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.UnitMeasure)
                .WithMany(t => t.ProductVendors)
                .HasForeignKey(d => d.UnitMeasureCode);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ProductVendors)
                .HasForeignKey(d => d.BusinessEntityID);

        }
    }
}
