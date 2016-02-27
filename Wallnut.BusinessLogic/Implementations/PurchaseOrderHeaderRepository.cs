// -----------------------------------------------------------------------
// <copyright file="PurchaseOrderHeaderRepository.cs" company="Co">
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
    public class PurchaseOrderHeaderRepository: Repository<PurchaseOrderHeader>,IPurchaseOrderHeaderRepository
    {

        #region Member Variables
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderHeaderRepository" /> class.
        /// </summary>
        public PurchaseOrderHeaderRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        #endregion

        new public  IEnumerable<PurchaseOrderHeader>  Find(Expression<Func<PurchaseOrderHeader, bool>> predicate)
        {
            return Context.Set<PurchaseOrderHeader>().Include("Vendor")
                                                    .Include("Employee.Person")
                                                    .Include("ShipMethod").Where(predicate);
        }
    }
}
