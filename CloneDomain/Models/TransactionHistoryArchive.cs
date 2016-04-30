using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("TransactionHistoryArchive", Schema="Production")]
    public partial class TransactionHistoryArchive
    {
 
        [Column("TransactionID")] 
	        public int TransactionID { get; set; }
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("ReferenceOrderID")] 
	        public int ReferenceOrderID { get; set; }
 
        [Column("ReferenceOrderLineID")] 
	        public int ReferenceOrderLineID { get; set; }
 
        [Column("TransactionDate")] 
	        public System.DateTime TransactionDate { get; set; }
 
        [Column("TransactionType")] 
	        public string TransactionType { get; set; }
 
        [Column("Quantity")] 
	        public decimal Quantity { get; set; }
 
        [Column("ActualCost")] 
	        public decimal ActualCost { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
    }
}
