using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.UI.Implementations;
using Wallnut.Domain.Entities;

namespace Wallnut.UI.Production.ExpenditureCostHistory
{
    public partial class fExpenditureCostHistoryCondition : Form, IConditionForm
    {
        public object DataSource { get; set; }
        public fExpenditureCostHistoryCondition()
        {
            InitializeComponent();
        }

        #region BindingData
        public void BindingData()
        {
            if (this.dtFirstDate.DataBindings.Count == 0)
            {
                #region DateFirst
                this.dtFirstDate.DataBindings.Add("Value",
                (this.DataSource as ExpenditureCostHistoryCondition),
                "DateFirst",
                false,
                DataSourceUpdateMode.OnPropertyChanged);
                #endregion

                #region DateLast
                this.dtLastDate.DataBindings.Add("Value",
                 (this.DataSource as ExpenditureCostHistoryCondition),
                 "DateLast",
                 false,
                 DataSourceUpdateMode.OnPropertyChanged);
                #endregion

            }
        }

        #endregion
        public DialogResult ShowForm()
        {
            BindingData();
            return ShowDialog();
        }
    }
}
