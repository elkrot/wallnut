using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит стоимость продукта за период времени
    /// </summary>
    public partial class ProductCostHistory
    {
        [NotMapped]
        public string ProductName { get { return Product.Name; } }
        /*
        /// <summary>
        /// Идентификационный номер продукта. Внешний ключ к таблице Product.ProductID.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Дата начала периода, за который рассчитывается себестоимость продукта.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата окончания периода, за который рассчитывается себестоимость продукта.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Стандартная стоимость продукта
        /// </summary>
        public Decimal StandardCost { get; set; }

        /// <summary>
        /// Дата и время последнего обновления строки.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        */
    }
}
