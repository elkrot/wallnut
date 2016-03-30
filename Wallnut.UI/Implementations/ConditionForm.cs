using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.UI.Interfaces;

namespace Wallnut.UI.Implementations
{
    /// <summary>
    /// Интерфейс формы изменения условия
    /// </summary>
    public  interface IConditionForm
    {
         object DataSource { get; set; }
         void BindingData();
         DialogResult ShowForm();
    }
}
