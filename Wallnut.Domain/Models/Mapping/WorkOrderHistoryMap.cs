using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class WorkOrderHistoryMap : EntityTypeConfiguration<WorkOrderHistory>
    {
        public WorkOrderHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.WorkOrderID, t.ProductID, t.BusinessEntityID, t.OperationSequence, t.ActualStartDate });

            // Properties
            this.Property(t => t.WorkOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperationSequence)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

        }
    }
}
