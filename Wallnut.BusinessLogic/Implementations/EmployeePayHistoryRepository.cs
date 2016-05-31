// -----------------------------------------------------------------------
// <copyright file="EmployeePayHistoryRepository.cs" company="Co">
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
    public class EmployeePayHistoryRepository: Repository<EmployeePayHistory>,IEmployeePayHistoryRepository
    {



        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeePayHistoryRepository" /> class.
        /// </summary>
        public EmployeePayHistoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<EmployeePayHistory> Find(Expression<Func<EmployeePayHistory, bool>> predicate)
        {
            return Context.Set<EmployeePayHistory>().Include("Employee").Where(predicate);
        }


    }
}
