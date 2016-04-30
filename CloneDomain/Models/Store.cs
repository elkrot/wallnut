using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("Store", Schema="Sales")]
    public partial class Store
    {
        public Store()
        {
            this.Customers = new List<Customer>();
        }

 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("SalesPersonID")] 
	        public Nullable<int> SalesPersonID { get; set; }
 
        [Column("Demographics")] 
	        public string Demographics { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
