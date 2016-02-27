using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("ContactType", Schema="Person")]
    public partial class ContactType
    {
        public ContactType()
        {
            this.BusinessEntityContacts = new List<BusinessEntityContact>();
        }

 
        [Column("ContactTypeID")] 
	        public int ContactTypeID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
    }
}
