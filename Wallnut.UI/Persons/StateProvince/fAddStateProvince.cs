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

namespace Wallnut.UI.Persons.StateProvince
{
    public partial class fAddStateProvince : Wallnut.UI.Implementations.AddForm
    {
        private List<Wallnut.Domain.Models.SalesTerritory> territory;
        private List<Wallnut.Domain.Models.CountryRegion> country;
        public fAddStateProvince()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.territory = unitOfWork.SalesTerritoryRepository.GetAll().ToList<Wallnut.Domain.Models.SalesTerritory>();
                cbTerritoryID.DataSource = territory;
                this.country = unitOfWork.CountryRegionRepository.GetAll().ToList<Wallnut.Domain.Models.CountryRegion>();
                cbCountryRegionCode.DataSource = country;

            }

            #region SalesTerritory
            cbTerritoryID.ValueMember = "TerritoryID";
            cbTerritoryID.DisplayMember = "Name";
            cbTerritoryID.SelectedValue =
                (this.entity as Wallnut.Domain.Models.StateProvince).TerritoryID;
            cbTerritoryID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.StateProvince).TerritoryID =
                    (int)cbTerritoryID.SelectedValue;
            };
            #endregion


            #region StateProvinceCode
            this.tbStateProvinceCode.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.StateProvince,
            "StateProvinceCode",
            false,
            DataSourceUpdateMode.OnPropertyChanged);            
            #endregion

            #region CountryRegionCode
            cbCountryRegionCode.ValueMember = "CountryRegionCode";
            cbCountryRegionCode.DisplayMember = "Name";
            cbCountryRegionCode.SelectedValue =
                (this.entity as Wallnut.Domain.Models.StateProvince).CountryRegionCode??"UA";
            (this.entity as Wallnut.Domain.Models.StateProvince).CountryRegionCode =
    cbCountryRegionCode.SelectedValue.ToString();
            cbCountryRegionCode.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.StateProvince).CountryRegionCode =
                    cbCountryRegionCode.SelectedValue.ToString();
            };
            #endregion

            #region Name
            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.StateProvince,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbStateProvinceCode.Text))
            {
                e.Cancel = true; tbStateProvinceCode.Focus(); ep.SetError(tbStateProvinceCode, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbStateProvinceCode, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.StateProvince).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
