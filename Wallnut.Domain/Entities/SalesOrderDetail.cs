using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит отдельные продукты, связанные с определенным заказом на продажу. 
    /// Заказ на продажу может содержать заказы на несколько продуктов. 
    /// Общие или родительские сведения по каждому заказу на продажу хранятся в таблице 
    /// SalesOrderHeader. Каждый заказанный продукт или потомок хранится в таблице SalesOrderDetail.
    /// </summary>
    public partial class SalesOrderDetail
    {
        /*[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        /// <summary>
        /// Первичный ключ. Внешний ключ к таблице SalesOrderHeader.SalesOrderID.
        /// </summary>
        public int SalesOrderID { get; set; }

        /// <summary>
        /// Первичный ключ. Порядковый номер, используемый для обеспечения уникальности данных.
        /// </summary>
        public int SalesOrderDetailID { get; set; }

        /// <summary>
        /// Ссылочный номер, предоставляемый компанией-поставщиком для отслеживания грузов.
        /// </summary>
        public string CarrierTrackingNumber { get; set; }

        /// <summary>
        /// Заказанное количество по видам продукта.
        /// </summary>
        public int OrderQty { get; set; }

        /// <summary>
        /// Проданный заказчику продукт. Внешний ключ к таблице Product.ProductID.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Отпускная цена за единицу продукта.
        /// </summary>
        public Decimal UnitPrice { get; set; }

        /// <summary>
        /// Сумма скидки.
        /// </summary>
        public int UnitPriceDiscount { get; set; }

        /// <summary>
        /// Промежуточный итог за продукт.
        /// </summary>
        public Decimal LineTotal { get { return OrderQty * UnitPrice; }  }*/

    }
}
