using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит заказы на производство продукции. Заказы на производство определяют количество изготавливаемых продуктов и время выполнения заказа для удовлетворения запросов на пополнение складских запасов или объема продаж.
    /// </summary>
   public partial class WorkOrderHistory
    {
     [NotMapped]
        public string ProductName { get {return "Product.Name";} }

     [NotMapped]
     public string StoreName { get { return "Employee.FIO"; } }

       [NotMapped]
       public string LocationName { get { return "Location.Name"; } } 
       
       /*
                                                                     *        
                                                                     */
    }
}
