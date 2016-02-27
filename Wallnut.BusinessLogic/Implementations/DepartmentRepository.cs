using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Interfaces;
using System.Data.Entity;
using Wallnut.Domain.Interfaces;

namespace Wallnut.BusinessLogic.Implementations
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IDbContext context)
            : base(context as DbContext)
        {
        }
        public IDbContext dbContext
        {
            get { return Context as IDbContext; }
        }
        public void UpdateDepartment(Department dp)
        {

                (dbContext as DbContext).Entry(dp).State = System.Data.EntityState.Modified;
            
            
        }
    }
}
