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

namespace Wallnut.UI.HumanResources.EmployeePayHistory
{
    public partial class fAddEmployeePayHistory : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Employee> EmployeeList;
        public int employeeID { get; set; }
        public DateTime RateChangeDate { get; set; }
        public fAddEmployeePayHistory()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            /*
             1 = Зарплата выплачивается ежемесячно
            2 = Зарплата выплачивается каждые две недели
             */

     
     
   #region Rate
            this.tbRate.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.EmployeePayHistory,
            "Rate",
            false,
            DataSourceUpdateMode.OnPropertyChanged);		 
	#endregion




#region BusinessEntityID
             using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.EmployeeList = unitOfWork.EmployeeRepository.GetAll().ToList<Wallnut.Domain.Models.Employee>();

                cbEmployeeID.DataSource = EmployeeList;

                foreach (var item in EmployeeList)
                {
                    cbEmployeeID.AutoCompleteCustomSource.Add(item.FIO);
                }
            }
             (this.entity as Wallnut.Domain.Models.EmployeePayHistory).BusinessEntityID = employeeID;
            cbEmployeeID.ValueMember = "BusinessEntityID";
            cbEmployeeID.DisplayMember = "FIO";
            cbEmployeeID.SelectedValue =
            (this.entity as Wallnut.Domain.Models.EmployeePayHistory).BusinessEntityID;
            cbEmployeeID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.EmployeePayHistory).BusinessEntityID =
                (int)cbEmployeeID.SelectedValue;
            };		 
	#endregion

#region RateChangeDate
 if ((this.entity as Wallnut.Domain.Models.EmployeePayHistory).RateChangeDate <= DateTime.MinValue)
            {
                RateChangeDate = DateTime.Now;
            }

            (this.entity as Wallnut.Domain.Models.EmployeePayHistory).RateChangeDate = RateChangeDate;

            this.dtRateChangeDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.EmployeePayHistory,
            "RateChangeDate",
            false, DataSourceUpdateMode.OnPropertyChanged);		 
	#endregion


   #region PayFrequency
            cbPayFrequency.DataSource = new BindingSource(
                new Dictionary<byte, string>() { { 1, "Зарплата выплачивается ежемесячно" }, { 2, "Зарплата выплачивается каждые две недели" } }, null);
            cbPayFrequency.ValueMember = "Key";
            cbPayFrequency.DisplayMember = "Value";
            cbPayFrequency.SelectedValue = (byte)(this.entity as Wallnut.Domain.Models.EmployeePayHistory).PayFrequency;
            cbPayFrequency.SelectedIndexChanged += (x, y) =>
            { (this.entity as Wallnut.Domain.Models.EmployeePayHistory).PayFrequency 
                = (byte)cbPayFrequency.SelectedValue; };            
            #endregion         

        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            if (this.AddParams != null)
            {
                employeeID = (int)this.AddParams[0];
                RateChangeDate = (DateTime)this.AddParams[1];
            }
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRate.Text))
            {
                e.Cancel = true; tbRate.Focus(); ep.SetError(tbRate, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbRate, "");
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
