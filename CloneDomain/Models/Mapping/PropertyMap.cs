using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
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

            this.Property(t => t.PropertyTitle)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
