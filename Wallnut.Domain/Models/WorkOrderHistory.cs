using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("WorkOrderHistory", Schema="Production")]
    public partial class WorkOrderHistory
    {
 
        [Column("WorkOrderID")] 
	    public int WorkOrderID { get; set; }

        [Column("WorkOrderDetailID")]
        public int WorkOrderDetailID { get; set; }

        [Column("ProductID")] 
	    public int ProductID { get; set; }
 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("OperationSequence")] 
	        public short OperationSequence { get; set; }
 
        [Column("LocationID")] 
	        public short LocationID { get; set; }
 
        [Column("ActualStartDate")] 
	        public System.DateTime ActualStartDate { get; set; }
 
        [Column("ActualEndDate")] 
	        public Nullable<System.DateTime> ActualEndDate { get; set; }
 
        [Column("Qty")] 
	        public Nullable<decimal> Qty { get; set; }
 
        [Column("ActualResourceHrs")] 
	        public decimal ActualResourceHrs { get; set; }
 
        [Column("ActualCost")] 
	        public decimal ActualCost { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
