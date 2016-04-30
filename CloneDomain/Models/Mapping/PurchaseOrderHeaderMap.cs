using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class PurchaseOrderHeaderMap : EntityTypeConfiguration<PurchaseOrderHeader>
    {
        public PurchaseOrderHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.PurchaseOrderID);

            // Properties
            this.Property(t => t.RevisionNumber)
                .IsRequired()
                .HasMaxLength(20);


            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.EmployeeID);
            this.HasRequired(t => t.ShipMethod)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
