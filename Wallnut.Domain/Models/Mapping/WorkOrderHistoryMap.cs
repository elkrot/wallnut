using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class WorkOrderHistoryMap : EntityTypeConfiguration<WorkOrderHistory>
    {
        public WorkOrderHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.WorkOrderID, t.WorkOrderDetailID });

            // Properties
            this.Property(t => t.WorkOrderDetailID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);



            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.WorkOrderHistories)
                .HasForeignKey(d => d.BusinessEntityID);
            this.HasRequired(t => t.Location)
                .WithMany(t => t.WorkOrderHistories)
                .HasForeignKey(d => d.LocationID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.WorkOrderHistories)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderHistories)
                .HasForeignKey(d => d.WorkOrderID);

        }
    }
}
