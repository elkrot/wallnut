using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("PhoneNumberType", Schema="Person")]
    public partial class PhoneNumberType
    {
        public PhoneNumberType()
        {
            this.PersonPhones = new List<PersonPhone>();
        }

 
        [Column("PhoneNumberTypeID")] 
	        public int PhoneNumberTypeID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
 
        [Column("IsSysRow")] 
	        public bool IsSysRow { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}
