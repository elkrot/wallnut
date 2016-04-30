using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("Vendor", Schema="Purchasing")]
    public partial class Vendor
    {
        public Vendor()
        {
            this.ProductVendors = new List<ProductVendor>();
            this.PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
        }

 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("AccountNumber")] 
	        public string AccountNumber { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("CreditRating")] 
	        public byte CreditRating { get; set; }
 
        [Column("PreferredVendorStatus")] 
	        public bool PreferredVendorStatus { get; set; }
 
        [Column("ActiveFlag")] 
	        public bool ActiveFlag { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
    }
}
