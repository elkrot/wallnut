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

namespace Wallnut.UI.Admin.TransactionTypeFrm
{

    public partial class fAddTransactionType : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Location> LocationListFrom;
        public List<Wallnut.Domain.Models.Location> LocationListTo;

        public fAddTransactionType()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            #region TransactionTypeID
            this.tbTransactionTypeID.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.TransactionType,
            "TransactionTypeID",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region Name
            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.TransactionType,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region OperationSequence
            this.tbOperationSequence.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.TransactionType,
            "OperationSequence",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion


            #region Fill Lists
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {


                this.LocationListFrom = unitOfWork.LocationRepository.GetAll().ToList<Wallnut.Domain.Models.Location>();
                cbLocationIDFrom.DataSource = LocationListFrom;

                this.LocationListTo = unitOfWork.LocationRepository.GetAll().ToList<Wallnut.Domain.Models.Location>();
                cbLocationIDTo.DataSource = LocationListTo;

            }
            #endregion

            #region Binding Location To
            var locationIDTo = (this.entity as Wallnut.Domain.Models.TransactionType).LocationIDTo;
            cbLocationIDTo.ValueMember = "LocationID";
            cbLocationIDTo.DisplayMember = "Name";
            cbLocationIDTo.SelectedValue = locationIDTo;
            (this.entity as Wallnut.Domain.Models.TransactionType).LocationIDTo = locationIDTo;
            cbLocationIDTo.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.TransactionType).LocationIDTo =
                    (short)cbLocationIDTo.SelectedValue;
            };
            #endregion

            #region Binding Location From
            var locationIDFrom = (this.entity as Wallnut.Domain.Models.TransactionType).LocationIDFrom;
            cbLocationIDFrom.ValueMember = "LocationID";
            cbLocationIDFrom.DisplayMember = "Name";
            cbLocationIDFrom.SelectedValue = locationIDFrom;
            (this.entity as Wallnut.Domain.Models.TransactionType).LocationIDFrom = locationIDFrom;
            cbLocationIDFrom.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.TransactionType).LocationIDFrom =
                    (short)cbLocationIDFrom.SelectedValue;
            };
            #endregion


            #region IsSysRow
            this.chIsSysRow.DataBindings.Add("Checked",
            this.entity as Wallnut.Domain.Models.TransactionType,
            "IsSysRow",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            /*,[LocationIDFrom]
      ,[LocationIDTo]

      ,[IsSysRow]*/

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
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
