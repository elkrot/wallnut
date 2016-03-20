using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Cross-reference table mapping customers, vendors, and employees to their addresses
    /// </summary>
    public partial class BusinessEntityAddress
    {
        public string AddressTitle { get {return Address.AddressLine1;}  }
        public string AddressTypeTitle { get { return AddressType.Name; } }
        
        /*
        /// <summary>
        /// Первичный ключ для строк Foreign key to BusinessEntity.BusinessEntityID.
        /// </summary>
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Первичный ключ для строк Foreign key to Address.AddressID.
        /// </summary>
        public int AddressID { get; set; }

        /// <summary>
        /// Первичный ключ для строк Primary key. Foreign key to AddressType.AddressTypeID
        /// </summary>
        public int AddressTypeID { get; set; }

        /// <summary>
        /// Дата и время последнего обновления строки.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
        */
    }
}
