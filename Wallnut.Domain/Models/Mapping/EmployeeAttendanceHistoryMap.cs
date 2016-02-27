using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class EmployeeAttendanceHistoryMap : EntityTypeConfiguration<EmployeeAttendanceHistory>
    {
        public EmployeeAttendanceHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.StartDate });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.EmployeeAttendanceHistories)
                .HasForeignKey(d => d.BusinessEntityID);

        }
    }
}
