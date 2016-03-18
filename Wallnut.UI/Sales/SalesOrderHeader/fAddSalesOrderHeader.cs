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

namespace Wallnut.UI.Sales.SalesOrderHeader
{
    public partial class fAddSalesOrderHeader : Wallnut.UI.Implementations.AddForm
    {

        private List<Wallnut.Domain.Models.Customer> CustomerList;
        //    private List<Wallnut.Domain.Models.SalesPerson> SalesPersonList;
        private List<Wallnut.Domain.Models.SalesTerritory> SalesTerritoryList;
        private List<Wallnut.Domain.Models.CurrencyRate> CurrencyRateList;
        private List<Wallnut.Domain.Models.ShipMethod> ShipMethodList;


        public fAddSalesOrderHeader()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            /*


      ,[]

      ,[BillToAddressID]
      ,[ShipToAddressID]
      ,[]
      ,[]

             */
            #region FillLists
             using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.CustomerList = unitOfWork.CustomerRepository.GetAll().ToList<Wallnut.Domain.Models.Customer>();
               cbCustomerID.DataSource = CustomerList;
             /*  this.SalesPersonList = unitOfWork.SalesPersonRepository.GetAll().ToList<Wallnut.Domain.Models.SalesPerson>();
               cbSalesPersonID.DataSource = SalesPersonList;*/
               #region CustomerID
               cbCustomerID.ValueMember = "CustomerID";
               cbCustomerID.DisplayMember = "CustomerName";

               cbCustomerID.SelectedIndexChanged += (x, y) =>
               {
                   (this.entity as Wallnut.Domain.Models.SalesOrderHeader).CustomerID = (int)cbCustomerID.SelectedValue;
               };
               #endregion

               this.SalesTerritoryList = unitOfWork.SalesTerritoryRepository.GetAll().ToList<Wallnut.Domain.Models.SalesTerritory>();
               cbTerritoryID.DataSource = SalesTerritoryList;
                this.ShipMethodList = unitOfWork.ShipMethodRepository.GetAll().ToList<Wallnut.Domain.Models.ShipMethod>();
               cbShipMethodID.DataSource = ShipMethodList;

               this.CurrencyRateList = unitOfWork.CurrencyRateRepository.GetAll().ToList<Wallnut.Domain.Models.CurrencyRate>();
               
                
            }
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

            #region Comment
            this.tbComment.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesOrderHeader,
            "Comment",
            false,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion


  
            #region SalesTerritory
            cbTerritoryID.ValueMember = "TerritoryID";
            cbTerritoryID.DisplayMember = "Name";

            cbTerritoryID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).TerritoryID = (int)cbTerritoryID.SelectedValue;
            };               
            #endregion
  
            #region CurrencyRate

            if ((this.entity as Wallnut.Domain.Models.SalesOrderHeader).CurrencyRateID!=null){
             var CurrencyRateID=(this.entity as Wallnut.Domain.Models.SalesOrderHeader).CurrencyRateID;
            tbCurrencyRateID.Text = CurrencyRateList.Where(x => x.CurrencyRateID == CurrencyRateID).FirstOrDefault().Rate.ToString();
            }
            #endregion

            #region ShipMethod
            cbShipMethodID.ValueMember = "ShipMethodID";
            cbShipMethodID.DisplayMember = "Name";

            cbTerritoryID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderHeader).ShipMethodID = (int)cbShipMethodID.SelectedValue;
            };               
            #endregion
                
                
        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fSalesTerritory f = new fSalesTerritory();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fBusinessEntityAddress f = new fBusinessEntityAddress();
            f.ShowDialog();
        }
    }
}
