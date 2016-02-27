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

namespace Wallnut.UI.Sales.SalesTerritory
{
    public partial class fAddSalesTerritory : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.CountryRegion> CountryRegionCodeList;

        public fAddSalesTerritory()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            #region Fill Lists
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.CountryRegionCodeList = unitOfWork.CountryRegionRepository.GetAll().ToList<Wallnut.Domain.Models.CountryRegion>();
                cbCountryRegionCode.DataSource = CountryRegionCodeList;

            }
            #endregion

            #region Binding CountryRegionCode
            var CountryRegionCode = (this.entity as Wallnut.Domain.Models.SalesTerritory).CountryRegionCode??"UA";
            cbCountryRegionCode.ValueMember = "CountryRegionCode";
            cbCountryRegionCode.DisplayMember = "Name";
            cbCountryRegionCode.SelectedValue = CountryRegionCode;
            (this.entity as Wallnut.Domain.Models.SalesTerritory).CountryRegionCode = CountryRegionCode;
            cbCountryRegionCode.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalesTerritory).CountryRegionCode =
                    (string)cbCountryRegionCode.SelectedValue;
            };
            #endregion

            #region Name
            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesTerritory,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);            
            #endregion

            #region Group
            this.tbGroup.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesTerritory,
            "Group",
            false,
            DataSourceUpdateMode.OnPropertyChanged);            
            #endregion

            #region SalesYTD
            this.tbSalesYTD.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesTerritory,
            "SalesYTD",
            false,
            DataSourceUpdateMode.OnPropertyChanged);            
            #endregion

            #region SalesLastYear
                         this.tbSalesLastYear.DataBindings.Add("Text"
                        ,this.entity as Wallnut.Domain.Models.SalesTerritory,
                        "SalesLastYear",
                        false,
                        DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region CostYTD
            this.tbCostYTD.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesTerritory,
            "CostYTD",
            false,
            DataSourceUpdateMode.OnPropertyChanged);            
            #endregion

            #region CostLastYear
            this.tbCostLastYear.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesTerritory,
            "CostLastYear",
            false,
            DataSourceUpdateMode.OnPropertyChanged);            
            #endregion


            /*
      ,[CountryRegionCode]

             */


        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true; tbName.Focus(); ep.SetError(tbName, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbName, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.SalesTerritory).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
