using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProductNumber)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.WeightUnitMeasureCode)
                .IsFixedLength()
                .HasMaxLength(3);


            // Relationships
            this.HasOptional(t => t.UnitMeasure)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.WeightUnitMeasureCode);

        }
    }
}
