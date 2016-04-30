using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("EmployeePayHistory", Schema="HumanResources")]
    public partial class EmployeePayHistory
    {
 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("RateChangeDate")] 
	        public System.DateTime RateChangeDate { get; set; }
 
        [Column("Rate")] 
	        public decimal Rate { get; set; }
 
        [Column("PayFrequency")] 
	        public byte PayFrequency { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
