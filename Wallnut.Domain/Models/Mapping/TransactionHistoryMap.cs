using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class TransactionHistoryMap : EntityTypeConfiguration<TransactionHistory>
    {
        public TransactionHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionID);

            // Properties
            this.Property(t => t.TransactionType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);


            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.TransactionHistories)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.TransactionType1)
                .WithMany(t => t.TransactionHistories)
                .HasForeignKey(d => d.TransactionType);

        }
    }
}
