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

namespace Wallnut.UI.Sales.SalesOrderHeader
{
    public partial class fSalesCondition : Form, IConditionForm
    {
        public fSalesCondition()
        {
            InitializeComponent();
        }
        //SalesCondition
        public object DataSource { get; set; }
        public void BindingData()
        {
            this.dtFrom.DataBindings.Add("Value",
                (this.DataSource as SalesCondition),
                "DateFirst",
                false,
                DataSourceUpdateMode.OnPropertyChanged);

            this.dtTo.DataBindings.Add("Value",
             (this.DataSource as SalesCondition),
             "DateLast",
             false,
             DataSourceUpdateMode.OnPropertyChanged);
        }
        public DialogResult ShowForm()
        { return ShowDialog(); }

    }
}
