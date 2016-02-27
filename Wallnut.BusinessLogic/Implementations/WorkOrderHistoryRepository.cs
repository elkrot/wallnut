using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Models;
using System.Linq.Expressions;

namespace Wallnut.BusinessLogic.Implementations
{
    public class WorkOrderHistoryRepository : Repository<WorkOrderHistory>, IWorkOrderHistoryRepository
    {
       public WorkOrderHistoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

     new public IEnumerable<WorkOrderHistory> Find(Expression<Func<WorkOrderHistory, bool>> predicate)
       {
           return Context.Set<WorkOrderHistory>()
               .Include("Product")
               .Include("Employee.Person")
               .Include("Location").Where(predicate);
               
       }/*  */
    }
}
