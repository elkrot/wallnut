using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class SalaryPaymentHistoryMap : EntityTypeConfiguration<SalaryPaymentHistory>
    {
        public SalaryPaymentHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SalaryPaymentOrderID, t.EmployeeID });

            // Properties
            this.Property(t => t.SalaryPaymentOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.SalaryPaymentHistories)
                .HasForeignKey(d => d.EmployeeID);
            this.HasRequired(t => t.SalaryPaymentOrder)
                .WithMany(t => t.SalaryPaymentHistories)
                .HasForeignKey(d => d.SalaryPaymentOrderID);

        }
    }
}
