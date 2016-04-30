using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("JobCandidate", Schema="HumanResources")]
    public partial class JobCandidate
    {
 
        [Column("JobCandidateID")] 
	        public int JobCandidateID { get; set; }
 
        [Column("BusinessEntityID")] 
	        public Nullable<int> BusinessEntityID { get; set; }
 
        [Column("Resume")] 
	        public string Resume { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
