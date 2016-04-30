using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class EmployeeDepartmentHistoryMap : EntityTypeConfiguration<EmployeeDepartmentHistory>
    {
        public EmployeeDepartmentHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.DepartmentID, t.ShiftID, t.StartDate });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DepartmentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShiftID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Department)
                .WithMany(t => t.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.DepartmentID);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.BusinessEntityID);
            this.HasRequired(t => t.Shift)
                .WithMany(t => t.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.ShiftID);

        }
    }
}
