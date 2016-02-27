using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит адреса всех заказчиков Adventure Works Cycles, поставщиков и работников. Заказчики и поставщики могут иметь несколько адресов. Например, заказчик может иметь разные адреса для выставления счетов и доставки.
    /// </summary>
    public partial class Address
    {
        [NotMapped]
        public string FullAddress { get
        {
            return string.Format("{0} {1} {2} {3} {4} {5}"
                                 , AddressLine1, AddressLine2, 
                                 PostalCode, City, PostalCode, 
                                 StateProvince.Name??"");
        } }
       /* /// <summary>
        /// Первичный ключ для строк адресов.
        /// </summary>
        public int AddressID { get; set; }

        /// <summary>
        /// Первая строка адреса улицы.
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Вторая строка адреса улицы.
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Название города.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Уникальный идентификационный номер для района или области. Внешний ключ к таблице StateProvince.StateProvinceID.
        /// </summary>
        public int StateProvinceID { get; set; }

        /// <summary>
        /// Почтовый индекс для адреса улицы.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Дата и время последнего обновления строки.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        */
    }
}
