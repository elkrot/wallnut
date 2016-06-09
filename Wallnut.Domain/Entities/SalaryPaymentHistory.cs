// -----------------------------------------------------------------------
// <copyright file="ExpenditureCostHistory.cs" company="Co">
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

    /// <summary>
    /// Super class
    /// </summary>
    public partial class SalaryPaymentHistory
    {
        [NotMapped]
        public string FIO { get {return Employee.FIO;} }

    }
}
