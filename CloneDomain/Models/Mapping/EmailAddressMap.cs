using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class EmailAddressMap : EntityTypeConfiguration<EmailAddress>
    {
        public EmailAddressMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.EmailAddressID });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmailAddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EmailAddress1)
                .HasMaxLength(50);


            // Relationships
            this.HasRequired(t => t.Person)
                .WithMany(t => t.EmailAddresses)
                .HasForeignKey(d => d.BusinessEntityID);

        }
    }
}
