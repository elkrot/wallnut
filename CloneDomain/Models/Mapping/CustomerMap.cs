using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerID);

            // Properties
            this.Property(t => t.AccountNumber)
                .HasMaxLength(15);


            // Relationships
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.PersonID);
            this.HasOptional(t => t.SalesTerritory)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.TerritoryID);
            this.HasOptional(t => t.Store)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.StoreID);

        }
    }
}
