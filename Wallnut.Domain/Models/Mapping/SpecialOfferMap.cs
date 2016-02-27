using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class SpecialOfferMap : EntityTypeConfiguration<SpecialOffer>
    {
        public SpecialOfferMap()
        {
            // Primary Key
            this.HasKey(t => t.SpecialOfferID);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Category)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
