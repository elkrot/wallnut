using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("SalaryPaymentOrder", Schema="HumanResources")]
    public partial class SalaryPaymentOrder
    {
        public SalaryPaymentOrder()
        {
            this.SalaryPaymentHistories = new List<SalaryPaymentHistory>();
        }

 
        [Column("SalaryPaymentOrderID")] 
	        public int SalaryPaymentOrderID { get; set; }
 
        [Column("OrderNo")] 
	        public string OrderNo { get; set; }
 
        [Column("OrderDate")] 
	        public System.DateTime OrderDate { get; set; }
 
        [Column("TotalSalaryPayment")] 
	        public decimal TotalSalaryPayment { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<SalaryPaymentHistory> SalaryPaymentHistories { get; set; }
    }
}
