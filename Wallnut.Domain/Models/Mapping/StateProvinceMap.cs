using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class StateProvinceMap : EntityTypeConfiguration<StateProvince>
    {
        public StateProvinceMap()
        {
            // Primary Key
            this.HasKey(t => t.StateProvinceID);

            // Properties
            this.Property(t => t.StateProvinceCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.CountryRegionCode)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);


            // Relationships
            this.HasRequired(t => t.CountryRegion)
                .WithMany(t => t.StateProvinces)
                .HasForeignKey(d => d.CountryRegionCode);
            this.HasRequired(t => t.SalesTerritory)
                .WithMany(t => t.StateProvinces)
                .HasForeignKey(d => d.TerritoryID);

        }
    }
}
