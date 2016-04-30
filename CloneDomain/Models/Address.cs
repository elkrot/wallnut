using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("Address", Schema="Person")]
    public partial class Address
    {
        public Address()
        {
            this.BusinessEntityAddresses = new List<BusinessEntityAddress>();
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
            this.SalesOrderHeaders1 = new List<SalesOrderHeader>();
        }

 
        [Column("AddressID")] 
	        public int AddressID { get; set; }
 
        [Column("AddressLine1")] 
	        public string AddressLine1 { get; set; }
 
        [Column("AddressLine2")] 
	        public string AddressLine2 { get; set; }
 
        [Column("City")] 
	        public string City { get; set; }
 
        [Column("StateProvinceID")] 
	        public int StateProvinceID { get; set; }
 
        [Column("PostalCode")] 
	        public string PostalCode { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual StateProvince StateProvince { get; set; }
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders1 { get; set; }
    }
}
