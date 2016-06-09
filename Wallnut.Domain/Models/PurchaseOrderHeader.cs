using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("PurchaseOrderHeader", Schema="Purchasing")]
    public partial class PurchaseOrderHeader
    {
        public PurchaseOrderHeader()
        {
            this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }

 
        [Column("PurchaseOrderID")] 
	        public int PurchaseOrderID { get; set; }
 
        [Column("RevisionNumber")] 
	        public string RevisionNumber { get; set; }
 
        [Column("Status")] 
	        public byte Status { get; set; }
 
        [Column("EmployeeID")] 
	        public int EmployeeID { get; set; }
 
        [Column("VendorID")] 
	        public int VendorID { get; set; }
 
        [Column("ShipMethodID")] 
	        public int ShipMethodID { get; set; }
 
        [Column("OrderDate")] 
	        public System.DateTime OrderDate { get; set; }
 
        [Column("ShipDate")] 
	        public Nullable<System.DateTime> ShipDate { get; set; }
 
        [Column("SubTotal")] 
	        public decimal SubTotal { get; set; }
 
        [Column("TaxAmt")] 
	        public decimal TaxAmt { get; set; }
 
        [Column("Freight")] 
	        public decimal Freight { get; set; }
 
        [Column("TotalDue")] 
	        public decimal TotalDue { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
