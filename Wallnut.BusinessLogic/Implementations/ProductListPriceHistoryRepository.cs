// -----------------------------------------------------------------------
// <copyright file="ProductListPriceHistoryRepository.cs" company="Co">
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
    public class ProductListPriceHistoryRepository: Repository<ProductListPriceHistory>,IProductListPriceHistoryRepository
    {


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListPriceHistoryRepository" /> class.
        /// </summary>
        public ProductListPriceHistoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        #endregion
       new public IEnumerable<ProductListPriceHistory> Find(Expression<Func<ProductListPriceHistory, bool>> predicate)
        {
            return Context.Set<ProductListPriceHistory>().Include("Product").Where(predicate);
        }

    }
}
