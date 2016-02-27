using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class SpecialOfferProductMap : EntityTypeConfiguration<SpecialOfferProduct>
    {
        public SpecialOfferProductMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SpecialOfferID, t.ProductID });

            // Properties
            this.Property(t => t.SpecialOfferID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.SpecialOfferProducts)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.SpecialOffer)
                .WithMany(t => t.SpecialOfferProducts)
                .HasForeignKey(d => d.SpecialOfferID);

        }
    }
}
