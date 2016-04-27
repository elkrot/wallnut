using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.UI.Persons.AddressTypes;
using Wallnut.UI.Production.UnitMeasure;
using Wallnut.UI.Persons.ContactType;
using Wallnut.Domain.Models;
using Wallnut.UI.Persons.CountryRegion;
using Wallnut.UI.Persons.Address;
using Wallnut.UI.Sales.Currency;
using Wallnut.UI.Sales.CurrencyRate;
using Wallnut.UI.HumanResources.EmployeeDepartmentHistory;
using Wallnut.UI.fTemplates;
using Wallnut.UI.Sales;
using Wallnut.UI.Implementations;
using Wallnut.UI.Purchasing.Vendor;
using Wallnut.UI.Purchasing.ShipMethod;
using Wallnut.UI.Purchasing.PurchaseOrder;
using Wallnut.UI.Production.Expentitude;
using Wallnut.UI.Production.ExpenditureCostHistory;
using Wallnut.UI.Reports;
using Wallnut.UI.Production.WorkOrder;
using Wallnut.UI.HumanResources.frmEmployeeAttendanceHistory;
using Wallnut.UI.Production.frmProductInventory;
using Wallnut.UI.Sales.Customer;
using Wallnut.UI.Sales.SalesTerritory;
using Wallnut.UI.Sales.StoreFrm;
using Wallnut.UI.Sales.SalesOrderHeader;
using Wallnut.UI.Persons.StateProvince;
using Wallnut.UI.Sales.SpecialOfferFrm;
using Wallnut.UI.Admin.RoleFrm;
using Wallnut.UI.Admin.PropertyFrm;

namespace Wallnut.UI
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
          //  this.KeyUp += new KeyEventHandler(OKP);


        }

        //описание обработчика события
        private void OKP(object sender, KeyEventArgs e)
        {

            MessageBox.Show(e.KeyCode.ToString(), "Pressed");
        }

        private void продукцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prod = new fProducts();
            prod.ShowDialog();
        }

        private void tsmiDirection_Click(object sender, EventArgs e)
        {
            var fd = new fDepartment();
            fd.ShowDialog();
        }

        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            var fe = new fEmployee();
            fe.ShowDialog();
        }

        private void tsmShift_Click(object sender, EventArgs e)
        {
            var fe = new fShifts();
            fe.ShowDialog();
        }

        private void tsmiAddessTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new fAddressType();
            frm.ShowDialog();
        }

        private void tsmiUnitMesureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new fUnitMeasure();
            frm.ShowDialog();
        }

        private void tsmiContactTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new fContactType();
            frm.ShowDialog();
        }

        private void tsmiCountryRegion_Click(object sender, EventArgs e)
        {
            var frm = new fCountryRegion();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           /*var frm = new fShipMethod();
            frm.ShowDialog();*/
            fShipMethod f = fShipMethod.Instance();
            f.MdiParent = this;

            f.Show();

            f.Activate();
        }

        private void tsmiAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new fAddress();
            frm.ShowDialog();
        }

        private void tsmiCurrency_Click(object sender, EventArgs e)
        {
            var frm = new fCurrency();
            frm.ShowDialog();
        }

        private void курсыВалютToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new fCurrencyRate();
            frm.ShowDialog();
        }

        private void tsmiEmployeeDepartmentHistory_Click(object sender, EventArgs e)
        {
            var frm = new fEmployeeDepartmentHistory();
            frm.ShowDialog();
        }

        private void tmplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ViewForm();
            frm.ShowDialog();
        }

        private void типыЗатратToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new fExpenditure();
            frm.ShowDialog();
        }

        private void tsmiVendor_Click(object sender, EventArgs e)
        {
            var frm = new fVendor();
            frm.ShowDialog();
        }

        private void мелкийОбъемToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*var frm = new fPurchaseOrder();
            frm.ShowDialog();*/
            fPurchaseOrder f = fPurchaseOrder.Instance();
            f.MdiParent = this;

            f.Show();

            f.Activate();
        }

        private void tsmiDirection_Click_1(object sender, EventArgs e)
        {
            var fd = new fDepartment();
            fd.ShowDialog();
        }

        private void прочиеЗатратыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new fExpenditureCostHistory();
            frm.ShowDialog();
        }

        private void продажиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fSalesOrderHeader f = fSalesOrderHeader.Instance();
            f.MdiParent = this;

            f.Show();

            f.Activate();
        }


        private void fMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void производствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fWorkOrder f = fWorkOrder.Instance();
            f.MdiParent = this;

            f.Show();

            f.Activate();
            
        }

        private void выходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmployeeAttendanceHistory f = fEmployeeAttendanceHistory.Instance();
            f.MdiParent = this;

            f.Show();

            f.Activate();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiInventory_Click(object sender, EventArgs e)
        {
            fProductInventory f = fProductInventory.Instance();
            f.MdiParent = this;

            f.Show();

            f.Activate();
        }

        private void tsmiCustomer_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.ShowDialog();
        }

        private void tsmiSalesTerritory_Click(object sender, EventArgs e)
        {
            fSalesTerritory f = new fSalesTerritory();
            f.ShowDialog();
        }

        private void tsmiStore_Click(object sender, EventArgs e)
        {
            fStore f= new fStore();
            f.ShowDialog();
        }

        private void tsmSRegion_Click(object sender, EventArgs e)
        {
            fStateProvince f = new fStateProvince();
            f.ShowDialog();
        }

        private void tsmSpecialOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSpecialOffer f = new fSpecialOffer();
            f.ShowDialog();
        }

        private void tsmSpecialOfferProduct_Click(object sender, EventArgs e)
        {
            fSpecialOfferProduct f = new fSpecialOfferProduct();
            f.ShowDialog();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRole frm = new fRole();
            frm.ShowDialog();
        }

        private void свойстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProperty frm = new fProperty();
            frm.ShowDialog();
        }
        
        /*
         
         Тип операции Прием в работу, готовый продукт, списано в производство, Склад, выдано в расфасовку
         
         * 
         */

    }
}
