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
    public partial class ExpenditureCostHistory
    {
        [NotMapped]
        public string ExpenditureName { get {return Expenditure.Name;} }

    }
}
