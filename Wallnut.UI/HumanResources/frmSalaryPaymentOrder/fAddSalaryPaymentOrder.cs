using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI.HumanResources.frmSalaryPaymentOrder
{
    public partial class fAddSalaryPaymentOrder : Wallnut.UI.Implementations.AddForm
    {
        //public List<Wallnut.Domain.Models.Location> LocationListFrom;
        public fAddSalaryPaymentOrder()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            this.tbOrderNo.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalaryPaymentOrder,
            "OrderNo",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.tbTotalSalaryPayment.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalaryPaymentOrder,
            "TotalSalaryPayment",
            false,
            DataSourceUpdateMode.OnPropertyChanged);


            if ((this.entity as Wallnut.Domain.Models.SalaryPaymentOrder).OrderDate == DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.SalaryPaymentOrder).OrderDate = DateTime.Now;
            }
            this.dtOrderDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.SalaryPaymentOrder,
            "OrderDate",
            false, DataSourceUpdateMode.OnPropertyChanged);


        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbOrderNo.Text))
            {
                e.Cancel = true; tbOrderNo.Focus(); ep.SetError(tbOrderNo, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbOrderNo, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //(this.entity as Wallnut.Domain.Models.___).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
