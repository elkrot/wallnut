using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("Product", Schema="Production")]
    public partial class Product
    {
        public Product()
        {
            this.ProductCostHistories = new List<ProductCostHistory>();
            this.ProductInventories = new List<ProductInventory>();
            this.ProductListPriceHistories = new List<ProductListPriceHistory>();
            this.ProductVendors = new List<ProductVendor>();
            this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            this.SpecialOfferProducts = new List<SpecialOfferProduct>();
            this.TransactionHistories = new List<TransactionHistory>();
            this.WorkOrders = new List<WorkOrder>();
            this.WorkOrderHistories = new List<WorkOrderHistory>();
        }

 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("ProductNumber")] 
	        public string ProductNumber { get; set; }
 
        [Column("MakeFlag")] 
	        public bool MakeFlag { get; set; }
 
        [Column("FinishedGoodsFlag")] 
	        public bool FinishedGoodsFlag { get; set; }
 
        [Column("StandardCost")] 
	        public decimal StandardCost { get; set; }
 
        [Column("ListPrice")] 
	        public decimal ListPrice { get; set; }
 
        [Column("WeightUnitMeasureCode")] 
	        public string WeightUnitMeasureCode { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
 
        [Column("IsSysRow")] 
	        public bool IsSysRow { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual ICollection<WorkOrderHistory> WorkOrderHistories { get; set; }
    }
}
