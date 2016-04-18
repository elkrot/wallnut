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
    public class WorkOrderRepository : Repository<WorkOrder>, IWorkOrderRepository
    {
        public WorkOrderRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<WorkOrder> Find(Expression<Func<WorkOrder, bool>> predicate)
        {
            return Context.Set<WorkOrder>().Include("Product").Where(predicate);
        }
    }
}
