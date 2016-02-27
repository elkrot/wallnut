using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class WorkOrderMap : EntityTypeConfiguration<WorkOrder>
    {
        public WorkOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderID);

            // Properties

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
