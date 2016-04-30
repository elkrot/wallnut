using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class ExpenditureCostHistoryMap : EntityTypeConfiguration<ExpenditureCostHistory>
    {
        public ExpenditureCostHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ExpenditureID, t.StartDate });

            // Properties
            this.Property(t => t.ExpenditureID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Expenditure)
                .WithMany(t => t.ExpenditureCostHistories)
                .HasForeignKey(d => d.ExpenditureID);

        }
    }
}
