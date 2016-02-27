using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("Department", Schema="HumanResources")]
    public partial class Department
    {
        public Department()
        {
            this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }

 
        [Column("DepartmentID")] 
	        public short DepartmentID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("GroupName")] 
	        public string GroupName { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
    }
}
