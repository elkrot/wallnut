using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            // Primary Key
            this.HasKey(t => t.DepartmentID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GroupName)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
