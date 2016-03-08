using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class vEmployeeCurrentJubMap : EntityTypeConfiguration<vEmployeeCurrentJub>
    {
        public vEmployeeCurrentJubMap()
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

            this.Property(t => t.ShiftName)
                .HasMaxLength(50);

            this.Property(t => t.DepartmentName)
                .HasMaxLength(50);

            this.Property(t => t.GroupName)
                .HasMaxLength(50);

        }
    }
}
