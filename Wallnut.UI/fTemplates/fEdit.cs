using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI.fTemplates
{
    public partial class fEdit : Wallnut.UI.Implementations.AddForm
    {
        //public List<Wallnut.Domain.Models.Location> LocationListFrom;
        public fEdit()
        {
            
            InitializeComponent();
        }

        private void BindingData()
        {

            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.UnitMeasure,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            #region Fill Lists
           /* using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {


                this.LocationListFrom = unitOfWork.LocationRepository.GetAll().ToList<Wallnut.Domain.Models.Location>();
                cbLocationIDFrom.DataSource = LocationListFrom;

                this.LocationListTo = unitOfWork.LocationRepository.GetAll().ToList<Wallnut.Domain.Models.Location>();
                cbLocationIDTo.DataSource = LocationListTo;

            }*/
            #endregion

            #region Binding Combo
           /* var locationIDTo = (this.entity as Wallnut.Domain.Models.TransactionType).LocationIDTo;
            cbLocationIDTo.ValueMember = "LocationID";
            cbLocationIDTo.DisplayMember = "Name";
            cbLocationIDTo.SelectedValue = locationIDTo;
            (this.entity as Wallnut.Domain.Models.TransactionType).LocationIDTo = locationIDTo;
            cbLocationIDTo.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.TransactionType).LocationIDTo =
                    (short)cbLocationIDTo.SelectedValue;
            };*/
            #endregion


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
            //(this.entity as Wallnut.Domain.Models.___).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
