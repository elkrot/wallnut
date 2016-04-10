using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("PurchaseOrderDetail", Schema="Purchasing")]
    public partial class PurchaseOrderDetail
    {
 
        [Column("PurchaseOrderID")] 
	        public int PurchaseOrderID { get; set; }
 
        [Column("PurchaseOrderDetailID")] 
	        public int PurchaseOrderDetailID { get; set; }
 
        [Column("DueDate")] 
	        public System.DateTime DueDate { get; set; }
 
        [Column("OrderQty")] 
	        public decimal OrderQty { get; set; }
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("UnitPrice")] 
	        public decimal UnitPrice { get; set; }
 
        [Column("LineTotal")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
	        public decimal LineTotal { get; set; }
 
        [Column("ReceivedQty")] 
	        public decimal ReceivedQty { get; set; }
 
        [Column("RejectedQty")] 
	        public decimal RejectedQty { get; set; }
 
        [Column("StockedQty")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
	        public decimal StockedQty { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }
    }
}
