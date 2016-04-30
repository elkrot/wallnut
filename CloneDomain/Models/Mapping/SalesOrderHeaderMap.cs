using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class SalesOrderHeaderMap : EntityTypeConfiguration<SalesOrderHeader>
    {
        public SalesOrderHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.SalesOrderID);

            // Properties
            this.Property(t => t.SalesOrderNumber)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.PurchaseOrderNumber)
                .HasMaxLength(25);

            this.Property(t => t.AccountNumber)
                .HasMaxLength(15);

            this.Property(t => t.Comment)
                .HasMaxLength(128);


            // Relationships
            this.HasRequired(t => t.Address)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.BillToAddressID);
            this.HasRequired(t => t.Address1)
                .WithMany(t => t.SalesOrderHeaders1)
                .HasForeignKey(d => d.ShipToAddressID);
            this.HasRequired(t => t.ShipMethod)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID);
            this.HasOptional(t => t.CurrencyRate)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CurrencyRateID);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CustomerID);
            this.HasOptional(t => t.SalesPerson)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.SalesPersonID);
            this.HasOptional(t => t.SalesTerritory)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.TerritoryID);

        }
    }
}
