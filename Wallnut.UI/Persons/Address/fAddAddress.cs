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
using Wallnut.UI.Persons.StateProvince;

namespace Wallnut.UI.Persons.Address
{
    public partial class fAddAddress : Wallnut.UI.Implementations.AddForm
    {
        private List<Wallnut.Domain.Models.StateProvince> stateProvince;

        public fAddAddress()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            // StateProvinceID

            this.tbAddressLine1.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Address,
            "AddressLine1",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.tbAddressLine2.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Address,
            "AddressLine2",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.tbCity.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Address,
            "City",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.tbPostalCode.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Address,
            "PostalCode",
            false,
            DataSourceUpdateMode.OnPropertyChanged);


            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.stateProvince = unitOfWork.StateProvinceRepository.GetAll().ToList<Wallnut.Domain.Models.StateProvince>();
                cbStateProvince.DataSource = stateProvince;
            }

            cbStateProvince.ValueMember = "StateProvinceID";
            cbStateProvince.DisplayMember = "Name";
            cbStateProvince.SelectedValue =
                (this.entity as Wallnut.Domain.Models.Address).StateProvinceID;
            cbStateProvince.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.Address).StateProvinceID = (int)cbStateProvince.SelectedValue;
            };
        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddressLine1.Text))
            {
                e.Cancel = true; tbAddressLine1.Focus(); ep.SetError(tbAddressLine1,
                    "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbAddressLine1, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.Address).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fStateProvince f = new fStateProvince();
            f.ShowDialog();
        }
    }
}
