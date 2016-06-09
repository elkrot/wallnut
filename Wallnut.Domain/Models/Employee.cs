using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("Employee", Schema="HumanResources")]
    public partial class Employee
    {
        public Employee()
        {
            this.EmployeeAttendanceHistories = new List<EmployeeAttendanceHistory>();
            this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
            this.EmployeePayHistories = new List<EmployeePayHistory>();
            this.EmployeeRoles = new List<EmployeeRole>();
            this.JobCandidates = new List<JobCandidate>();
            this.PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
            this.SalaryPaymentHistories = new List<SalaryPaymentHistory>();
            this.WorkOrderHistories = new List<WorkOrderHistory>();
        }

 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("NationalIDNumber")] 
	        public string NationalIDNumber { get; set; }
 
        [Column("LoginID")] 
	        public string LoginID { get; set; }
 
        [Column("JobTitle")] 
	        public string JobTitle { get; set; }
 
        [Column("BirthDate")] 
	        public System.DateTime BirthDate { get; set; }
 
        [Column("MaritalStatus")] 
	        public string MaritalStatus { get; set; }
 
        [Column("Gender")] 
	        public string Gender { get; set; }
 
        [Column("HireDate")] 
	        public System.DateTime HireDate { get; set; }
 
        [Column("SalariedFlag")] 
	        public bool SalariedFlag { get; set; }
 
        [Column("VacationHours")] 
	        public short VacationHours { get; set; }
 
        [Column("SickLeaveHours")] 
	        public short SickLeaveHours { get; set; }
 
        [Column("CurrentFlag")] 
	        public bool CurrentFlag { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<EmployeeAttendanceHistory> EmployeeAttendanceHistories { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }
        public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; }
        public virtual ICollection<JobCandidate> JobCandidates { get; set; }
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public virtual ICollection<SalaryPaymentHistory> SalaryPaymentHistories { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual ICollection<WorkOrderHistory> WorkOrderHistories { get; set; }
    }
}
