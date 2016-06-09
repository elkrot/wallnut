using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class SalaryPaymentOrderMap : EntityTypeConfiguration<SalaryPaymentOrder>
    {
        public SalaryPaymentOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.SalaryPaymentOrderID);

            // Properties
            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
