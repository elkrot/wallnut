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

namespace Wallnut.UI.Production.ExpenditureCostHistory
{
    public partial class fAddExpenditureCostHistory : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Expenditure> ExpenditureList;
        public int ExpenditureID;
        public DateTime StartDate;
        public fAddExpenditureCostHistory()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.ExpenditureList = unitOfWork.ExpenditureRepository.GetAll().ToList<Wallnut.Domain.Models.Expenditure>();
                cbExpenditure.DataSource = ExpenditureList;
                foreach (var item in ExpenditureList)
                {
                    cbExpenditure.AutoCompleteCustomSource.Add(item.Name);
                }
            }
            cbExpenditure.ValueMember = "ExpenditureID";
            cbExpenditure.DisplayMember = "Name";
            cbExpenditure.SelectedValue = ExpenditureID;
            (this.entity as Wallnut.Domain.Models.ExpenditureCostHistory).ExpenditureID = ExpenditureID;
            cbExpenditure.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.ExpenditureCostHistory).ExpenditureID =
                    (int)cbExpenditure.SelectedValue;
            };

            if ((this.entity as Wallnut.Domain.Models.ExpenditureCostHistory).StartDate == null)
            {
                (this.entity as Wallnut.Domain.Models.ExpenditureCostHistory).StartDate = DateTime.Now;
            }
            else {
                (this.entity as Wallnut.Domain.Models.ExpenditureCostHistory).StartDate = StartDate;
            }

            this.dtStartDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.ExpenditureCostHistory,
            "StartDate",
            false, DataSourceUpdateMode.OnPropertyChanged);

            if ((this.entity as Wallnut.Domain.Models.ExpenditureCostHistory).EndDate == null)
            {
                this.dtEndDate.Checked = false;
                this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            }
            else
            {
                this.dtEndDate.Checked = true;
                this.dtEndDate.DataBindings.Add("Value",
                this.entity as Wallnut.Domain.Models.ExpenditureCostHistory,
                "EndDate",
                false,
                DataSourceUpdateMode.OnPropertyChanged);
            }

            this.tbStandardCost.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.ExpenditureCostHistory,
            "StandardCost",
            false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            if (this.AddParams != null)
            {
               ExpenditureID = (int)this.AddParams[0];
                StartDate = (DateTime)this.AddParams[1];
            }
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtStartDate.Text))
            {
                e.Cancel = true; dtStartDate.Focus(); ep.SetError(dtStartDate, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(dtStartDate, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dtEndDate.Checked)
            {
                (this.entity as Wallnut.Domain.Models.ExpenditureCostHistory).EndDate = dtEndDate.Value;
            }
            else
            {
                (this.entity as Wallnut.Domain.Models.ExpenditureCostHistory).EndDate = null;
            }
            (this.entity as Wallnut.Domain.Models.ExpenditureCostHistory).ModifiedDate = DateTime.Now;

            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
