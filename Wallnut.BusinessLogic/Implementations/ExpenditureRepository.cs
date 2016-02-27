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
    public class ExpenditureRepository : Repository<Expenditure>, IExpenditureRepository
    {
        public ExpenditureRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<Expenditure> Find(Expression<Func<Expenditure, bool>> predicate)
        {
            return Context.Set<Expenditure>().Where(predicate);
        }
    }
}
