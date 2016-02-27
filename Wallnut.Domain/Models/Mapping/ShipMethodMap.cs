using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class ShipMethodMap : EntityTypeConfiguration<ShipMethod>
    {
        public ShipMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.ShipMethodID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
