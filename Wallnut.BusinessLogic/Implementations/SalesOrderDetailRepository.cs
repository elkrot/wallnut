// -----------------------------------------------------------------------
// <copyright file="SalesOrderDetailRepository.cs" company="Co">
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
    public class SalesOrderDetailRepository : Repository<SalesOrderDetail>, ISalesOrderDetailRepository
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderDetailRepository" /> class.
        /// </summary>
        public SalesOrderDetailRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<SalesOrderDetail> Find(Expression<Func<SalesOrderDetail, bool>> predicate)
        {
            return Context.Set<SalesOrderDetail>().Include("Product").Where(predicate);//
        }


    }
}
