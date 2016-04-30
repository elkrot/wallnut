using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
   
    public partial class EmployeeRole
    {
 
               [NotMapped]
        public string FIO
        {
            get { return Employee.FIO; }
        }

               [NotMapped]
               public string RoleTitle
               {
                   get { return Role.RoleTitle; }
               }
    }
}
