using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("AddressType", Schema="Person")]
    public partial class AddressType
    {
        public AddressType()
        {
            this.BusinessEntityAddresses = new List<BusinessEntityAddress>();
        }

 
        [Column("AddressTypeID")] 
	        public int AddressTypeID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
    }
}
