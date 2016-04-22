using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class PropertyToEntityMap : EntityTypeConfiguration<PropertyToEntity>
    {
        public PropertyToEntityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PropertyCode, t.BusinesEntityID });

            // Properties
            this.Property(t => t.PropertyCode)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.BusinesEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PropertyValue)
                .IsRequired()
                .HasMaxLength(255);


            // Relationships
            this.HasRequired(t => t.BusinessEntity)
                .WithMany(t => t.ProprertyToEntities)
                .HasForeignKey(d => d.BusinesEntityID);
            this.HasRequired(t => t.Property)
                .WithMany(t => t.PropertyToEntities)
                .HasForeignKey(d => d.PropertyCode);

        }
    }
}
