using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.Domain.Models;
using System.Data.Entity;
using Wallnut.Domain.Interfaces;
using System.Linq.Expressions;
using Wallnut.BusinessLogic.Interfaces;

namespace Wallnut.BusinessLogic.Implementations
{
    public class SalesTerritoryRepository : Repository<SalesTerritory>, ISalesTerritoryRepository
    {
        public SalesTerritoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<SalesTerritory> Find(Expression<Func<SalesTerritory, bool>> predicate)
        {
            return Context.Set<SalesTerritory>().Where(predicate);
        }
    }
}
