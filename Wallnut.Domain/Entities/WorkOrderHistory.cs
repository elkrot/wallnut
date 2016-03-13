using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
    /// <summary>
    /// Содержит заказы на производство продукции. Заказы на производство определяют количество изготавливаемых продуктов и время выполнения заказа для удовлетворения запросов на пополнение складских запасов или объема продаж.
    /// </summary>
   public partial class WorkOrderHistory
    {
     [NotMapped]
        public string ProductName { get {return Product.Name;} }

     [NotMapped]
     public string EmployeeName { get { return Employee.FIO; } }

       [NotMapped]
       public string LocationName { get { return Location.Name; } } 
       
       /*
                                                                     *        
                                                                     */
    }


   public class ListEmployeeToWork
   {
       public string Fio { get; set; }
       public decimal QtyIssued { get; set; }
       public int Id { get; set; }
       public string JobTitle { get; set; }
       public bool Selected { get; set; }
   }

   public class ListBackFromProduction
   {
       public string Fio { get; set; }
       public decimal QtyIssued { get; set; }
       public decimal QtyKernel { get; set; }
       public decimal QtyShucks { get; set; }
       public decimal QtyNuts { get; set; }
       public int Id { get; set; }
       public string JobTitle { get; set; }
       public bool Selected { get; set; }
   }


   public struct EmployeeToWorkCondition
   {
       public DateTime WorkDate { get; set; }
       public short DepartmentId { get; set; }
       public int ShiftId { get; set; }
       public int ProductId { get; set; }
   }

   public struct EmployeeToWorkResult
   {
       public DateTime WorkDate { get; set; }
       public int EmployeeId { get; set; }
       public int ProductId { get; set; }
       public decimal Qty { get; set; }
   }
}
