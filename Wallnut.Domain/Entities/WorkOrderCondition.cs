using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Wallnut.Domain.Implementations;

namespace Wallnut.Domain.Entities
{
    public class WorkOrderCondition
    {
        public DateTime DateFirst { get; set; }
        public DateTime DateLast { get; set; }

        public Expression<Func<Wallnut.Domain.Models.WorkOrder, bool>> GetCondition()
        {
            Expression<Func<Wallnut.Domain.Models.WorkOrder, bool>> ret_exp;
            ret_exp = PredicateBuilder.Create<Wallnut.Domain.Models.WorkOrder>
                (x => x.StartDate >= this.DateFirst && x.StartDate <= this.DateLast);
            

            return ret_exp;
        }
    }
}
