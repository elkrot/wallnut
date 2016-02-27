using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI.Persons.CountryRegion
{
    public partial class fAddCountryRegion : Wallnut.UI.Implementations.AddForm
    {
        public fAddCountryRegion()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.CountryRegion,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.tbCountryRegionCode.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.CountryRegion,
            "CountryRegionCode",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true; tbName.Focus(); ep.SetError(tbName, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbName, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.CountryRegion).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void tbCountryRegionCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCountryRegionCode.Text))
            {
                e.Cancel = true; tbCountryRegionCode.Focus();
                ep.SetError(tbCountryRegionCode, "Поле код страны не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbCountryRegionCode, "");
            }
        }
    }
}
