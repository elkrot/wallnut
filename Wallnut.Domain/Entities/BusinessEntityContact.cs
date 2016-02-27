using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wallnut.Domain.Models
{
    
    /// <summary>
    /// Cross-reference table mapping stores, vendors, and employees to people
    /// Таблица BusinessEntityContact содержится в схеме Person.
    /// </summary>
    public partial class BusinessEntityContact
    {
     /*   /// <summary>
        /// Первичный ключ .Foreign key to BusinessEntity.BusinessEntityID
        /// </summary>
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Первичный ключ .Foreign key to Person.BusinessEntityID.
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// Первичный ключ .Foreign key to ContactType.ContactTypeID
        /// </summary>
        public int ContactTypeID { get; set; }

        /// <summary>
        /// Дата и время последнего обновления строки.
        /// </summary>
        public int ModifiedDate { get; set; }
    */
    }
}
