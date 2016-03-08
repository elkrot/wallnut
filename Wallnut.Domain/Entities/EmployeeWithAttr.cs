using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    
    public class EmployeeWithAttr
    {	        public int BusinessEntityID { get; set; }
            public string NationalIDNumber { get; set; }
            public string LoginID { get; set; }
            public string JobTitle { get; set; }
            public System.DateTime BirthDate { get; set; }
            public string MaritalStatus { get; set; }
            public string Gender { get; set; }
            public System.DateTime HireDate { get; set; }
            public bool SalariedFlag { get; set; }
            public short VacationHours { get; set; }
            public short SickLeaveHours { get; set; }
            public bool CurrentFlag { get; set; }

	        public Nullable<short> DepartmentID { get; set; }
	        public Nullable<int> ShiftID { get; set; }
	        public Nullable<System.DateTime> StartDate { get; set; }
	        public Nullable<System.DateTime> EndDate { get; set; }
	        public string ShiftName { get; set; }
	        public string DepartmentName { get; set; }
	        public string GroupName { get; set; }

            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
    }
}
