using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class SalesOrderDetailMap : EntityTypeConfiguration<SalesOrderDetail>
    {
        public SalesOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SalesOrderID, t.SalesOrderDetailID });

            // Properties
            this.Property(t => t.SalesOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SalesOrderDetailID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CarrierTrackingNumber)
                .HasMaxLength(25);


            // Relationships
            this.HasRequired(t => t.SalesOrderHeader)
                .WithMany(t => t.SalesOrderDetails)
                .HasForeignKey(d => d.SalesOrderID);
            this.HasRequired(t => t.SpecialOfferProduct)
                .WithMany(t => t.SalesOrderDetails)
                .HasForeignKey(d => new { d.SpecialOfferID, d.ProductID });

            this.HasRequired(t => t.Product)
    .WithMany(t => t.SalesOrderDetails)
    .HasForeignKey(d => d.ProductID);
        }
    }
}
