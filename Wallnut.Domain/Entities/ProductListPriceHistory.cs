using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит изменения цены по прейскуранту для продукта в течение периода времени.
    /// </summary>
    public partial class ProductListPriceHistory
    {/*
        /// <summary>
        /// Идентификационный номер продукта. Внешний ключ к таблице Product.ProductID
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Дата начала действия цены по прейскуранту.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата окончания действия цены по прейскуранту
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Прейскурант цен на продукцию
        /// </summary>
        public Decimal ListPrice { get; set; }

        /// <summary>
        /// Дата и время последнего обновления строки.
        /// </summary>
        public DateTime ModifiedDate { get; set; }*/

        [NotMapped]
        public string ProductName { get {return Product.Name;} }
    }
}
