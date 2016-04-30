using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class ContactTypeMap : EntityTypeConfiguration<ContactType>
    {
        public ContactTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactTypeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

        }
    }
}
