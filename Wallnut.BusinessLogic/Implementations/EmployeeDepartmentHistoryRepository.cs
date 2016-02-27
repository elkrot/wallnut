// -----------------------------------------------------------------------
// <copyright file="EmployeeDepartmentHistoryRepository.cs" company="Co">
// Copyright Kolodiyazjny Sergey
// </copyright>
// -----------------------------------------------------------------------
namespace Wallnut.BusinessLogic.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
            using Wallnut.Domain.Models;
    using Wallnut.BusinessLogic.Interfaces;
    using Wallnut.Domain.Interfaces;
    using System.Data.Entity;
    using System.Linq.Expressions;
    /// <summary>
    /// Super class
    /// </summary>
    public class EmployeeDepartmentHistoryRepository: Repository<EmployeeDepartmentHistory>,IEmployeeDepartmentHistoryRepository
    {
       
        #region Member Variables
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDepartmentHistoryRepository" /> class.
        /// </summary>
 public EmployeeDepartmentHistoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }
        #endregion

        #region Properties
        #endregion

        #region Functions
 new public IEnumerable<EmployeeDepartmentHistory> Find(Expression<Func<EmployeeDepartmentHistory, bool>> predicate)
 {
     return Context.Set<EmployeeDepartmentHistory>().Include("Department").Include("Shift").Where(predicate);
 }

        #endregion

        #region Enums
        #endregion
    }
}
