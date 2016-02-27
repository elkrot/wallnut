using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит текущие данные и данные журнала о служащих и отделах, в которых они работают. Отдел, в котором служащий работает в настоящее время, определяется значением NULL в столбце EndDate.
    /// </summary>
    public partial class EmployeeDepartmentHistory
    {
        [NotMapped]
        public string DepartmentName { get { return Department.Name??""; } }
        [NotMapped]
        public string ShiftName { get { return Shift.Name??""; } }

        /*
        /// <summary>
        /// Идентификационный номер сотрудника. Внешний ключ к таблице Employee.BusinessEntityID.
        /// </summary>
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Отдел, в котором служащий работает или работал. Внешний ключ к таблице Department.DepartmentID.
        /// </summary>
        public int DepartmentID { get; set; }

        /// <summary>
        /// Смена, в которую работает служащий, — дневная, вечерняя или ночная. Внешний ключ к таблице Shift.ShiftID.
        /// </summary>
        public int ShiftID { get; set; }

        /// <summary>
        /// Дата начала работы служащего в отделе.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата, когда служащий ушел из отдела.NULL = Текущий отдел
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Дата и время последнего обновления строки.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        */
    }
}
