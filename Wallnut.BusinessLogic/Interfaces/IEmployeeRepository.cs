﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Wallnut.Domain.Models;

namespace Wallnut.BusinessLogic.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        
        Employee GetEmployeeById(int id);
        Employee GetEmployeeByName(string name);
        Password GetPasswordByLogin(string login);
        IEnumerable<EmployeeWithAttr> GetEmployeeWithJobTitle
            (List<System.Data.SqlClient.SqlParameter> prms = null, string sqlWhere = "");
        IEnumerable<EmployeeBackFromProduction> GetEmployeeListBackFromProdaction
            (int departmentId, int shiftId, DateTime actualStartDate);
        //MembershipUser
        //CreateEmployee
        //ValidateEmployee
       void SaveEmployee(Employee employee);
    }
}
