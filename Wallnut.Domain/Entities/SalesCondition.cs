using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
