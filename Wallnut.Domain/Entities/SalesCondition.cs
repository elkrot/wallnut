using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Wallnut.Domain.Models;

namespace Wallnut.Domain.Entities
{
   public class SalesCondition
    {
        public DateTime DateFirst { get; set; }
        public DateTime DateLast { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsSalesTerritory { get; set; }
        public bool IsSalesOrderNumber { get; set; }
        public int CustomerID { get; set; }
        public int SalesTerritoryID { get; set; }
        public string SalesOrderNumber { get; set; }

        public Expression<Func<Wallnut.Domain.Models.SalesOrderHeader, bool>> GetCondition()
        {
            Expression<Func<Wallnut.Domain.Models.SalesOrderHeader, bool>> ret_exp;

         ret_exp = (x => x.OrderDate >= this.DateFirst && x.OrderDate <= this.DateLast);

       if (IsCustomer) {
           Expression<Func<Wallnut.Domain.Models.SalesOrderHeader, bool>> pCustomer = (x => x.CustomerID == this.CustomerID);
          Expression.MakeBinary(ExpressionType.And,ret_exp, pCustomer);
       }
       if (IsSalesTerritory)
       {
           Expression<Func<SalesOrderHeader, bool>> pSalesTerritory = (x => x.TerritoryID == this.SalesTerritoryID);
           Expression.MakeBinary(ExpressionType.And,ret_exp, pSalesTerritory);
       }

       if (!string.IsNullOrWhiteSpace(this.SalesOrderNumber))
       {
           Expression<Func<SalesOrderHeader, bool>> pCustomer = (x => x.SalesOrderNumber == this.SalesOrderNumber);
           Expression.MakeBinary(ExpressionType.And,ret_exp, pCustomer);
       }

           return ret_exp;
       }
    }
}
