using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("WorkOrder", Schema="Production")]
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            this.WorkOrderHistories = new List<WorkOrderHistory>();
            this.WorkOrderRoutings = new List<WorkOrderRouting>();
        }

 
        [Column("WorkOrderID")] 
	        public int WorkOrderID { get; set; }
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("OrderQty")] 
	        public int OrderQty { get; set; }
 
        [Column("StockedQty")] 
	        public int StockedQty { get; set; }
 
        [Column("ScrappedQty")] 
	        public short ScrappedQty { get; set; }
 
        [Column("StartDate")] 
	        public System.DateTime StartDate { get; set; }
 
        [Column("EndDate")] 
	        public Nullable<System.DateTime> EndDate { get; set; }
 
        [Column("DueDate")] 
	        public System.DateTime DueDate { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<WorkOrderHistory> WorkOrderHistories { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}
