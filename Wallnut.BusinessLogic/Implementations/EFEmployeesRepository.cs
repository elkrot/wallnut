﻿// -----------------------------------------------------------------------
// <copyright file="EFEmployeesRepository.cs" company="Co">
// Copyright Kolodiyazjny Sergey
// </copyright>
// -----------------------------------------------------------------------
namespace Wallnut.BusinessLogic.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wallnut.Domain.Interfaces;
    using Wallnut.BusinessLogic.Interfaces;
    using Wallnut.Domain.Models;
    using Wallnut.Domain;
    using System.Data.Entity;
    using System.Data;

    /// <summary>
    /// Super class
    /// </summary>
    public class EFEmployeesRepository : Repository<Employee>, IEmployeeRepository
    {

        public EFEmployeesRepository(IDbContext context)
            : base(context as DbContext)
        {
        }

        #region EFDbContext
        public IDbContext EFDbContext
        {
            get { return Context as IDbContext; }
        }        
        #endregion

        #region NoUse
         public IEnumerable<Employee> GetTopSellingCources(int count)
        {
            return EFDbContext.Employees.OrderByDescending(c => c.LoginID).Take(count).ToList();
        }

        public IEnumerable<Employee> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return EFDbContext.Employees
            .OrderBy(c => c.LoginID)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToList();

            //.Include(c=>c.)
        }

        public IEnumerable<Employee> GetEmployee()
        {
            return EFDbContext.Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return EFDbContext.Employees.Where(x => x.BusinessEntityID == id).FirstOrDefault();
        }

        public Employee GetEmployeeByName(string name)
        {
            return new Employee();
        }
        #endregion

        #region GetPasswordByLogin
        public Password GetPasswordByLogin(string login) {
            //var p= new Password();
            var emp = EFDbContext.Employees.Include("Person").Include("Person.Password").Where(x=>x.LoginID==login).FirstOrDefault();
            var password = emp==null?null: emp.Person.Password;
            return password ;
             
        }        
        #endregion

        #region GetAll
       public new IEnumerable<Employee> GetAll()
        {
            return EFDbContext.Employees.Include("Person").Include("Person.Password")
                    . ToList();
        }        
        #endregion






       #region SaveEmployee
        public void SaveEmployee(Employee employee)
        {
            if (employee.BusinessEntityID == 0)
            {
                    employee.Person.BusinessEntityID = GetNewBusinessEntityID();
                    employee.BusinessEntityID = employee.Person.BusinessEntityID;
                EFDbContext.Employees.Add(employee);
            }
            else
            {
                (EFDbContext as DbContext).Entry(employee).State = System.Data.EntityState.Modified;
            }
         // (EFDbContext as DbContext).SaveChanges();
        }
       #endregion

        #region GetEmployeeWithJobTitle
        /// <summary>
        /// Данные для вида отображения Работников
        /// </summary>
        /// <param name="prms">Параметры запроса</param>
        /// <param name="sqlWhere">Условие запроса</param>
        /// <returns></returns>
        public IEnumerable<EmployeeWithAttr> GetEmployeeWithJobTitle
            (List<System.Data.SqlClient.SqlParameter> prms=null, string sqlWhere="")
        {
            IEnumerable<EmployeeWithAttr> employees;
            var stssql = @"select e.BusinessEntityID,e.NationalIDNumber,e.LoginID,e.JobTitle
,e.BirthDate,e.MaritalStatus,e.Gender,e.HireDate,e.SalariedFlag
,e.VacationHours,e.SickLeaveHours,e.CurrentFlag,e.ModifiedDate
,v.DepartmentID,v.ShiftID,v.StartDate,v.EndDate,v.ShiftName,v.DepartmentName
,v.GroupName,p.FirstName,p.MiddleName,p.LastName  from HumanResources.Employee e
 left join HumanResources.vEmployeeCurrentJub v on v.BusinessEntityID = e.BusinessEntityID
 left join Person.Person p on p.BusinessEntityID
=e.BusinessEntityID where 1=1  ";
            if (prms != null)
            {
                employees = (EFDbContext as DbContext).Database.SqlQuery<EmployeeWithAttr>
                   (stssql + sqlWhere, prms.ToArray());
            }
            else
            {
                employees = (EFDbContext as DbContext).Database.SqlQuery<EmployeeWithAttr>
    (stssql + sqlWhere);
            }

            return employees.ToList();
        }      
  
        #endregion



        #region GetEmployeeListBackFromProdaction
        /// <summary>
        /// Данные для вида отображения Работников на приемке ореха, ядра, скорлупы
        /// </summary>
        /// <param name="departmentId">Подразделение</param>
        /// <param name="shiftId">Смена</param>
        /// <param name="actualStartDate">Начальная дата</param>
        /// <returns></returns>
        public IEnumerable<EmployeeBackFromProduction> GetEmployeeListBackFromProdaction
            (int departmentId, int shiftId, DateTime actualStartDate)
        {
List<System.Data.SqlClient.SqlParameter> prms = new List<System.Data.SqlClient.SqlParameter>();
var DepartmentId = new System.Data.SqlClient.SqlParameter("@DepartmentID", SqlDbType.Int);
DepartmentId.Value = departmentId;

var ShiftId = new System.Data.SqlClient.SqlParameter("@ShiftID", SqlDbType.Int);
ShiftId.Value = shiftId;

var ActualStartDate = new System.Data.SqlClient.SqlParameter("@ActualStartDate", SqlDbType.DateTime2);
ActualStartDate.Value = actualStartDate;
prms.Add(DepartmentId);
prms.Add(ShiftId);
prms.Add(ActualStartDate);
IEnumerable<EmployeeBackFromProduction> employees;
var stssql = @"SELECT w.BusinessEntityID,sum(w.Qty) Qty,e.JobTitle,p.LastName+' '+p.FirstName+' '+p.MiddleName Fio
FROM Production.WorkOrderHistory w left join HumanResources.Employee e on e.BusinessEntityID=w.BusinessEntityID
left join HumanResources.vEmployeeCurrentJub v on v.BusinessEntityID = e.BusinessEntityID
left join Person.Person p on p.BusinessEntityID=e.BusinessEntityID
where 1=1 and e.CurrentFlag=1 and e.SalariedFlag=1 and OperationSequence=2 and 
cast(ActualStartDate as date)=cast(@ActualStartDate as date) and v.DepartmentID=@DepartmentID and v.ShiftID=@ShiftID
group by w.BusinessEntityID,e.JobTitle,e.SalariedFlag,e.CurrentFlag,v.DepartmentID,v.ShiftID
,v.ShiftName,v.DepartmentName,v.GroupName,p.FirstName,p.MiddleName,p.LastName  ";

employees = (EFDbContext as DbContext).Database.SqlQuery<EmployeeBackFromProduction>
                   (stssql , prms.ToArray());
           

            return employees.ToList();
        }

        #endregion




        #region GetNewBusinessEntityID
        private int GetNewBusinessEntityID() {
            var be = new BusinessEntity();
            be.BusinessEntityID = 0;
            be.ModifiedDate = DateTime.Now;
            EFDbContext.BusinessEntities.Add(be);
            (EFDbContext as DbContext).SaveChanges();
            return be.BusinessEntityID;
        }        
        #endregion


    }
}
