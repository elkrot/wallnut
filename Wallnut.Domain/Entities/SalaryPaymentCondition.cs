using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Wallnut.Domain.Models;
using System.Data.Entity;
using Wallnut.Domain.Implementations;
namespace Wallnut.Domain.Entities
{
    public class SalaryPaymentCondition
    {
        public DateTime DateFirst { get; set; }
        public DateTime DateLast { get; set; }
        public bool IsOrderNo { get; set; }
        public string OrderNo { get; set; }

        public Expression<Func<Wallnut.Domain.Models.SalaryPaymentOrder, bool>> GetCondition()
        {
            Expression<Func<Wallnut.Domain.Models.SalaryPaymentOrder, bool>> ret_exp;
            ret_exp = PredicateBuilder.Create<SalaryPaymentOrder>(x => x.OrderDate >= this.DateFirst && x.OrderDate <= this.DateLast);
       if (IsOrderNo) {
           Expression<Func<Wallnut.Domain.Models.SalaryPaymentOrder, bool>> pOrderNo =
               PredicateBuilder.Create<SalaryPaymentOrder>(x => x.OrderNo == this.OrderNo);
           ret_exp = ret_exp.And(pOrderNo);
       }
      
       return ret_exp;
       }
    }
}
