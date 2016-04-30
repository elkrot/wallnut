using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CloneDomain.Models.Mapping
{
    public class ExpenditureMap : EntityTypeConfiguration<Expenditure>
    {
        public ExpenditureMap()
        {
            // Primary Key
            this.HasKey(t => t.ExpenditureID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
