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
    public class ExpenditureCostHistoryRepository : Repository<ExpenditureCostHistory>, IExpenditureCostHistoryRepository
    {
        public ExpenditureCostHistoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<ExpenditureCostHistory> Find(Expression<Func<ExpenditureCostHistory, bool>> predicate)
        {
            return Context.Set<ExpenditureCostHistory>().Include("Expenditure").Where(predicate);
        }
    }
}
