using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("ProductInventory", Schema="Production")]
    public partial class ProductInventory
    {
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("LocationID")] 
	        public short LocationID { get; set; }
 
        [Column("Shelf")] 
	        public string Shelf { get; set; }
 
        [Column("Bin")] 
	        public Nullable<byte> Bin { get; set; }
 
        [Column("Quantity")] 
	        public short Quantity { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}
