using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("Customer", Schema="Sales")]
    public partial class Customer
    {
        public Customer()
        {
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

 
        [Column("CustomerID")] 
	        public int CustomerID { get; set; }
 
        [Column("PersonID")] 
	        public Nullable<int> PersonID { get; set; }
 
        [Column("StoreID")] 
	        public Nullable<int> StoreID { get; set; }
 
        [Column("TerritoryID")] 
	        public Nullable<int> TerritoryID { get; set; }
 
        [Column("AccountNumber")] 
	        public string AccountNumber { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
