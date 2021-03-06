using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class TransactionTypeMap : EntityTypeConfiguration<TransactionType>
    {
        public TransactionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionTypeID);

            // Properties
            this.Property(t => t.TransactionTypeID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
