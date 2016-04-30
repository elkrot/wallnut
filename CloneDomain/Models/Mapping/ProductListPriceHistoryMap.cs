using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class ProductListPriceHistoryMap : EntityTypeConfiguration<ProductListPriceHistory>
    {
        public ProductListPriceHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.StartDate });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductListPriceHistories)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
