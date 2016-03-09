using System;
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
            (Dictionary<string, System.Data.SqlClient.SqlParameter> prms = null, string sqlWhere = "");
        //MembershipUser
        //CreateEmployee
        //ValidateEmployee
       void SaveEmployee(Employee employee);
    }
}
