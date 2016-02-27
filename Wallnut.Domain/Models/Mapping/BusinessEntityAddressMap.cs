using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class BusinessEntityAddressMap : EntityTypeConfiguration<BusinessEntityAddress>
    {
        public BusinessEntityAddressMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.AddressID, t.AddressTypeID });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Address)
                .WithMany(t => t.BusinessEntityAddresses)
                .HasForeignKey(d => d.AddressID);
            this.HasRequired(t => t.AddressType)
                .WithMany(t => t.BusinessEntityAddresses)
                .HasForeignKey(d => d.AddressTypeID);
            this.HasRequired(t => t.BusinessEntity)
                .WithMany(t => t.BusinessEntityAddresses)
                .HasForeignKey(d => d.BusinessEntityID);

        }
    }
}
