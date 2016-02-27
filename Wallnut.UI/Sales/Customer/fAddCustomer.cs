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

namespace Wallnut.UI.Sales.Customer
{
    public partial class fAddCustomer : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.SalesTerritory> SalesTerritoryList;
         public List<Wallnut.Domain.Models.Store> StoreList;

        public fAddCustomer()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            #region Fill Lists
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.SalesTerritoryList = unitOfWork.SalesTerritoryRepository.GetAll().ToList<Wallnut.Domain.Models.SalesTerritory>();
                cbTerritoryID.DataSource = SalesTerritoryList;

                foreach (var item in SalesTerritoryList)
                {
                    cbTerritoryID.AutoCompleteCustomSource.Add(item.Name);
                }

                this.StoreList = unitOfWork.StoreRepository.GetAll().ToList<Wallnut.Domain.Models.Store>();
                cbStoreID.DataSource = StoreList;

                foreach (var item in StoreList)
                {
                    cbStoreID.AutoCompleteCustomSource.Add(item.Name);
                }
            }
            #endregion

            if ((this.entity as Wallnut.Domain.Models.Customer).Person == null)
                (this.entity as Wallnut.Domain.Models.Customer).Person = new Person();

            #region LastName
            this.tbLastName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Customer,
            "Person.LastName",
            true,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

            #region FirstName
            this.tbFirstName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Customer,
            "Person.FirstName",
            true,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

            #region MiddleName
            this.tbMiddleName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Customer,
            "Person.MiddleName",
            true,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

            #region AccountNumber
            this.tbAccountNumber.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Customer,
            "AccountNumber",
            true,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

            #region AdditionalContactInfo
            this.rbAdditionalContactInfo.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Customer,
            "Person.AdditionalContactInfo",
            true,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

           // if ((this.entity as Wallnut.Domain.Models.Customer).SalesTerritory == null)
            //    (this.entity as Wallnut.Domain.Models.Customer).SalesTerritory = new Wallnut.Domain.Models.SalesTerritory();
            #region Binding Territory
            var TerritoryID = (this.entity as Wallnut.Domain.Models.Customer).TerritoryID??0;
            cbTerritoryID.ValueMember = "TerritoryID";
            cbTerritoryID.DisplayMember = "Name";
            cbTerritoryID.SelectedValue = TerritoryID;
            //(this.entity as Wallnut.Domain.Models.Customer).TerritoryID = TerritoryID;
            cbTerritoryID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.Customer).TerritoryID =
                    (int?)cbTerritoryID.SelectedValue;
            };
            #endregion
           // if ((this.entity as Wallnut.Domain.Models.Customer).Store == null)
           //     (this.entity as Wallnut.Domain.Models.Customer).Store = new Wallnut.Domain.Models.Store();
            #region Binding Store
            var StoreID = (this.entity as Wallnut.Domain.Models.Customer).StoreID??0;
            cbStoreID.ValueMember = "BusinessEntityID";
            cbStoreID.DisplayMember = "Name";
            cbStoreID.SelectedValue = StoreID;
            //(this.entity as Wallnut.Domain.Models.Customer).StoreID = StoreID;
            cbStoreID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.Customer).StoreID =
                    (int?)cbStoreID.SelectedValue;
            };
            #endregion

        }

        #region fEdit_Load
        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }        
        #endregion




        #region btnOK_Click
        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((this.entity as Wallnut.Domain.Models.Customer).Person.BusinessEntityID == 0
                && (!string.IsNullOrEmpty((this.entity as Wallnut.Domain.Models.Customer).Person.FirstName)
                 || !string.IsNullOrEmpty((this.entity as Wallnut.Domain.Models.Customer).Person.LastName)
                 || !string.IsNullOrEmpty((this.entity as Wallnut.Domain.Models.Customer).Person.MiddleName))
                )
            {
                var id = GetPersonId();
                (this.entity as Wallnut.Domain.Models.Customer).Person.BusinessEntityID = id;
                (this.entity as Wallnut.Domain.Models.Customer).PersonID = id;
                (this.entity as Wallnut.Domain.Models.Customer).Person.PersonType = "SC";
            }
            else {
                (this.entity as Wallnut.Domain.Models.Customer).Person = null;
            }
            (this.entity as Wallnut.Domain.Models.Customer).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }        
        #endregion

        #region GetPersonId
        private int GetPersonId(){
            var id = 0;
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {

                BusinessLogic.Interfaces.IRepository<BusinessEntity> repo = unitOfWork.GetRepository<BusinessEntity>();
                id= (repo as BusinessEntityRepository).GetNewBusinessEntityID();
                  
                
            }
            return id;

        }        
        #endregion

    }
}
