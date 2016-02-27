// -----------------------------------------------------------------------
// <copyright file="PurchaseOrderDetailRepository.cs" company="Co">
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
    public class PurchaseOrderDetailRepository: Repository<PurchaseOrderDetail>,IPurchaseOrderDetailRepository
    {



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderDetailRepository" /> class.
        /// </summary>
        public PurchaseOrderDetailRepository(IDbContext context)
            : base(context as DbContext)
        {
        }

        #endregion

       new public IEnumerable<PurchaseOrderDetail> Find(Expression<Func<PurchaseOrderDetail, bool>> predicate)
        {
            return Context.Set<PurchaseOrderDetail>().Include("Product").Where(predicate);
        }
    }
}
