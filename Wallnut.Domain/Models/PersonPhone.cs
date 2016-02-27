using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("PersonPhone", Schema="Person")]
    public partial class PersonPhone
    {
 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("PhoneNumber")] 
	        public string PhoneNumber { get; set; }
 
        [Column("PhoneNumberTypeID")] 
	        public int PhoneNumberTypeID { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
        public virtual PhoneNumberType PhoneNumberType { get; set; }
    }
}
