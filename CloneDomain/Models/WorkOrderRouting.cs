using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("WorkOrderRouting", Schema="Production")]
    public partial class WorkOrderRouting
    {
 
        [Column("WorkOrderID")] 
	        public int WorkOrderID { get; set; }
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("OperationSequence")] 
	        public short OperationSequence { get; set; }
 
        [Column("LocationID")] 
	        public short LocationID { get; set; }
 
        [Column("ScheduledStartDate")] 
	        public System.DateTime ScheduledStartDate { get; set; }
 
        [Column("ScheduledEndDate")] 
	        public System.DateTime ScheduledEndDate { get; set; }
 
        [Column("ActualStartDate")] 
	        public Nullable<System.DateTime> ActualStartDate { get; set; }
 
        [Column("ActualEndDate")] 
	        public Nullable<System.DateTime> ActualEndDate { get; set; }
 
        [Column("ActualResourceHrs")] 
	        public Nullable<decimal> ActualResourceHrs { get; set; }
 
        [Column("PlannedCost")] 
	        public decimal PlannedCost { get; set; }
 
        [Column("ActualCost")] 
	        public Nullable<decimal> ActualCost { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Location Location { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
