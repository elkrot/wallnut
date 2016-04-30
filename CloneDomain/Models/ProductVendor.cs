using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("ProductVendor", Schema="Purchasing")]
    public partial class ProductVendor
    {
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("AverageLeadTime")] 
	        public int AverageLeadTime { get; set; }
 
        [Column("StandardPrice")] 
	        public decimal StandardPrice { get; set; }
 
        [Column("LastReceiptCost")] 
	        public Nullable<decimal> LastReceiptCost { get; set; }
 
        [Column("LastReceiptDate")] 
	        public Nullable<System.DateTime> LastReceiptDate { get; set; }
 
        [Column("MinOrderQty")] 
	        public int MinOrderQty { get; set; }
 
        [Column("MaxOrderQty")] 
	        public int MaxOrderQty { get; set; }
 
        [Column("UnitMeasureCode")] 
	        public string UnitMeasureCode { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
