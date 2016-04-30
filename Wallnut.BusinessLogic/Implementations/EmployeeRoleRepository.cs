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
    public class EmployeeRoleRepository : Repository<EmployeeRole>
        , IEmployeeRoleRepository
    {
        public EmployeeRoleRepository(IDbContext context)
            : base(context as DbContext)
        {

        }
        new public IEnumerable<EmployeeRole> Find(Expression<Func<EmployeeRole, bool>> predicate)
        {
            return Context.Set<EmployeeRole>()
                .Include("Role")
                .Include("Employee")
                .Include("Employee.Person")
                .Where(predicate);
        }
    }
}
