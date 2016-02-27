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
   public partial class WorkOrder
    {
       [NotMapped]
        public string ProductName { get {return Product.Name;} }
       
       /*
       /// <summary>
        /// Первичный ключ
       /// </summary>
        public int WorkOrderID { get; set; }

       /// <summary>
        /// Идентификационный номер продукта. Внешний ключ к таблице Product.ProductID.
       /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Количество производимого продукта.
        /// </summary>
        public Decimal OrderQty { get; set; }

       /// <summary>
        /// Произведенное количество для складских запасов.
       /// </summary>
        public Decimal StockedQty { get; set; }

        /// <summary>
        /// Отбракованное количество.
        /// </summary>
        public Decimal ScrappedQty { get; set; }

        /// <summary>
        /// Дата начала выполнения заказа на производство.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата окончания выполнения заказа на производство.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Срок выполнения заказа на производство.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Дата и время последнего обновления строки.
        /// </summary>
        public DateTime ModifiedDate { get; set; }*/
    }
}
