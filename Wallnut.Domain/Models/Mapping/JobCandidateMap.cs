using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Wallnut.Domain.Models.Mapping
{
    public class JobCandidateMap : EntityTypeConfiguration<JobCandidate>
    {
        public JobCandidateMap()
        {
            // Primary Key
            this.HasKey(t => t.JobCandidateID);

            // Properties

            // Relationships
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.JobCandidates)
                .HasForeignKey(d => d.BusinessEntityID);

        }
    }
}
