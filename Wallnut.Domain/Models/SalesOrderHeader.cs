using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("SalesOrderHeader", Schema="Sales")]
    public partial class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            this.SalesOrderDetails = new List<SalesOrderDetail>();
        }

 
        [Column("SalesOrderID")] 
	        public int SalesOrderID { get; set; }
 
        [Column("RevisionNumber")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
	        public byte RevisionNumber { get; set; }
 
        [Column("OrderDate")] 
	        public System.DateTime OrderDate { get; set; }
 
        [Column("DueDate")] 
	        public System.DateTime DueDate { get; set; }
 
        [Column("ShipDate")] 
	        public Nullable<System.DateTime> ShipDate { get; set; }
 
        [Column("Status")] 
	        public byte Status { get; set; }
 
        [Column("SalesOrderNumber")] 
	        public string SalesOrderNumber { get; set; }
 
        [Column("PurchaseOrderNumber")] 
	        public string PurchaseOrderNumber { get; set; }
 
        [Column("AccountNumber")] 
	        public string AccountNumber { get; set; }
 
        [Column("CustomerID")] 
	        public int CustomerID { get; set; }
 
        [Column("SalesPersonID")] 
	        public Nullable<int> SalesPersonID { get; set; }
 
        [Column("TerritoryID")] 
	        public Nullable<int> TerritoryID { get; set; }
 
        [Column("BillToAddressID")] 
	        public int BillToAddressID { get; set; }
 
        [Column("ShipToAddressID")] 
	        public int ShipToAddressID { get; set; }
 
        [Column("ShipMethodID")] 
	        public int ShipMethodID { get; set; }
 
        [Column("CurrencyRateID")] 
	        public Nullable<int> CurrencyRateID { get; set; }
 
        [Column("SubTotal")] 
	        public decimal SubTotal { get; set; }
 
        [Column("TaxAmt")] 
	        public decimal TaxAmt { get; set; }
 
        [Column("Freight")] 
	        public decimal Freight { get; set; }
 
        [Column("TotalDue")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
	        public decimal TotalDue { get; set; }
 
        [Column("Comment")] 
	        public string Comment { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Address Address { get; set; }
        public virtual Address Address1 { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        public virtual CurrencyRate CurrencyRate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
