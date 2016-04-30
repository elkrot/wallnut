using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("UnitMeasure", Schema="Production")]
    public partial class UnitMeasure
    {
        public UnitMeasure()
        {
            this.Products = new List<Product>();
            this.ProductVendors = new List<ProductVendor>();
        }

 
        [Column("UnitMeasureCode")] 
	        public string UnitMeasureCode { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
 
        [Column("IsSysRow")] 
	        public bool IsSysRow { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
    }
}
