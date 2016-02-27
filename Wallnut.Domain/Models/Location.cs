using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("Location", Schema="Production")]
    public partial class Location
    {
        public Location()
        {
            this.ProductInventories = new List<ProductInventory>();
            this.WorkOrderHistories = new List<WorkOrderHistory>();
            this.WorkOrderRoutings = new List<WorkOrderRouting>();
        }

 
        [Column("LocationID")] 
	        public short LocationID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("CostRate")] 
	        public decimal CostRate { get; set; }
 
        [Column("Availability")] 
	        public decimal Availability { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<WorkOrderHistory> WorkOrderHistories { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}
