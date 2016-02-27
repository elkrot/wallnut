using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Interfaces;

namespace Wallnut.BusinessLogic.Implementations
{
    public class ShiftRepository: Repository<Shift>,IShiftRepository
    {
        public ShiftRepository(IDbContext context)
            : base(context as DbContext)
        {

        }
    }
}
