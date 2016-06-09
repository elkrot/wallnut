using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("SalesOrderDetail", Schema="Sales")]
    public partial class SalesOrderDetail
    {
 
        [Column("SalesOrderID")] 
	        public int SalesOrderID { get; set; }
 
        [Column("SalesOrderDetailID")] 
	        public int SalesOrderDetailID { get; set; }
 
        [Column("CarrierTrackingNumber")] 
	        public string CarrierTrackingNumber { get; set; }
 
        [Column("OrderQty")] 
	        public decimal OrderQty { get; set; }
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("SpecialOfferID")] 
	        public int SpecialOfferID { get; set; }
 
        [Column("UnitPrice")] 
	        public decimal UnitPrice { get; set; }
 
        [Column("UnitPriceDiscount")] 
	        public decimal UnitPriceDiscount { get; set; }
 
        [Column("LineTotal")] 
	        public decimal LineTotal { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }
    }
}
