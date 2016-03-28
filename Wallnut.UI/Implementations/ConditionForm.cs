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
    public abstract class ConditionForm:Form
    {
        public ConditionForm(IScreenConditionFields scf) {
            bs.DataSource = scf;
        }
        //public IScreenConditionFields scf;
        public BindingSource bs;
        public abstract bool SetScreenConditionFieldsValues();
    }
}
