using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("Expenditure", Schema="Production")]
    public partial class Expenditure
    {
        public Expenditure()
        {
            this.ExpenditureCostHistories = new List<ExpenditureCostHistory>();
        }

 
        [Column("ExpenditureID")] 
	        public int ExpenditureID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("CostRate")] 
	        public decimal CostRate { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<ExpenditureCostHistory> ExpenditureCostHistories { get; set; }
    }
}
