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

        public fAddPurchaseOrder()
        {

            InitializeComponent();
        }

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

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRevisionNumber.Text))
            {
                e.Cancel = true; tbRevisionNumber.Focus(); ep.SetError(tbRevisionNumber, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbRevisionNumber, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
             (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).ModifiedDate = DateTime.Now;
             (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).OrderDate = this.dtOrderDate.Value;
            // (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).ShipDate = this.dtShipDate.Value;
             (this.entity as Wallnut.Domain.Models.PurchaseOrderHeader).ShipDate = this.dtShipDate.Value;
            if (!this.ValidateChildren())
            {
               
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
