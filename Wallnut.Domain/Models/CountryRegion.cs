using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("CountryRegion", Schema="Person")]
    public partial class CountryRegion
    {
        public CountryRegion()
        {
            this.SalesTerritories = new List<SalesTerritory>();
            this.StateProvinces = new List<StateProvince>();
        }

 
        [Column("CountryRegionCode")] 
	        public string CountryRegionCode { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
 
        [Column("IsSysRow")] 
	        public bool IsSysRow { get; set; }
        public virtual ICollection<SalesTerritory> SalesTerritories { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
    }
}
