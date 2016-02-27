using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class WorkOrderRoutingMap : EntityTypeConfiguration<WorkOrderRouting>
    {
        public WorkOrderRoutingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.WorkOrderID, t.ProductID, t.OperationSequence });

            // Properties
            this.Property(t => t.WorkOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperationSequence)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Location)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.LocationID);
            this.HasRequired(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.WorkOrderID);

        }
    }
}
