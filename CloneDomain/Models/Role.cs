using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("Role", Schema="Person")]
    public partial class Role
    {
        public Role()
        {
            this.EmployeeRoles = new List<EmployeeRole>();
        }

 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("RoleTitle")] 
	        public string RoleTitle { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}
