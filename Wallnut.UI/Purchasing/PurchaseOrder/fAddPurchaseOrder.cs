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
    public partial class fAddPurchaseOrder : Wallnut.UI.Implementations.AddForm
    {
       public List<Wallnut.Domain.Models.Employee> EmployeeList;
       public List<Wallnut.Domain.Models.Vendor> VendorList;
       public List<Wallnut.Domain.Models.ShipMethod> ShipMethodList;
       public bool UpdateInForm = false;

        public fAddPurchaseOrder()
        {
            InitializeComponent();
        }

        #region BindingData
        private void BindingData()
        {

            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.EmployeeList = unitOfWork.EmployeeRepository.GetAll().ToList<Wallnut.Domain.Models.Employee>();
                this.VendorList = unitOfWork.VendorRepository.GetAll().ToList<Wallnut.Domain.Models.Vendor>();
                this.ShipMethodList = unitOfWork.ShipMethodRepository.GetAll().ToList<Wallnut.Domain.Models.ShipMethod>();

                cbEmployeeID.DataSource = EmployeeList;
                cbVendorID.DataSource = VendorList;
                foreach (var item in VendorList)
	                {
		                 cbVendorID.AutoCompleteCustomSource.Add(item.Name); 
	                }
                
                cbShipMethodID.DataSource = ShipMethodList;
            }

            this.tbRevisionNumber.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.PurchaseOrderHeader,
            "RevisionNumber",
            false, DataSourceUpdateMode.OnPropertyChanged);

            this.cbStatus.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.PurchaseOrderHeader,
            "Status",
            false, DataSourceUpdateMode.OnPropertyChanged);

            cbStatus.DataSource = new BindingSource(
                new Dictionary<byte, string>() { {1, "Ожидает согласования" }
                ,{ 2, "Подтвержден" }
                ,{ 3, "Отклонен" }
                ,{ 4, "Завершен" }}, null);
            cbStatus.ValueMember = "Key";
            cbStatus.DisplayMember = "Value";

            cbStatus.SelectedValue = (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).Status;
            cbStatus.SelectedIndexChanged += (x, y) =>
            { 
                (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).Status = (byte)cbStatus.SelectedValue; };

            cbEmployeeID.ValueMember = "BusinessEntityID";
            cbEmployeeID.DisplayMember = "FIO";
            cbEmployeeID.SelectedValue =
            (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).EmployeeID;
            cbEmployeeID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).EmployeeID =
                (int)cbEmployeeID.SelectedValue;
            };


            cbVendorID.ValueMember = "BusinessEntityID";
            cbVendorID.DisplayMember = "Name";
            cbVendorID.SelectedValue =
            (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).VendorID;
            cbVendorID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).VendorID =
                (int)cbVendorID.SelectedValue;
            };

            cbShipMethodID.ValueMember = "ShipMethodID";
            cbShipMethodID.DisplayMember = "Name";
            cbShipMethodID.SelectedValue =
            (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).ShipMethodID;
            cbShipMethodID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).ShipMethodID =
                (int)cbShipMethodID.SelectedValue;
            };

            if ((this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).OrderDate == DateTime.MinValue) {
                (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).OrderDate = DateTime.Now;
            }

            this.dtOrderDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.PurchaseOrderHeader,
            "OrderDate",
            false, DataSourceUpdateMode.OnPropertyChanged);

            //this.dtShipDate.DataBindings.Add("Value",
            //this.entity as Wallnut.Domain.Models.PurchaseOrderHeader,
            //"ShipDate",
            //false, DataSourceUpdateMode.OnPropertyChanged);
            this.dtShipDate.Value = (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).ShipDate ?? DateTime.Now;



            this.tbSubTotal.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.PurchaseOrderHeader,
            "SubTotal",
            false, DataSourceUpdateMode.OnPropertyChanged);

            this.tbTaxAmt.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.PurchaseOrderHeader,
            "TaxAmt",
            false, DataSourceUpdateMode.OnPropertyChanged);

            this.tbFreight.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.PurchaseOrderHeader,
            "Freight",
            false, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
        

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
            InitUpdateInFormEvent();
        }
        #region InitUpdateInFormEvent
        private void InitUpdateInFormEvent()
        {
            foreach (var item in this.panel1.Controls[0].Controls)
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



        private void btnOK_Click(object sender, EventArgs e)
        {
             (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).ModifiedDate = DateTime.Now;
             (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).OrderDate = this.dtOrderDate.Value;
           
             (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).ShipDate = this.dtShipDate.Value;
            if (!this.ValidateChildren())
            {
               
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbRevisionNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbRevisionNumber_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Наименование", ref ep);
        }

        private bool ValidateForm()
        {
            if (!this.ValidateChildren())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return false;
            }
            return true;
        }

        private void fAddPurchaseOrder_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbEmployeeID_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<ComboBox>(ref  sender, ref  e, "Ответственный", ref ep);
        }

        private void cbVendorID_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<ComboBox>(ref  sender, ref  e, "Поставщик", ref ep);
        }

        private void cbShipMethodID_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<ComboBox>(ref  sender, ref  e, "Метод доставки", ref ep);
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

        private void fAddPurchaseOrder_KeyDown(object sender, KeyEventArgs e)
        {
            OnHotKeyDown( e);
        }

        private void fAddPurchaseOrder_Activated(object sender, EventArgs e)
        {
            tbRevisionNumber.Focus();
        }
    }
}
