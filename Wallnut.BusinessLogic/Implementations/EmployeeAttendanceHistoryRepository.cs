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
    public class EmployeeAttendanceHistoryRepository : Repository<EmployeeAttendanceHistory>
        , IEmployeeAttendanceHistoryRepository
    {
        public EmployeeAttendanceHistoryRepository(IDbContext context)
            : base(context as DbContext)
        {

        }
        new public IEnumerable<EmployeeAttendanceHistory> Find(Expression<Func<EmployeeAttendanceHistory, bool>> predicate)
        {
            return Context.Set<EmployeeAttendanceHistory>().Include("Employee").Include("Employee.Person").Where(predicate);
        }
    }
}
