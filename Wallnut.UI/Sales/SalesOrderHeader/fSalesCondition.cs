using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.UI.Implementations;
using Wallnut.UI.Interfaces;
using Wallnut.Domain.Entities;
using Wallnut.BusinessLogic.Implementations;
using Wallnut.Domain.Models;

namespace Wallnut.UI.Sales.SalesOrderHeader
{
    public partial class fSalesCondition : Form, IConditionForm
    {
        private List<Wallnut.Domain.Models.Customer> CustomerList;
        private List<Wallnut.Domain.Models.SalesTerritory> SalesTerritoryList;
        public fSalesCondition()
        {
            InitializeComponent();
        }

        public object DataSource { get; set; }
        #region BindingData
           public void BindingData()
        {
            if (this.dtFrom.DataBindings.Count == 0)
            {
                #region DateFirst
                this.dtFrom.DataBindings.Add("Value",
                (this.DataSource as SalesCondition),
                "DateFirst",
                false,
                DataSourceUpdateMode.OnPropertyChanged);
                #endregion

                #region DateLast
                this.dtTo.DataBindings.Add("Value",
                 (this.DataSource as SalesCondition),
                 "DateLast",
                 false,
                 DataSourceUpdateMode.OnPropertyChanged);
                #endregion

                #region IsCustomer
                this.chIsCustomer.DataBindings.Add("Checked",
                 (this.DataSource as SalesCondition),
                 "IsCustomer",
                 false,
                 DataSourceUpdateMode.OnPropertyChanged);
                #endregion

                #region IsSalesTerritory
                this.chIsSalesTerritory.DataBindings.Add("Checked",
                 (this.DataSource as SalesCondition),
                 "IsSalesTerritory",
                 false,
                 DataSourceUpdateMode.OnPropertyChanged);
                #endregion

                #region IsSalesOrderNumber
                this.chIsSalesOrderNumber.DataBindings.Add("Checked",
                 (this.DataSource as SalesCondition),
                 "IsSalesOrderNumber",
                 false,
                 DataSourceUpdateMode.OnPropertyChanged);
                #endregion

                #region Customer
                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {
                    this.CustomerList = unitOfWork.CustomerRepository.GetAll()
                    .ToList<Wallnut.Domain.Models.Customer>();
                    cbCustomerID.DataSource = CustomerList;
                }

                cbCustomerID.ValueMember = "CustomerID";
                cbCustomerID.DisplayMember = "CustomerName";

                cbCustomerID.SelectedValue = (this.DataSource as SalesCondition).CustomerID;

                cbCustomerID.SelectedIndexChanged += (x, y) =>
                {
                    (this.DataSource as SalesCondition).CustomerID = (int)cbCustomerID.SelectedValue;

                };
                #endregion

                #region SalesTerritoryID
                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {

                    this.SalesTerritoryList = unitOfWork.SalesTerritoryRepository.GetAll()
                    .ToList<Wallnut.Domain.Models.SalesTerritory>();
                    cbTerritoryID.DataSource = SalesTerritoryList;

                }
                cbTerritoryID.ValueMember = "TerritoryID";
                cbTerritoryID.DisplayMember = "Name";
                (this.DataSource as SalesCondition).SalesTerritoryID = (int)cbTerritoryID.SelectedValue;
                cbTerritoryID.SelectedIndexChanged += (x, y) =>
                {
                    (this.DataSource as SalesCondition).SalesTerritoryID = (int)cbTerritoryID.SelectedValue;
                };
                #endregion

                #region SalesOrderNumber
                this.tbSalesOrderNumber.DataBindings.Add("Text",
                (this.DataSource as SalesCondition),
                "SalesOrderNumber",
                false,
                DataSourceUpdateMode.OnPropertyChanged, string.Empty);
                #endregion
            }
        }
      
        #endregion
       public DialogResult ShowForm()
        {
            BindingData();
            return ShowDialog(); 
        }




    }
}
