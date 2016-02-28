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
        public bool UpdateInForm = false;
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
            InitUpdateInFormEvent();
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
            double ReceivedQty = Convert.ToDouble(tbReceivedQty.Text == "" ? "0" : tbReceivedQty.Text);
            double RejectedQty = Convert.ToDouble(tbRejectedQty.Text == "" ? "0" : tbRejectedQty.Text);
            double val=0;
            if (RejectedQty > ReceivedQty)
            { val = 0; }
            else
             val = ReceivedQty - RejectedQty;
            lblSklad.Text = string.Format("{0}", val);
        }

        private void tbReceivedQty_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Количесиво факт", ref ep,Utils.ValType.Numeric);
        }

        private void tbRejectedQty_Validating(object sender, CancelEventArgs e)
        {
          //  Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Брак", ref ep, Utils.ValType.Numeric);
        }

        private void tbOrderQty_TextChanged(object sender, EventArgs e)
        {
            double OrderQty = 0;
            double UnitPrice =0;
            if (double.TryParse(tbOrderQty.Text,out OrderQty) && (double.TryParse(tbUnitPrice.Text,out UnitPrice)))
            {
                double val = OrderQty * UnitPrice;
            lblLineTotal.Text = string.Format("{0}", val);
            }
        }

        private void fAddPurchaseOrderDetail_Activated(object sender, EventArgs e)
        {
            dtDueDate.Focus();
        }

        #region OnHotKeyDown
        private void OnHotKeyDown(KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnOK_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape) this.Close();

        }
        #endregion

        private void fAddPurchaseOrderDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UpdateInForm && ((sender as Form).DialogResult) != System.Windows.Forms.DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    btnOK_Click(this, EventArgs.Empty);
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    //Не сохраняем
                }
                else e.Cancel = true;//Отменяем действие
            }
        }

        private void fAddPurchaseOrderDetail_KeyDown(object sender, KeyEventArgs e)
        {
            OnHotKeyDown(e);
        }
        #region InitUpdateInFormEvent
        private void InitUpdateInFormEvent()
        {
            foreach (var item in this.tableLayoutPanel1.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).TextChanged += (o, e) =>
                    {
                        UpdateInForm = true;
                    };
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndexChanged += (o, e) => { UpdateInForm = true; };
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).CheckedChanged += (o, e) => { UpdateInForm = true; };
                }
            }
        }
        #endregion 

    }
}
