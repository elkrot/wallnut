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
using Wallnut.UI.Sales.Customer;
using Wallnut.UI.Sales.SalesTerritory;
using Wallnut.UI.Persons.frmBusinessEntityAddress;
using Wallnut.UI.Purchasing.ShipMethod;

namespace Wallnut.UI.Sales.SalesOrderHeader
{
    public partial class fAddSalesOrderHeader : Wallnut.UI.Implementations.AddForm
    {

        private List<Wallnut.Domain.Models.Customer> CustomerList;
        private List<Wallnut.Domain.Models.BusinessEntityAddress> BillToAddressList;
        private List<Wallnut.Domain.Models.BusinessEntityAddress> ShipToAddressList;
        private List<Wallnut.Domain.Models.SalesTerritory> SalesTerritoryList;
        private List<Wallnut.Domain.Models.CurrencyRate> CurrencyRateList;
        private List<Wallnut.Domain.Models.ShipMethod> ShipMethodList;
        //public int CustomerID { get; set; }

        public fAddSalesOrderHeader()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

/* Lists */
            #region CustomerID
            UpdateCustomerList();
            #endregion    
            
            #region BillToAddress
             UpdateBillToAddress();
	        #endregion

            #region ShipToAddress
             UpdateShipToAddress();
	        #endregion

            #region SalesTerritory
             UpdateSalesTerritory();
             #endregion

            #region CurrencyRate
             UpdateCurrencyRate();
             #endregion

            #region ShipMethod
             UpdateShipMethod();
             #endregion

/* Date fields */

            #region OrderDate
            if ((this.entity as Wallnut.Domain.Models.SalesOrderHeader).OrderDate == DateTime.MinValue) {
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).OrderDate = DateTime.Now;
            }

            this.dtOrderDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "OrderDate",
            true,
            DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            #endregion

            #region DueDate
            if ((this.entity as Wallnut.Domain.Models.SalesOrderHeader).DueDate == DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).DueDate = DateTime.Now;
            }

            this.dtDueDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "DueDate",
            true,
            DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            #endregion

            #region ShipDate

            if ((this.entity as Wallnut.Domain.Models.SalesOrderHeader).ShipDate == DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).ShipDate = DateTime.Now;
            }
            this.dtShipDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "ShipDate",
            true,
            DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            #endregion
/* Other fields */
            #region AccountNumber
            this.tbAccountNumber.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "AccountNumber",
            false,
            DataSourceUpdateMode.OnPropertyChanged,string.Empty);            
            #endregion

            #region PurchaseOrderNumber
            this.tbPurchaseOrderNumber.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "PurchaseOrderNumber",
            false,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

            #region SubTotal
            this.tbSubTotal.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "SubTotal",
            true,
            DataSourceUpdateMode.OnPropertyChanged, 0);
            #endregion

            #region TaxAmt
            this.tbTaxAmt.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "TaxAmt",
            true,
            DataSourceUpdateMode.OnPropertyChanged, 0);
            #endregion

            #region Freight
            this.tbFreight.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "Freight",
            true,
            DataSourceUpdateMode.OnPropertyChanged, 0);
            #endregion

            #region TotalDue
    /*        this.tbTotalDue.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "TotalDue",
            true,
            DataSourceUpdateMode.OnPropertyChanged, 0);*/
            #endregion

            #region Status
            cbStatus.DataSource = new BindingSource(
                         new Dictionary<byte, string>() { 
                         { 1, "В процессе выполнения" }
                         , { 2, "Подтвержден" }
                         , { 3, "Возвращен с замечаниями клиента" }
                         , { 4, "Отклонен" }
                         , { 5, "Отправлен" }
                         , { 6, "Отменен" }}, null);
          
            cbStatus.ValueMember = "Key";
            cbStatus.DisplayMember = "Value";
            if((this.entity as Wallnut.Domain.Models.SalesOrderHeader).Status==0){
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).Status = 1;
            }
          //  employee.MaritalStatus = employee.MaritalStatus ?? "M";
            cbStatus.SelectedValue = (this.entity as Wallnut.Domain.Models.SalesOrderHeader).Status;

            cbStatus.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).Status =
                (byte)cbStatus.SelectedValue;
            };
            #endregion

            #region Comment
            this.tbComment.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "Comment",
            false,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

        }
        /* Update List */
        #region UpdateShipMethod
        private void UpdateShipMethod()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {

                this.ShipMethodList = unitOfWork.ShipMethodRepository.GetAll()
               .ToList<Wallnut.Domain.Models.ShipMethod>();
                cbShipMethodID.DataSource = ShipMethodList;

            }
            cbShipMethodID.ValueMember = "ShipMethodID";
            cbShipMethodID.DisplayMember = "Name";
            (this.entity as Wallnut.Domain.Models.SalesOrderHeader).ShipMethodID = (int)cbShipMethodID.SelectedValue;
            cbShipMethodID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).ShipMethodID = (int)cbShipMethodID.SelectedValue;
            };
        }
        #endregion

        #region UpdateCurrencyRate
        private void UpdateCurrencyRate()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.CurrencyRateList = unitOfWork.CurrencyRateRepository.GetAll()
                .ToList<Wallnut.Domain.Models.CurrencyRate>();

            }
            if ((this.entity as Wallnut.Domain.Models.SalesOrderHeader).CurrencyRateID != null)
            {
                var CurrencyRateID = (this.entity as Wallnut.Domain.Models.SalesOrderHeader).CurrencyRateID;
                tbCurrencyRateID.Text = CurrencyRateList.Where(x => x.CurrencyRateID == CurrencyRateID).FirstOrDefault().Rate.ToString();
            }
        }        
        #endregion

        #region UpdateSalesTerritory
        private void UpdateSalesTerritory()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {

                this.SalesTerritoryList = unitOfWork.SalesTerritoryRepository.GetAll()
                .ToList<Wallnut.Domain.Models.SalesTerritory>();
                cbTerritoryID.DataSource = SalesTerritoryList;

            }
            cbTerritoryID.ValueMember = "TerritoryID";
            cbTerritoryID.DisplayMember = "Name";
            (this.entity as Wallnut.Domain.Models.SalesOrderHeader).TerritoryID = (int)cbTerritoryID.SelectedValue;
            cbTerritoryID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).TerritoryID = (int)cbTerritoryID.SelectedValue;
            };
        }        
        #endregion

        #region UpdateCustomerList
        private void UpdateCustomerList()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.CustomerList = unitOfWork.CustomerRepository.GetAll()
                .ToList<Wallnut.Domain.Models.Customer>();
                cbCustomerID.DataSource = CustomerList;
            }

            cbCustomerID.ValueMember = "CustomerID";
            cbCustomerID.DisplayMember = "CustomerName";

            cbCustomerID.SelectedValue = (this.entity as Wallnut.Domain.Models.SalesOrderHeader).CustomerID;
 
            cbCustomerID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).CustomerID = (int)cbCustomerID.SelectedValue;
                UpdateBillToAddress();
                UpdateShipToAddress();
            };

            UpdateBillToAddress();

            UpdateShipToAddress();
        }        
        #endregion

        #region UpdateShipToAddress
        private void UpdateShipToAddress()
        {
            int CustomerID = 0;
            if (cbCustomerID.SelectedValue != null)
                Int32.TryParse(cbCustomerID.SelectedValue.ToString(), out CustomerID); 
            UpdateShipToAddressList(CustomerID);
            cbShipToAddressID.DataSource = ShipToAddressList;
                cbShipToAddressID.ValueMember = "AddressID";
                cbShipToAddressID.DisplayMember = "AddressTitle";
                
                    cbShipToAddressID.SelectedValue=(this.entity as Wallnut.Domain.Models.SalesOrderHeader).ShipToAddressID;

                cbShipToAddressID.SelectedIndexChanged += (x, y) =>
                {
                    (this.entity as Wallnut.Domain.Models.SalesOrderHeader).ShipToAddressID 
                        = (int)cbShipMethodID.SelectedValue;
                };

        }        
        #endregion

        #region UpdateAdressLists
        private void UpdateBillToAddressList(int CustomerID)
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                BillToAddressList = unitOfWork.BusinessEntityAddressRepository
                .Find(x => x.BusinessEntityID == CustomerID).ToList<Wallnut.Domain.Models.BusinessEntityAddress>();
            }
        }


        private void UpdateShipToAddressList(int CustomerID)
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                ShipToAddressList = unitOfWork.BusinessEntityAddressRepository
                .Find(x => x.BusinessEntityID == CustomerID).ToList<Wallnut.Domain.Models.BusinessEntityAddress>();
            }
        }   

        #endregion

        #region UpdateBillToAddress
        private void UpdateBillToAddress()
        {
            int CustomerID = 0;
            if (cbCustomerID.SelectedValue!=null)
            Int32.TryParse(cbCustomerID.SelectedValue.ToString(), out CustomerID); 

            UpdateBillToAddressList(CustomerID);
            cbBillToAddressID.DataSource = BillToAddressList;
            cbBillToAddressID.ValueMember = "AddressID";
            cbBillToAddressID.DisplayMember = "AddressTitle";

            
                cbBillToAddressID.SelectedValue=(this.entity as Wallnut.Domain.Models.SalesOrderHeader).BillToAddressID;
                cbBillToAddressID.SelectedIndexChanged += (x, y) =>
                {
                    (this.entity as Wallnut.Domain.Models.SalesOrderHeader).BillToAddressID 
                        = (int)cbBillToAddressID.SelectedValue;
                };
            
        }        
        #endregion

        /* OnBtns Click */

        #region btnOK_Click
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }        
        #endregion

        #region btnCustomerEdit_Click
        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.ShowDialog();
            UpdateCustomerList();
        }        
        #endregion

        #region btnTerritoryEdit_Click
        private void btnTerritoryEdit_Click(object sender, EventArgs e)
        {
            fSalesTerritory f = new fSalesTerritory();
            f.ShowDialog();
            UpdateSalesTerritory();
        }        
        #endregion

        #region btnBillToAddressEdit_Click
        private void btnBillToAddressEdit_Click(object sender, EventArgs e)
        {
            if (cbCustomerID.SelectedIndex !=-1)
            {
                fBusinessEntityAddress f = new fBusinessEntityAddress();

                f.BusinessEntityID = (int)cbCustomerID.SelectedValue;
                f.ShowDialog();
                UpdateBillToAddress();
            }
        }        
        #endregion

        #region btnShipToAddressEdit_Click
        private void btnShipToAddressEdit_Click(object sender, EventArgs e)
        {
            if (cbCustomerID.SelectedIndex != -1)
            {
                fBusinessEntityAddress f = new fBusinessEntityAddress();

                f.BusinessEntityID = (int)cbCustomerID.SelectedValue;
                f.ShowDialog();
                UpdateShipToAddress();
            }
        }        
        #endregion

        #region btnShipMethod_Click
        private void btnShipMethod_Click(object sender, EventArgs e)
        {
            fShipMethod f = new fShipMethod();
            f.ShowDialog();
            UpdateSalesTerritory();
        }        
        #endregion

        #region CurrencyRate_Click
        private void CurrencyRate_Click(object sender, EventArgs e)
        {
            fShipMethod f = new fShipMethod();
            f.ShowDialog();
            UpdateCurrencyRate();
        }        
        #endregion

/* Other procs */
        #region Load
        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }
        #endregion


        #region tbName_Validating
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAccountNumber.Text))
            {
                e.Cancel = true; tbAccountNumber.Focus(); ep.SetError(tbAccountNumber, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbAccountNumber, "");
            }
        }
        #endregion



    }
}
