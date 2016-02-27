using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("Person", Schema="Person")]
    public partial class Person
    {
        public Person()
        {
            this.BusinessEntityContacts = new List<BusinessEntityContact>();
            this.EmailAddresses = new List<EmailAddress>();
            this.Customers = new List<Customer>();
            this.PersonPhones = new List<PersonPhone>();
        }

 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("PersonType")] 
	        public string PersonType { get; set; }
 
        [Column("FirstName")] 
	        public string FirstName { get; set; }
 
        [Column("MiddleName")] 
	        public string MiddleName { get; set; }
 
        [Column("LastName")] 
	        public string LastName { get; set; }
 
        [Column("AdditionalContactInfo")] 
	        public string AdditionalContactInfo { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}
