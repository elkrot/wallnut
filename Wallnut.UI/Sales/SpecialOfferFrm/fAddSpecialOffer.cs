using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI.Sales.SpecialOfferFrm
{
    public partial class fAddSpecialOffer : Wallnut.UI.Implementations.AddForm
    {
        public fAddSpecialOffer()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            /* Date fields */

            #region EndDate
            if ((this.entity as Wallnut.Domain.Models.SpecialOffer).EndDate == DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.SpecialOffer).EndDate = DateTime.Now;
            }

            this.dtEndDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.SpecialOffer,
            "EndDate",
            true,
            DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            #endregion

            #region StartDate
            if ((this.entity as Wallnut.Domain.Models.SpecialOffer).StartDate == DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.SpecialOffer).StartDate = DateTime.Now;
            }

            this.dtStartDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.SpecialOffer,
            "StartDate",
            true,
            DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            #endregion

            #region Description
            this.tbDescription.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SpecialOffer,
            "Description",
            false,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

            #region DiscountPct
            this.tbDiscountPct.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SpecialOffer,
            "DiscountPct",
            false,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion


            #region Type
            this.tbType.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SpecialOffer,
            "Type",
            false,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion


            #region Category
            this.tbCategory.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SpecialOffer,
            "Category",
            false,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

            #region MinQty
            this.tbMinQty.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SpecialOffer,
            "MinQty",
            false,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

            #region MaxQty
            this.tbMaxQty.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SpecialOffer,
            "MaxQty",
            false,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                e.Cancel = true; tbDescription.Focus(); ep.SetError(tbDescription, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbDescription, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
