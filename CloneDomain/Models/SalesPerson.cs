using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("SalesPerson", Schema="Sales")]
    public partial class SalesPerson
    {
        public SalesPerson()
        {
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
            this.Stores = new List<Store>();
        }

 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("TerritoryID")] 
	        public Nullable<int> TerritoryID { get; set; }
 
        [Column("SalesQuota")] 
	        public Nullable<decimal> SalesQuota { get; set; }
 
        [Column("Bonus")] 
	        public decimal Bonus { get; set; }
 
        [Column("CommissionPct")] 
	        public decimal CommissionPct { get; set; }
 
        [Column("SalesYTD")] 
	        public decimal SalesYTD { get; set; }
 
        [Column("SalesLastYear")] 
	        public decimal SalesLastYear { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
