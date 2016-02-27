using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит продукты, которые необходимо приобрести в каждом заказе на покупку. 
    /// Заказ может включать заказы на покупку нескольких продуктов. Общие или родительские 
    /// сведения для каждого заказа на покупку хранятся в таблице PurchaseOrderHeader. 
    /// Все заказываемые или дочерние продукты хранятся в таблице PurchaseOrderDetail.
    /// </summary>
    public partial class PurchaseOrderDetail
    {
        [NotMapped]
        public string ProductName { get { return Product.Name; } }
        /*
        /// <summary>
        /// Первичный ключ. Внешний ключ к таблице PurchaseOrderHeader.PurchaseOrderID.
        /// </summary>
        public int PurchaseOrderID { get; set; }

        /// <summary>
        /// Первичный ключ. Последовательно возрастающий ряд чисел, используемый для обеспечения уникальности данных.
        /// </summary>
        public int PurchaseOrderDetailID { get; set; }

        /// <summary>
        /// Ожидаемая дата получения продукта от поставщика.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Заказанное количество.
        /// </summary>
        public Decimal OrderQty { get; set; }

        /// <summary>
        /// Идентификационный номер заказанного продукта. Внешний ключ к таблице Product.ProductID.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Цена за единицу продукта.
        /// </summary>
        public Decimal UnitPrice { get; set; }

        /// <summary>
        /// Промежуточная стоимость продукта.
        /// </summary>
        public Decimal LineTotal { get {return OrderQty * UnitPrice;}  }

        /// <summary>
        /// Фактически полученное количество от поставщика.
        /// </summary>
        public Decimal ReceivedQty { get; set; }

        /// <summary>
        /// Количество товаров, отбракованное при осмотре.
        /// </summary>
        public Decimal RejectedQty { get; set; }

        /// <summary>
        /// Количество товаров, принятых на склад.
        /// </summary>
        public Decimal StockedQty { get; set; }
        */

    }
}
