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
         ret_exp = PredicateBuilder.Create<SalesOrderHeader>(x => x.OrderDate >= this.DateFirst && x.OrderDate <= this.DateLast);
       if (IsCustomer) {
           Expression<Func<Wallnut.Domain.Models.SalesOrderHeader, bool>> pCustomer =
               PredicateBuilder.Create<SalesOrderHeader>(x => x.CustomerID == this.CustomerID);
           ret_exp = ret_exp.And(pCustomer);
       }
       if (IsSalesTerritory)
       {
           Expression<Func<SalesOrderHeader, bool>> pSalesTerritory = 
               PredicateBuilder.Create<SalesOrderHeader>(x => x.TerritoryID == this.SalesTerritoryID);

           ret_exp = ret_exp.And( pSalesTerritory);

         
       }

       if (!string.IsNullOrWhiteSpace(this.SalesOrderNumber))
       {
           Expression<Func<SalesOrderHeader, bool>> pSalesOrderNumber =
               PredicateBuilder.Create<SalesOrderHeader>(x => x.SalesOrderNumber == this.SalesOrderNumber);
           
           ret_exp = ret_exp.And( pSalesOrderNumber);
       }

       return ret_exp;
       }
    }
}
