using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
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
 
        [Column("IsSysRow")] 
	        public bool IsSysRow { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
    }
}
