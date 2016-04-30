using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class CurrencyRateMap : EntityTypeConfiguration<CurrencyRate>
    {
        public CurrencyRateMap()
        {
            // Primary Key
            this.HasKey(t => t.CurrencyRateID);

            // Properties
            this.Property(t => t.FromCurrencyCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.ToCurrencyCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);


            // Relationships
            this.HasRequired(t => t.Currency)
                .WithMany(t => t.CurrencyRates)
                .HasForeignKey(d => d.FromCurrencyCode);
            this.HasRequired(t => t.Currency1)
                .WithMany(t => t.CurrencyRates1)
                .HasForeignKey(d => d.ToCurrencyCode);

        }
    }
}
