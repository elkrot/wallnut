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

namespace Wallnut.UI.Purchasing.Vendor
{
    public partial class fAddVendor : Wallnut.UI.Implementations.AddForm
    {
        public fAddVendor()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            this.tbAccountNumber.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Vendor,
            "AccountNumber",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Vendor,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.cbCreditRating.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Vendor,
            "CreditRating",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            cbCreditRating.DataSource = new BindingSource(
    new Dictionary<byte, string>() { { 1, "Плохой" }, {2, "Хороший" } }, null);
            cbCreditRating.ValueMember = "Key";
            cbCreditRating.DisplayMember = "Value";

            cbCreditRating.SelectedValue = (this.entity as Wallnut.Domain.Models.Vendor).CreditRating;

            cbCreditRating.SelectedIndexChanged += (x, y) =>
            { (this.entity as Wallnut.Domain.Models.Vendor).CreditRating
                = (byte)cbCreditRating.SelectedValue;
            };

            this.chPreferredVendorStatus.DataBindings.Add("Checked",
            this.entity as Wallnut.Domain.Models.Vendor,
            "PreferredVendorStatus",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.chActiveFlag.DataBindings.Add("Checked",
            this.entity as Wallnut.Domain.Models.Vendor,
            "ActiveFlag",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAccountNumber.Text))
            {
                e.Cancel = true; tbAccountNumber.Focus(); ep.SetError(tbAccountNumber, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbAccountNumber, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.Vendor).ModifiedDate = DateTime.Now;
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                if ((this.entity as Wallnut.Domain.Models.Vendor).BusinessEntityID == 0)
                {
                    (this.entity as Wallnut.Domain.Models.Vendor).BusinessEntityID =
                        (unitOfWork.GetRepository<BusinessEntity>() as BusinessEntityRepository).GetNewBusinessEntityID();
                }
                }
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
