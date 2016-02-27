using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("StateProvince", Schema="Person")]
    public partial class StateProvince
    {
        public StateProvince()
        {
            this.Addresses = new List<Address>();
        }

 
        [Column("StateProvinceID")] 
	        public int StateProvinceID { get; set; }
 
        [Column("StateProvinceCode")] 
	        public string StateProvinceCode { get; set; }
 
        [Column("CountryRegionCode")] 
	        public string CountryRegionCode { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("TerritoryID")] 
	        public int TerritoryID { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual CountryRegion CountryRegion { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
