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

namespace Wallnut.UI.Production.frmWorkOrderHistory
{
    public partial class fAddWorkOrderHistory : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Product> ProductList;
        public List<Wallnut.Domain.Models.Employee> EmployeeList;
        public List<Wallnut.Domain.Models.Location> LocationList;
        private int workOrderID { get; set; }
        private int productID { get; set; }
        private int businessEntityID { get; set; }
        private int locationID { get; set; }
        private DateTime actualStartDate { get; set; }
        private short operationSequence { get; set; }



        public fAddWorkOrderHistory()
        {
   
            InitializeComponent();
        }
        #region BindingData
         private void BindingData()
        {
            #region ActualResourceHrs
            this.tbxActualResourceHrs.DataBindings.Add("Text",
            this.entity as WorkOrderHistory,
            "ActualResourceHrs",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region ActualCost
            this.tbActualCost.DataBindings.Add("Text",
            this.entity as WorkOrderHistory,
            "ActualCost",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region Fill Lists
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.ProductList = unitOfWork.ProductsRepository.GetAll().ToList<Wallnut.Domain.Models.Product>();
                cbProductID.DataSource = ProductList;

                foreach (var item in ProductList)
                {
                    cbProductID.AutoCompleteCustomSource.Add(item.Name);
                }

                this.EmployeeList = unitOfWork.EmployeeRepository.GetAll().ToList<Wallnut.Domain.Models.Employee>();
                cbBusinessEntityID.DataSource = EmployeeList;

                foreach (var item in EmployeeList)
                {
                    cbBusinessEntityID.AutoCompleteCustomSource.Add(item.FIO);
                }

                this.LocationList = unitOfWork.LocationRepository.GetAll().ToList<Wallnut.Domain.Models.Location>();
                cbLocationID.DataSource = LocationList;

            }
            #endregion

            #region Binding Product
            var productID = (this.entity as Wallnut.Domain.Models.WorkOrderHistory).ProductID;
            cbProductID.ValueMember = "ProductID";
            cbProductID.DisplayMember = "Name";
            cbProductID.SelectedValue = productID;
            (this.entity as Wallnut.Domain.Models.WorkOrderHistory).ProductID = productID;
            cbProductID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.WorkOrderHistory).ProductID =
                    (int)cbProductID.SelectedValue;
            };
            #endregion

            #region Binding Employee
            var employeeID = (this.entity as Wallnut.Domain.Models.WorkOrderHistory).BusinessEntityID;
            cbBusinessEntityID.ValueMember = "BusinessEntityID";
            cbBusinessEntityID.DisplayMember = "FIO";
            cbBusinessEntityID.SelectedValue = employeeID;
            (this.entity as Wallnut.Domain.Models.WorkOrderHistory).BusinessEntityID = employeeID;
            cbBusinessEntityID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.WorkOrderHistory).BusinessEntityID =
                    (int)cbBusinessEntityID.SelectedValue;
            };
            #endregion

            #region Binding Location
            var locationID = (this.entity as Wallnut.Domain.Models.WorkOrderHistory).LocationID;
            cbLocationID.ValueMember = "LocationID";
            cbLocationID.DisplayMember = "Name";
            cbLocationID.SelectedValue = locationID;
            (this.entity as Wallnut.Domain.Models.WorkOrderHistory).LocationID = locationID;
            cbLocationID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.WorkOrderHistory).LocationID =
                    (short)cbLocationID.SelectedValue;
            };
            #endregion

            #region StartDate
            if ((this.entity as Wallnut.Domain.Models.WorkOrderHistory).ActualStartDate == DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.WorkOrderHistory).ActualStartDate = DateTime.Now;
            }
            this.dtActualStartDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.WorkOrderHistory,
            "ActualStartDate",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region EndDate
            if ((this.entity as Wallnut.Domain.Models.WorkOrderHistory).ActualEndDate == null)
            {
                this.dtActualEndDate.CustomFormat = " "; // use a space 
                this.dtActualEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            }
            else
            {
                this.dtActualEndDate.DataBindings.Add("Value",
                this.entity as Wallnut.Domain.Models.WorkOrderHistory,
                "ActualEndDate",
                false,
                DataSourceUpdateMode.OnPropertyChanged);
            }
            #endregion
        }
        #endregion
       

        private void fEdit_Load(object sender, EventArgs e)
        {
            if (this.AddParams != null)
            {
                if (this.AddParams.Count() == 2)
                {

                    (this.entity as Wallnut.Domain.Models.WorkOrderHistory).WorkOrderID = 
                        Convert.ToInt32(this.AddParams[0]);
                    (this.entity as Wallnut.Domain.Models.WorkOrderHistory).OperationSequence =
                        Convert.ToInt16(this.AddParams[1]);
                }
                
            }
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxActualResourceHrs.Text))
            {
                e.Cancel = true; tbxActualResourceHrs.Focus(); ep.SetError(tbxActualResourceHrs, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbxActualResourceHrs, "");
            }/**/
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void dtActualEndDate_ValueChanged(object sender, EventArgs e)
        {

            if (dtActualEndDate.Checked)
            {
                (this.entity as Wallnut.Domain.Models.WorkOrderHistory).ActualEndDate = dtActualEndDate.Value;
                //this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtActualEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            }
            else
            {
                (this.entity as Wallnut.Domain.Models.WorkOrderHistory).ActualEndDate = null;

                this.dtActualEndDate.CustomFormat = " "; // use a space 
                this.dtActualEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            }
        }
    }
}
