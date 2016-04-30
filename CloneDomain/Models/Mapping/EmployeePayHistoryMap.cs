using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class EmployeePayHistoryMap : EntityTypeConfiguration<EmployeePayHistory>
    {
        public EmployeePayHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.RateChangeDate });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.EmployeePayHistories)
                .HasForeignKey(d => d.BusinessEntityID);

        }
    }
}
