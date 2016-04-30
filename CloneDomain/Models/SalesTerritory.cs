using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("SalesTerritory", Schema="Sales")]
    public partial class SalesTerritory
    {
        public SalesTerritory()
        {
            this.StateProvinces = new List<StateProvince>();
            this.Customers = new List<Customer>();
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
            this.SalesPersons = new List<SalesPerson>();
        }

 
        [Column("TerritoryID")] 
	        public int TerritoryID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("CountryRegionCode")] 
	        public string CountryRegionCode { get; set; }
 
        [Column("Group")] 
	        public string Group { get; set; }
 
        [Column("SalesYTD")] 
	        public decimal SalesYTD { get; set; }
 
        [Column("SalesLastYear")] 
	        public decimal SalesLastYear { get; set; }
 
        [Column("CostYTD")] 
	        public decimal CostYTD { get; set; }
 
        [Column("CostLastYear")] 
	        public decimal CostLastYear { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual CountryRegion CountryRegion { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<SalesPerson> SalesPersons { get; set; }
    }
}
