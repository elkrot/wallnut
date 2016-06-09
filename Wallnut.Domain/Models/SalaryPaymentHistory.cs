using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("SalaryPaymentHistory", Schema="HumanResources")]
    public partial class SalaryPaymentHistory
    {
 
        [Column("SalaryPaymentOrderID")] 
	        public int SalaryPaymentOrderID { get; set; }
 
        [Column("EmployeeID")] 
	        public int EmployeeID { get; set; }
 
        [Column("PaymentDate")] 
	        public System.DateTime PaymentDate { get; set; }
 
        [Column("SalaryPayment")] 
	        public decimal SalaryPayment { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SalaryPaymentOrder SalaryPaymentOrder { get; set; }
    }
}
