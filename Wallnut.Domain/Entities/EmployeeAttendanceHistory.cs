using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
   
    public partial class EmployeeAttendanceHistory
    {
        [NotMapped]
        public string EmployeeName { get { return Employee.FIO; }  }
    }
}
