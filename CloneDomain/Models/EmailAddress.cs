using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("EmailAddress", Schema="Person")]
    public partial class EmailAddress
    {
 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("EmailAddressID")] 
	        public int EmailAddressID { get; set; }
 
        [Column("EmailAddress")] 
	        public string EmailAddress1 { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
    }
}
