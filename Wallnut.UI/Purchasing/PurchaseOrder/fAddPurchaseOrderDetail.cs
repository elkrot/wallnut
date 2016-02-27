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

namespace Wallnut.UI.Purchasing.PurchaseOrder
{
    public partial class fAddPurchaseOrderDetail : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Product> ProductList;
        private int purchaseOrderID { get; set; }
        public fAddPurchaseOrderDetail()
        {

            InitializeComponent();
        }

        #region BindingData
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

            var productID = (this.entity as Wallnut.Domain.Models.PurchaseOrderDetail).ProductID;
            cbProduct.ValueMember = "ProductID";
            cbProduct.DisplayMember = "Name";
            cbProduct.SelectedValue = productID;
            (this.entity as Wallnut.Domain.Models.PurchaseOrderDetail).ProductID = productID;
            cbProduct.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.PurchaseOrderDetail).ProductID =
                    (int)cbProduct.SelectedValue;
            };

            if ((this.entity as Wallnut.Domain.Models.PurchaseOrderDetail).DueDate == DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.PurchaseOrderDetail).DueDate = DateTime.Now;
            }

            this.dtDueDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.PurchaseOrderDetail,
            "DueDate",
            false,
            DataSourceUpdateMode.OnPropertyChanged);


            this.tbOrderQty.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.PurchaseOrderDetail,
            "OrderQty",
            false, DataSourceUpdateMode.OnPropertyChanged);

            this.tbUnitPrice.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.PurchaseOrderDetail,
            "UnitPrice",
            false, DataSourceUpdateMode.OnPropertyChanged);

            this.tbReceivedQty.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.PurchaseOrderDetail,
            "ReceivedQty",
            false, DataSourceUpdateMode.OnPropertyChanged);

            this.tbRejectedQty.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.PurchaseOrderDetail,
            "RejectedQty",
            false, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion

         #region Form_Load
         private void fEdit_Load(object sender, EventArgs e)
        {
            if (this.AddParams != null)
            {
                purchaseOrderID = (int)this.AddParams[0];
                (this.entity as Wallnut.Domain.Models.PurchaseOrderDetail).PurchaseOrderID = purchaseOrderID;
            }
            BindingData();
        }         
         #endregion 


         #region Validating
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Количество", ref ep, Utils.ValType.Numeric);
        } 
         #endregion


        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.PurchaseOrderDetail).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void tbUnitPrice_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Цена", ref ep, Utils.ValType.Numeric);
        }

        private void cbProduct_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<ComboBox>(ref  sender, ref  e, "Продукт", ref ep);
        }

        private void tbLineTotal_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void tbReceivedQty_TextChanged(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(tbReceivedQty.Text == "" ? "0" : tbReceivedQty.Text) -
                Convert.ToDouble(tbRejectedQty.Text == "" ? "0" : tbRejectedQty.Text);
            lblLineTotal.Text = string.Format("{0}", val);
        }

        private void tbReceivedQty_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Количесиво факт", ref ep,Utils.ValType.Numeric);
        }

        private void tbRejectedQty_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Брак", ref ep, Utils.ValType.Numeric);
        }

        private void tbOrderQty_TextChanged(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(tbOrderQty.Text == "" ? "0" : tbOrderQty.Text) * Convert.ToDouble(tbUnitPrice.Text == "" ? "0" : tbUnitPrice.Text);
            lblLineTotal.Text = string.Format("{0}", val);
        }
    }
}
