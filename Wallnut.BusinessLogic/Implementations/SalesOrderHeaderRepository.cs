using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Models;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Wallnut.BusinessLogic.Implementations
{
    public class SalesOrderHeaderRepository : Repository<SalesOrderHeader>, ISalesOrderHeaderRepository
    {
        public SalesOrderHeaderRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<SalesOrderHeader> Find(Expression<Func<SalesOrderHeader, bool>> predicate)
        {
            return Context.Set<SalesOrderHeader>().Include("Customer")
                .Include("Customer.Person")
                .Include("Customer.Store")
                .Include("SalesTerritory").Where(predicate);
        }
    }
}
