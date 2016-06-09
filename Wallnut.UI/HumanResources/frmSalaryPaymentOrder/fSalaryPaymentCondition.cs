using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.UI.Implementations;
using Wallnut.UI.Interfaces;
using Wallnut.Domain.Entities;
using Wallnut.BusinessLogic.Implementations;
using Wallnut.Domain.Models;

namespace Wallnut.UI.Sales.SalesOrderHeader
{
    public partial class fSalaryPaymentCondition : Form, IConditionForm
    {

        public fSalaryPaymentCondition()
        {
            InitializeComponent();
        }

        public object DataSource { get; set; }
        #region BindingData
           public void BindingData()
        {
            if (this.dtFrom.DataBindings.Count == 0)
            {
                #region DateFirst
                this.dtFrom.DataBindings.Add("Value",
                (this.DataSource as SalaryPaymentCondition),
                "DateFirst",
                false,
                DataSourceUpdateMode.OnPropertyChanged);
                #endregion

                #region DateLast
                this.dtTo.DataBindings.Add("Value",
                 (this.DataSource as SalaryPaymentCondition),
                 "DateLast",
                 false,
                 DataSourceUpdateMode.OnPropertyChanged);
                #endregion

                #region IsSalesOrderNumber
                this.chIsOrderNo.DataBindings.Add("Checked",
                 (this.DataSource as SalaryPaymentCondition),
                 "IsOrderNo",
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
