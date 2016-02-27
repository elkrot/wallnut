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

namespace Wallnut.UI.Production.ProductCostHistory
{
    public partial class fAddProductCostHistory : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Product> ProductList;
        private int productID { get; set; }
        private DateTime StartDate { get; set; }
        public fAddProductCostHistory()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.ProductList = unitOfWork.ProductsRepository.GetAll().ToList<Wallnut.Domain.Models.Product>();
                cbProduct.DataSource = ProductList;
                foreach (var item in ProductList)
                {
                    cbProduct.AutoCompleteCustomSource.Add(item.Name);
                }
            }
            cbProduct.ValueMember = "ProductID";
            cbProduct.DisplayMember = "Name";
            cbProduct.SelectedValue = productID;
            (this.entity as Wallnut.Domain.Models.ProductCostHistory).ProductID = productID;   
            cbProduct.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.ProductCostHistory).ProductID = 
                    (int)cbProduct.SelectedValue;
            };

(this.entity as Wallnut.Domain.Models.ProductCostHistory).StartDate = StartDate; 
            this.dtStartDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.ProductCostHistory,
            "StartDate",
            false, DataSourceUpdateMode.OnPropertyChanged);
            
            if ((this.entity as Wallnut.Domain.Models.ProductCostHistory).EndDate == null)
            {
                this.dtEndDate.Checked = false;
                this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            }
            else
            {
                this.dtEndDate.Checked = true;
                this.dtEndDate.DataBindings.Add("Value",
                this.entity as Wallnut.Domain.Models.ProductCostHistory,
                "EndDate",
                false,
                DataSourceUpdateMode.OnPropertyChanged);
            }
            
            this.tbListPrice.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.ProductCostHistory,
            "StandardCost",
            false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            if (this.AddParams != null)
            {
                productID = (int)this.AddParams[0];
                StartDate = (DateTime)this.AddParams[1];
            }
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbListPrice.Text))
            {
                e.Cancel = true; tbListPrice.Focus(); ep.SetError(tbListPrice, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbListPrice, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.ProductCostHistory).ModifiedDate = DateTime.Now;
            if (dtEndDate.Checked)
            {
                (this.entity as Wallnut.Domain.Models.ProductCostHistory).EndDate = dtEndDate.Value;
            }
            else
            {
                (this.entity as Wallnut.Domain.Models.ProductCostHistory).EndDate = null;
            }
            
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtEndDate.Checked)
            {
                (this.entity as Wallnut.Domain.Models.ProductCostHistory).EndDate = dtEndDate.Value;
                //this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            }
            else
            {
                (this.entity as Wallnut.Domain.Models.ProductCostHistory).EndDate = null;

                this.dtEndDate.CustomFormat = " "; // use a space 
                this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            }
        }
    }
}
