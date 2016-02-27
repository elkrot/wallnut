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

namespace Wallnut.UI.HumanResources.EmployeeDepartmentHistory
{
    public partial class fAddEmployeeDepartmentHistory : Wallnut.UI.Implementations.AddForm
    {
        private List<Department> departmentList;
        private List<Shift> shiftList;

        public int  employeeID { get; set; }
        
        public fAddEmployeeDepartmentHistory()
        {

            InitializeComponent();
        }

        #region BindingData
        private void BindingData()
        {
            if ((this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).StartDate <= DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).StartDate = DateTime.Now;
            }


            if ((this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).EndDate == null)
            {
                this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            }
            else {
                this.dtEndDate.DataBindings.Add("Value",
                this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory,
                "EndDate",
                false,
                DataSourceUpdateMode.OnPropertyChanged);
            }


            

            this.dtStartDate.DataBindings.Add("Value",
                        this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory,
                        "StartDate",
                        false,
                        DataSourceUpdateMode.OnPropertyChanged);

            /*this.dtEndDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory,
            "EndDate",
            false,
            DataSourceUpdateMode.OnPropertyChanged);*/

            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.departmentList = unitOfWork.DepartmentRepository.GetAll().ToList<Wallnut.Domain.Models.Department>();
                cbDepartment.DataSource = departmentList;
                this.shiftList = unitOfWork.ShiftRepository.GetAll().ToList<Wallnut.Domain.Models.Shift>();
                cbShift.DataSource = shiftList;
            }

            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedValue =
                (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).DepartmentID ;
            cbDepartment.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).DepartmentID = (short)cbDepartment.SelectedValue;
            };

            cbShift.ValueMember = "ShiftID";
            cbShift.DisplayMember = "Name";
            cbShift.SelectedValue =
                (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).ShiftID;
            cbShift.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).ShiftID = (int)cbShift.SelectedValue;
            };
        }

        #endregion
        
        private void fEdit_Load(object sender, EventArgs e)
        {
            if (this.AddParams!=null)
            {
                employeeID = (int) this.AddParams[0];
            }
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (dtStartDate.Value <= DateTime.MinValue)
            {
                e.Cancel = true; dtStartDate.Focus(); ep.SetError(dtStartDate, "Поле Начальная дата не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(dtStartDate, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            
            (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).ModifiedDate = DateTime.Now;
            if ((this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).BusinessEntityID==0)
            (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).BusinessEntityID = employeeID;

          //  (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).StartDate=dtStartDate.Value;
            if (dtEndDate.Checked)
            {
                (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).EndDate = dtEndDate.Value;
            }
            else {
                (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).EndDate = null;
            }
           // 
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtEndDate.Checked)
            {
                (this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).EndDate = dtEndDate.Value;
                //this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            }
            else {
(this.entity as Wallnut.Domain.Models.EmployeeDepartmentHistory).EndDate = null;

                this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                
            }
          
        }
    }
}
