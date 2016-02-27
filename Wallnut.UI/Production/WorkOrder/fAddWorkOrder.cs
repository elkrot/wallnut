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

namespace Wallnut.UI.Production.WorkOrder
{
    public partial class fAddWorkOrder : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Product> ProductList;
        private int workOrderID { get; set; }

        public fAddWorkOrder()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            #region Fill ProductList
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.ProductList = unitOfWork.ProductsRepository.GetAll().ToList<Wallnut.Domain.Models.Product>();
                cbProductID.DataSource = ProductList;
                foreach (var item in ProductList)
                {
                    cbProductID.AutoCompleteCustomSource.Add(item.Name);
                }
            }            
            #endregion

            #region Binding Product
             var productID = (this.entity as Wallnut.Domain.Models.WorkOrder).ProductID;
            cbProductID.ValueMember = "ProductID";
            cbProductID.DisplayMember = "Name";
            cbProductID.SelectedValue = productID;
            (this.entity as Wallnut.Domain.Models.WorkOrder).ProductID = productID;
            cbProductID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.WorkOrder).ProductID =
                    (int)cbProductID.SelectedValue;
            };           
            #endregion

            #region StartDate
            if ((this.entity as Wallnut.Domain.Models.WorkOrder).StartDate == DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.WorkOrder).StartDate = DateTime.Now;
            }
            this.dtStartDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.WorkOrder,
            "StartDate",
            false,
            DataSourceUpdateMode.OnPropertyChanged);            
            #endregion

            #region OrderQty Количество в заказе
            this.tbOrderQty.DataBindings.Add("Text",
           this.entity as Wallnut.Domain.Models.WorkOrder,
           "OrderQty",
           false, DataSourceUpdateMode.OnPropertyChanged);            
            #endregion

            #region ScrappedQty Отбраковано
           this.tbScrappedQty.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.WorkOrder,
            "ScrappedQty",
            false, DataSourceUpdateMode.OnPropertyChanged);           
           #endregion 

            #region EndDate
           if ((this.entity as Wallnut.Domain.Models.WorkOrder).EndDate == null)
           {
               this.dtEndDate.CustomFormat = " "; // use a space 
               this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
           }
           else
           {
               this.dtEndDate.DataBindings.Add("Value",
               this.entity as Wallnut.Domain.Models.WorkOrder,
               "EndDate",
               false,
               DataSourceUpdateMode.OnPropertyChanged);
           }
           #endregion

           #region DueDate
           if ((this.entity as Wallnut.Domain.Models.WorkOrder).DueDate == DateTime.MinValue)
           {
               (this.entity as Wallnut.Domain.Models.WorkOrder).DueDate = DateTime.Now;
           }
           this.dtDueDate.DataBindings.Add("Value",
           this.entity as Wallnut.Domain.Models.WorkOrder,
           "DueDate",
           false,
           DataSourceUpdateMode.OnPropertyChanged);
           #endregion
          

        }

        #region fEdit_Load
        private void fEdit_Load(object sender, EventArgs e)
        {
            if (this.AddParams != null)
            {
                workOrderID = (int)this.AddParams[0];
                (this.entity as Wallnut.Domain.Models.WorkOrder).WorkOrderID = workOrderID;
            }
            BindingData();
        }        
        #endregion

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbOrderQty.Text))
            {
                e.Cancel = true; tbOrderQty.Focus(); ep.SetError(tbOrderQty, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbOrderQty, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.WorkOrder).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        #region dtEndDate_ValueChanged
        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtEndDate.Checked)
            {
                (this.entity as Wallnut.Domain.Models.WorkOrder).EndDate = dtEndDate.Value;
                this.dtEndDate.CustomFormat = "dd.MM.yy HH:mm"; // use a space 
                //this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            }
            else
            {
                (this.entity as Wallnut.Domain.Models.WorkOrder).EndDate = null;

                this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            }

        }        
        #endregion


    }
}
