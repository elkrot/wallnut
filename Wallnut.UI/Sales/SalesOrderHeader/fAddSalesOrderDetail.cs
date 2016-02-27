using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI.Sales.SalesOrderDetail
{
    public partial class fAddSalesOrderDetail : Wallnut.UI.Implementations.AddForm
    {
        public fAddSalesOrderDetail()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            this.tbOrderQty.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.UnitMeasure,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbOrderQty.Text))
            {
                e.Cancel = true; tbOrderQty.Focus(); ep.SetError(tbOrderQty, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbOrderQty, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
