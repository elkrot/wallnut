using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class PhoneNumberTypeMap : EntityTypeConfiguration<PhoneNumberType>
    {
        public PhoneNumberTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PhoneNumberTypeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
