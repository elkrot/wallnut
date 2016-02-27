using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class StoreMap : EntityTypeConfiguration<Store>
    {
        public StoreMap()
        {
            // Primary Key
            this.HasKey(t => t.BusinessEntityID);

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);


            // Relationships
            this.HasRequired(t => t.BusinessEntity)
                .WithOptional(t => t.Store);
            this.HasOptional(t => t.SalesPerson)
                .WithMany(t => t.Stores)
                .HasForeignKey(d => d.SalesPersonID);

        }
    }
}
