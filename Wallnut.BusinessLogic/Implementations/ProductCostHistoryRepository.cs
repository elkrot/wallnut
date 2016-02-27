using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Wallnut.BusinessLogic.Implementations
{
   public class ProductCostHistoryRepository : Repository<ProductCostHistory>, IProductCostHistoryRepository
    {
               #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCostHistoryRepository" /> class.
        /// </summary>
        public ProductCostHistoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        #endregion
       new public IEnumerable<ProductCostHistory> Find(Expression<Func<ProductCostHistory, bool>> predicate)
        {
            return Context.Set<ProductCostHistory>().Include("Product").Where(predicate);
        }
    }
}
