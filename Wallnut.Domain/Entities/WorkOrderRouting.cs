using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит подробности заказа на производство. Подробности заказа на производство 
    /// определяют порядок перемещения продуктов по цехам в течение производственного процесса. 
    /// Таблица WorkOrderRouting также содержит планируемые и фактические даты начала и окончания 
    /// работы в каждом цехе, используемом для создания указанного продукта.
    /// </summary>
    public partial class WorkOrderRouting
    {/*
        /// <summary>
        /// Первичный ключ. Внешний ключ к таблице WorkOrder.WorkOrderID.
        /// </summary>
        public int WorkOrderID { get; set; }

        /// <summary>
        /// Первичный ключ. Идентификационный номер продукта. Внешний ключ к таблице Product.ProductID.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Первичный ключ. Указывает последовательность производственного процесса
        /// </summary>
        public int OperationSequence { get; set; }

        /// <summary>
        /// Расположение обрабатываемой части на производственной площади. Внешний ключ к таблице Location.LocationID.
        /// </summary>
        public int LocationID { get; set; }

        /// <summary>
        /// Планируемая дата начала производства.
        /// </summary>
        public DateTime ScheduledStartDate { get; set; }

        /// <summary>
        /// Планируемая дата окончания производства.
        /// </summary>
        public DateTime ScheduledEndDate { get; set; }

        /// <summary>
        /// Фактическая дата начала производства.
        /// </summary>
        public DateTime ActualStartDate { get; set; }

        /// <summary>
        /// Фактическая дата окончания производства.
        /// </summary>
        public DateTime ActualEndDate { get; set; }

        /// <summary>
        /// Число рабочих часов, потраченных цехом на производство продукции.
        /// </summary>
        public Decimal ActualResourcesHrs { get; set; }

        /// <summary>
        /// Расчетная стоимость производства продукта по цехам.
        /// </summary>
        public Decimal PlannedCost { get; set; }

        /// <summary>
        /// Фактическая себестоимость производства продукта по цехам.
        /// </summary>
        public Decimal ActualCost { get; set; }

        /// <summary>
        /// Дата и время последнего обновления строки.
        /// </summary>
        public DateTime ModifiedDate { get; set; }*/

    }
}
