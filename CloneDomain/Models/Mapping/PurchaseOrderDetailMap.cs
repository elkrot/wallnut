using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class PurchaseOrderDetailMap : EntityTypeConfiguration<PurchaseOrderDetail>
    {
        public PurchaseOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PurchaseOrderID, t.PurchaseOrderDetailID });

            // Properties
            this.Property(t => t.PurchaseOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PurchaseOrderDetailID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.PurchaseOrderHeader)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.PurchaseOrderID);

        }
    }
}
