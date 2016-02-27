using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
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
