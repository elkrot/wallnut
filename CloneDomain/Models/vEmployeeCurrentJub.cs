using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("vEmployeeCurrentJub", Schema="HumanResources")]
    public partial class vEmployeeCurrentJub
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
 
        [Column("ShiftName")] 
	        public string ShiftName { get; set; }
 
        [Column("DepartmentName")] 
	        public string DepartmentName { get; set; }
 
        [Column("GroupName")] 
	        public string GroupName { get; set; }
    }
}
