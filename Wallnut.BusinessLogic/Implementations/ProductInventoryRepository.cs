using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.Domain.Interfaces;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Models;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Wallnut.BusinessLogic.Implementations
{
    public class ProductInventoryRepository : Repository<ProductInventory>, IProductInventoryRepository
    {
        public ProductInventoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<ProductInventory> Find(Expression<Func<ProductInventory, bool>> predicate)
        {
            return Context.Set<ProductInventory>().Include("Product").Include("Location").Where(predicate);
        }
    }
}
