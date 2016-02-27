using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class SalesTerritoryMap : EntityTypeConfiguration<SalesTerritory>
    {
        public SalesTerritoryMap()
        {
            // Primary Key
            this.HasKey(t => t.TerritoryID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CountryRegionCode)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.Group)
                .IsRequired()
                .HasMaxLength(50);


            // Relationships
            this.HasRequired(t => t.CountryRegion)
                .WithMany(t => t.SalesTerritories)
                .HasForeignKey(d => d.CountryRegionCode);

        }
    }
}
