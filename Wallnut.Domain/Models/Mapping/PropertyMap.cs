using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class PropertyMap : EntityTypeConfiguration<Property>
    {
        public PropertyMap()
        {
            // Primary Key
            this.HasKey(t => t.PropertyCode);
            
            // Properties
            this.Property(t => t.PropertyCode)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.PropertyCode)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
