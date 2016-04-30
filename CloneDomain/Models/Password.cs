using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("Password", Schema="Person")]
    public partial class Password
    {
 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("PasswordHash")] 
	        public string PasswordHash { get; set; }
 
        [Column("PasswordSalt")] 
	        public string PasswordSalt { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
    }
}
