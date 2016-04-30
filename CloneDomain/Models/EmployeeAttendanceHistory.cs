using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("EmployeeAttendanceHistory", Schema="HumanResources")]
    public partial class EmployeeAttendanceHistory
    {
 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("StartDate")] 
	        public System.DateTime StartDate { get; set; }
 
        [Column("EndDate")] 
	        public Nullable<System.DateTime> EndDate { get; set; }
 
        [Column("Rate")] 
	        public decimal Rate { get; set; }
 
        [Column("WorkedOutHrs")] 
	        public int WorkedOutHrs { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
