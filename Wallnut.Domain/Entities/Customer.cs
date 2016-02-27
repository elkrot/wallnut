using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
    /// <summary> 
    /// Содержит текущие сведения о заказчике. Клиенты разбиты на категории 
    /// по типам — частный потребитель или магазин розничной торговли.
    /// </summary>
    public partial class Customer
    {
        [NotMapped]
        public string CustomerName
        {
            get
            {
                return Person!=null?(Person.LastName + " "
                    + (char.ToUpper(Person.FirstName[0]).ToString()) + ". "
                    + (char.ToUpper(Person.MiddleName[0]).ToString()) + ".")
                    : Store!=null?Store.Name:"";
                    ;
            }
        }


        [NotMapped]
        public string TerritoryName { get { return SalesTerritory!=null?SalesTerritory.Name:""; } } 

        /*
        /// <summary>
        /// Первичный ключ для строк Customer.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Foreign key to Person.BusinessEntityID.
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// Foreign key to Store.BusinessEntityID
        /// </summary>
        public int StoreID { get; set; }

        /// <summary>
        /// Идентификатор территории, на которой расположен заказчик. 
        /// Внешний ключ к таблице SalesTerritory.SalesTerritoryID.
        /// </summary>
        public int TerritoryID { get; set; }

        /// <summary>
        /// Уникальное число, идентифицирующее заказчика.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MyProperty { get; set; }*/
    }
}
