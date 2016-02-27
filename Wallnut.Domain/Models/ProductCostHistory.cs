using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("ProductCostHistory", Schema="Production")]
    public partial class ProductCostHistory
    {
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("StartDate")] 
	        public System.DateTime StartDate { get; set; }
 
        [Column("EndDate")] 
	        public Nullable<System.DateTime> EndDate { get; set; }
 
        [Column("StandardCost")] 
	        public decimal StandardCost { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
    }
}
