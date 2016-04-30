using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class EmployeeRoleMap : EntityTypeConfiguration<EmployeeRole>
    {
        public EmployeeRoleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeID, t.RoleID });

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.EmployeeRoles)
                .HasForeignKey(d => d.EmployeeID);
            this.HasRequired(t => t.Role)
                .WithMany(t => t.EmployeeRoles)
                .HasForeignKey(d => d.RoleID);

        }
    }
}
