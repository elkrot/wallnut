using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
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
