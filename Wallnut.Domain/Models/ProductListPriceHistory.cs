using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("ProductListPriceHistory", Schema="Production")]
    public partial class ProductListPriceHistory
    {
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("StartDate")] 
	        public System.DateTime StartDate { get; set; }
 
        [Column("EndDate")] 
	        public Nullable<System.DateTime> EndDate { get; set; }
 
        [Column("ListPrice")] 
	        public decimal ListPrice { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
    }
}
