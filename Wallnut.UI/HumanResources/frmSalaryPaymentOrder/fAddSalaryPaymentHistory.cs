using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Implementations;

namespace Wallnut.UI.HumanResources.frmSalaryPaymentOrder
{
    public partial class fAddSalaryPaymentHistory : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Employee> EmployeeList;
        public int SalaryPaymentOrderID;
        public int EmployeeID;
        public fAddSalaryPaymentHistory()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            this.tbSalaryPayment.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalaryPaymentHistory,
            "SalaryPayment",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            #region Fill Lists
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.EmployeeList = unitOfWork.EmployeeRepository.GetAll().ToList<Wallnut.Domain.Models.Employee>();
                cbEmployeeID.DataSource = EmployeeList;
            } /**/
            #endregion

            #region Binding Combo
            var locationIDTo = (this.entity as Wallnut.Domain.Models.SalaryPaymentHistory).EmployeeID;
            cbEmployeeID.ValueMember = "BusinessEntityID";
            cbEmployeeID.DisplayMember = "FIO";
            cbEmployeeID.SelectedValue = locationIDTo;
            (this.entity as Wallnut.Domain.Models.SalaryPaymentHistory).EmployeeID = locationIDTo;
            cbEmployeeID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalaryPaymentHistory).EmployeeID =
                    (int)cbEmployeeID.SelectedValue;
            };/* */
            #endregion

            if ((this.entity as Wallnut.Domain.Models.SalaryPaymentHistory).PaymentDate == DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.SalaryPaymentHistory).PaymentDate = DateTime.Now;
            }
            this.dtPaymentDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.SalaryPaymentHistory,
            "PaymentDate",
            false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            if (this.AddParams != null)
            {
                SalaryPaymentOrderID = (int)this.AddParams[0];
                (this.entity as Wallnut.Domain.Models.SalaryPaymentHistory)
                    .SalaryPaymentOrderID = SalaryPaymentOrderID;
                if (this.AddParams.Count() == 2) {
                    EmployeeID = (int)this.AddParams[1];
                    (this.entity as Wallnut.Domain.Models.SalaryPaymentHistory)
                        .EmployeeID = EmployeeID;
                }
            }
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSalaryPayment.Text))
            {
                e.Cancel = true; tbSalaryPayment.Focus(); ep.SetError(tbSalaryPayment, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbSalaryPayment, "");
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
