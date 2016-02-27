using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит общие или родительские сведения о заказе на покупку. 
    /// Конкретные продукты, связанные с заказом на покупку, хранятся в таблице PurchaseOrderDetail Table.
    /// </summary>
    public partial class PurchaseOrderHeader


    {
        

        /*
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public int PurchaseOrderID { get; set; }

        /// <summary>
        /// Порядковый номер для отслеживания изменений заказа на покупку в течение периода времени.
        /// </summary>
        public int RevisionNumber { get; set; }

        /// <summary>
        /// Текущее состояние заказа. 1 = Ожидает согласования
        /// 2 = Подтвержден
        /// 3 = Отклонен
        /// 4 = Завершен
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Служащий, создавший заказ на покупку. Внешний ключ к таблице Employee.EmployeeID.
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Поставщик, у которого размещен заказ на покупку. Внешний ключ к таблице Vendor.VendorID.
        /// </summary>
        public int VendorID { get; set; }

        /// <summary>
        /// Метод доставки. Внешний ключ к таблице ShipMethod.ShipMethodID.
        /// </summary>
        public int ShipMethodID { get; set; }

        /// <summary>
        /// Дата создания заказа на покупку.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Расчетная дата отгрузки от поставщика.
        /// </summary>
        public DateTime ShipDate { get; set; }

        /// <summary>
        /// Промежуточный итог заказа на покупку.
        /// </summary>
        public Decimal SubTotal { get; set; }

        /// <summary>
        /// Сумма налогов
        /// </summary>
        public Decimal TaxAmt { get; set; }

        /// <summary>
        /// Стоимость доставки.
        /// </summary>
        public Decimal Freight { get; set; }

*/
        [NotMapped]
        public string VendorName { get { return Vendor.Name; } }

        [NotMapped]
        public string EmployeeName { get { return Employee.FIO; } }

        [NotMapped]
        public string ShipMethodName { get { return ShipMethod.Name; } }
        /// <summary>
        /// Общая задолженность поставщику.
        /// </summary>
       /// [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
       
    }
}
