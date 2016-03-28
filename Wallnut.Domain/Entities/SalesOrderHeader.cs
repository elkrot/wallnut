using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
   
    public partial class SalesOrderHeader
    {
        [NotMapped]
        public string CustomerName { get {return Customer.CustomerName;}}

        [NotMapped]
        public string TerritoryName { get {return SalesTerritory.Name;} }

        [NotMapped]
        public string BillToAddressTitle { get {return Address.FullAddress;} }

        [NotMapped]
        public string ShipToAddressTitle { get { return Address1.FullAddress; } }


        [NotMapped]
        public string ShipMethodName { get { return ShipMethod.Name; } }

        [NotMapped]
        public string CurrencyName { get { return CurrencyRate.Currency.Name; } }

        [NotMapped]
        public decimal TotalDueLoc { get {
            return SubTotal+TaxAmt+Freight;
        } }
/*
	    public int SalesOrderID { get; set; }
        public byte RevisionNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DueDate { get; set; }
	        public Nullable<System.DateTime> ShipDate { get; set; }
	        public byte Status { get; set; }

	        public string SalesOrderNumber { get; set; }
	        public string PurchaseOrderNumber { get; set; }
	        public string AccountNumber { get; set; }
	        public int CustomerID { get; set; }
	        public Nullable<int> SalesPersonID { get; set; }
	        public Nullable<int> TerritoryID { get; set; }
	        public int BillToAddressID { get; set; }
	        public int ShipToAddressID { get; set; }
	        public int ShipMethodID { get; set; }
	        public Nullable<int> CurrencyRateID { get; set; }
	        public decimal SubTotal { get; set; }
	        public decimal TaxAmt { get; set; }
	        public decimal Freight { get; set; }
	        public decimal TotalDue { get; set; }
	        public string Comment { get; set; }
	        public System.DateTime ModifiedDate { get; set; }*/

    }
}
