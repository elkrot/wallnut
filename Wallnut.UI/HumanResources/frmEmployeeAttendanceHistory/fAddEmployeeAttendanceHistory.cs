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

namespace Wallnut.UI.HumanResources.frmEmployeeAttendanceHistory
{
    public partial class fAddEmployeeAttendanceHistory : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Employee> EmployeeList;
        public int employeeID { get; set; }
        public DateTime startDate { get; set; }
        public fAddEmployeeAttendanceHistory()
        {
            InitializeComponent();
        }

        #region BindingData
        private void BindingData()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.EmployeeList = unitOfWork.EmployeeRepository.GetAll().ToList<Wallnut.Domain.Models.Employee>();

                cbEmployeeID.DataSource = EmployeeList;

                foreach (var item in EmployeeList)
                {
                    cbEmployeeID.AutoCompleteCustomSource.Add(item.FIO);
                }
            }
            if ((this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).StartDate <= DateTime.MinValue)
            {
                startDate = DateTime.Now;
            }

            (this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).StartDate = startDate;

            this.tbWorkedOutHrs.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory,
            "WorkedOutHrs",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            cbEmployeeID.ValueMember = "BusinessEntityID";
            cbEmployeeID.DisplayMember = "FIO";
            cbEmployeeID.SelectedValue =
            (this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).BusinessEntityID;
            cbEmployeeID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).BusinessEntityID =
                (int)cbEmployeeID.SelectedValue;
            };

            this.dtStartDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory,
            "StartDate",
            false, DataSourceUpdateMode.OnPropertyChanged);

            this.dtStartTime.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory,
            "StartDate",
            false, DataSourceUpdateMode.OnPropertyChanged);


            this.tbRate.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory,
            "Rate",
            false, DataSourceUpdateMode.OnPropertyChanged);

            if ((this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).EndDate == null)
            {
                this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                this.dtEndTime.CustomFormat = " "; // use a space 
                this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            }
            else
            {
                this.dtEndDate.DataBindings.Add("Value",
                this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory,
                "EndDate",
                false,
                DataSourceUpdateMode.OnPropertyChanged);

              /* this.dtEndTime.DataBindings.Add("Value",
                this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory,
                "EndDate",
                false,
                DataSourceUpdateMode.OnPropertyChanged); */
            }



        }

        #endregion

        #region fEdit_Load
        private void fEdit_Load(object sender, EventArgs e)
        {
            if (this.AddParams != null)
            {
                employeeID = (int)this.AddParams[0];
                startDate = (DateTime)this.AddParams[1];

                dtEndTime.Value = (DateTime)(this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).EndDate;
            }
            BindingData();
        }
        #endregion

        #region tbName_Validating
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
        #endregion

        #region btnOK_Click
        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).BusinessEntityID == 0)
                (this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).BusinessEntityID = employeeID;

            //  (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).StartDate=dtStartDate.Value;
            if (dtEndDate.Checked)
            {
               DateTime dt = new DateTime(dtEndDate.Value.Year,dtEndDate.Value.Month,dtEndDate.Value.Day,
                     dtEndTime.Value.Hour,dtEndTime.Value.Minute,0);
                
                (this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).EndDate = dt;
            }
            else
            {
                (this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).EndDate = null;
            }
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
        #endregion

        #region dtEndDate_ValueChanged
        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtEndDate.Checked)
            {
                DateTime dt = new DateTime(dtEndDate.Value.Year, dtEndDate.Value.Month, dtEndDate.Value.Day,
      dtEndTime.Value.Hour, dtEndTime.Value.Minute, 0);
                (this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).EndDate = dt;
                //this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                this.dtEndTime.CustomFormat = "HH:mm";
            }
            else
            {
                (this.entity as Wallnut.Domain.Models.EmployeeAttendanceHistory).EndDate = null;

                this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                this.dtEndTime.CustomFormat = " "; // use a space 
                this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            }
        }
        #endregion

    }
}
