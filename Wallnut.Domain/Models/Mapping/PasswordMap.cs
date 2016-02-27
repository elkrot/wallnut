using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class PasswordMap : EntityTypeConfiguration<Password>
    {
        public PasswordMap()
        {
            // Primary Key
            this.HasKey(t => t.BusinessEntityID);

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PasswordHash)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.PasswordSalt)
                .IsRequired()
                .HasMaxLength(128);


            // Relationships
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Password);

        }
    }
}
