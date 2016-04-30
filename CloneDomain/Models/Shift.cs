using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("Shift", Schema="HumanResources")]
    public partial class Shift
    {
        public Shift()
        {
            this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }

 
        [Column("ShiftID")] 
	        public int ShiftID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("StartTime")] 
	        public System.TimeSpan StartTime { get; set; }
 
        [Column("EndTime")] 
	        public System.TimeSpan EndTime { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
    }
}
