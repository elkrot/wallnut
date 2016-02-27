using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("EmployeeDepartmentHistory", Schema="HumanResources")]
    public partial class EmployeeDepartmentHistory
    {
 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("DepartmentID")] 
	        public short DepartmentID { get; set; }
 
        [Column("ShiftID")] 
	        public int ShiftID { get; set; }
 
        [Column("StartDate")] 
	        public System.DateTime StartDate { get; set; }
 
        [Column("EndDate")] 
	        public Nullable<System.DateTime> EndDate { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
