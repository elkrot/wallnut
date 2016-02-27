using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class SalesPersonMap : EntityTypeConfiguration<SalesPerson>
    {
        public SalesPersonMap()
        {
            // Primary Key
            this.HasKey(t => t.BusinessEntityID);

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Employee)
                .WithOptional(t => t.SalesPerson);
            this.HasOptional(t => t.SalesTerritory)
                .WithMany(t => t.SalesPersons)
                .HasForeignKey(d => d.TerritoryID);

        }
    }
}
