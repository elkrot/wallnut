using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class TransactionHistoryArchiveMap : EntityTypeConfiguration<TransactionHistoryArchive>
    {
        public TransactionHistoryArchiveMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionID);

            // Properties
            this.Property(t => t.TransactionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TransactionType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

        }
    }
}
