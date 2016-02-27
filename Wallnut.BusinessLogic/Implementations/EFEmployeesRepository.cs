// -----------------------------------------------------------------------
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

    /// <summary>
    /// Super class
    /// </summary>
    public class EFEmployeesRepository : Repository<Employee>, IEmployeeRepository
    {

        public EFEmployeesRepository(IDbContext context)
            : base(context as DbContext)
        {
        }
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

        public Password GetPasswordByLogin(string login) {
            //var p= new Password();
            var emp = EFDbContext.Employees.Include("Person").Include("Person.Password").Where(x=>x.LoginID==login).FirstOrDefault();
            var password = emp==null?null: emp.Person.Password;
            return password ;
             
        }

        public new IEnumerable<Employee> GetAll()
        {
            return EFDbContext.Employees.Include("Person").Include("Person.Password").ToList();
        }


        public IDbContext EFDbContext
        {
            get { return Context as IDbContext; }
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

        private int GetNewBusinessEntityID() {
            var be = new BusinessEntity();
            be.BusinessEntityID = 0;
            be.ModifiedDate = DateTime.Now;
            EFDbContext.BusinessEntities.Add(be);
            (EFDbContext as DbContext).SaveChanges();
            return be.BusinessEntityID;
        }

    }
}
