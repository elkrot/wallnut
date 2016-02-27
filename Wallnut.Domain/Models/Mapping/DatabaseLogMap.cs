using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class DatabaseLogMap : EntityTypeConfiguration<DatabaseLog>
    {
        public DatabaseLogMap()
        {
            // Primary Key
            this.HasKey(t => t.DatabaseLogID);

            // Properties
            this.Property(t => t.DatabaseUser)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Event)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Schema)
                .HasMaxLength(128);

            this.Property(t => t.Object)
                .HasMaxLength(128);

            this.Property(t => t.TSQL)
                .IsRequired();

            this.Property(t => t.XmlEvent)
                .IsRequired();

        }
    }
}
