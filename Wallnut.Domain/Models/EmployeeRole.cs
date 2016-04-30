using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("EmployeeRoles", Schema="Person")]
    public partial class EmployeeRole
    {
 
        [Column("EmployeeID")] 
	        public int EmployeeID { get; set; }
 
        [Column("RoleID")] 
	        public int RoleID { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
