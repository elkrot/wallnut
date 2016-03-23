using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("TransactionType", Schema="Production")]
    public partial class TransactionType
    {
        public TransactionType()
        {
            this.TransactionHistories = new List<TransactionHistory>();
        }

 
        [Column("TransactionTypeID")] 
	        public string TransactionTypeID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("OperationSequence")] 
	        public Nullable<short> OperationSequence { get; set; }
 
        [Column("LocationIDFrom")] 
	        public Nullable<short> LocationIDFrom { get; set; }
 
        [Column("LocationIDTo")] 
	        public Nullable<short> LocationIDTo { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
 
        [Column("IsSysRow")] 
	        public bool IsSysRow { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
    }
}
