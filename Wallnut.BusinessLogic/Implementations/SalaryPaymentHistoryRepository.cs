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
    public class SalaryPaymentHistoryRepository : Repository<SalaryPaymentHistory>, ISalaryPaymentHistoryRepository
    {
        public SalaryPaymentHistoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

       new public IEnumerable<SalaryPaymentHistory> Find(Expression<Func<SalaryPaymentHistory, bool>> predicate)
        {
            return Context.Set<SalaryPaymentHistory>().Include("Employee.Person")
.Where(predicate);
        }
    }
}

