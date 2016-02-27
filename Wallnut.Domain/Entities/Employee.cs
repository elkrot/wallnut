// -----------------------------------------------------------------------
// <copyright file="Employee.cs" company="Co">
// Copyright Kolodiyazjny Sergey
// </copyright>
// -----------------------------------------------------------------------
namespace Wallnut.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    using Models;

    /// <summary>
    /// Содержит сведения о работнике, такие как ИНН, должность и количество 
    /// часов отпуска или отпуска по болезни. Имена работников хранятся в таблице Person
    /// </summary>
    public partial class Employee 
    {
        [NotMapped]
        public string FIO { get { return Person.LastName+" "
            + (char.ToUpper(Person.FirstName[0]).ToString()) + ". "
            + (char.ToUpper(Person.MiddleName[0]).ToString())+".";
        }
        }


        /// <summary>
        /// <see cref="NationalIDNumber"/> 
        /// ИНН
        /// </summary>
        //public int BusinessEntityID {get; set;}
       /* 
        /// <summary>
        /// ИНН
        /// </summary>
        public string NationalIDNumber { get; set; }
        /// <summary>
        /// login
        /// </summary>
        public string LoginID;
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// M = Состоит в браке S = Не состоит в браке
        /// </summary>
        public string MaritalStatus { get; set; }

        /// <summary>
        /// M = Мужской F = Женский
        /// </summary>
        public string Gender { get; set; }
       
        /// <summary>
        /// Дата принятия на работу.
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// Классификация работы.
        ///0 = Почасовая, с участием в коллективном договоре.
        ///1 = С окладом, без участия в коллективном договоре. 
        /// </summary>
        public int SalariedFlag { get; set; }

        /// <summary>
        /// 0 = Неактивно 1 = Активно
        /// </summary>
        public int CurrentFlag { get; set; }

        /// <summary>
        /// Дата и время последнего обновления строки.
        /// </summary>
        public DateTime ModifiedDate { get; set; }*/
    }
}


#region x
/*
          public int VacationHours { get; set; }
        public int SickLeaveHours { get; set; }                                                 
                                                   */
/*
 *        
 *         [Key]
 *         [StringLength(15, ErrorMessage = "Неболее 15 символов. ")]
[MaxLength(15)]
[Required]
 [NotMapped] – не отображать свойство на колонки в БД.
• [Column(“columnName”, TypeName=”typeName”] указывает колонку в БД, на которую 
 * отображается поле и его тип. Полезно когда в классе есть свойство типа byte[], 
 * хранящий, например рисунок, а в базе это отобразится на специальный тип image. 
 */
#endregion