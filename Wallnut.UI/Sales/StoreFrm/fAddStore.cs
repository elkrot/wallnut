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

namespace Wallnut.UI.Sales.StoreFrm
{
    public partial class fAddStore : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.SalesPerson> SalesPersonList;
        public fAddStore()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            #region Fill Lists
            /*using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.SalesPersonList = unitOfWork.SalesPersonRepository.GetAll().ToList<Wallnut.Domain.Models.SalesPerson>();
                cbSalesPersonID.DataSource = SalesPersonList;



                this.SalesPersonList = unitOfWork.SalesPersonRepository.GetAll().ToList<Wallnut.Domain.Models.SalesPerson>();
                cbSalesPersonID.DataSource = SalesPersonList;

                foreach (var item in SalesPersonList)
                {
                    cbSalesPersonID.AutoCompleteCustomSource.Add(item.Name);
                }
            }*/
            #endregion

            #region Name
            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Store,
            "Name",
            true,
            DataSourceUpdateMode.OnPropertyChanged,string.Empty);            
            #endregion
            #region tbDemographics
            this.tbDemographics.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Store,
            "Demographics",
            true,
            DataSourceUpdateMode.OnPropertyChanged, string.Empty);
            #endregion

            #region Binding SalesPerson
           /*/ var StoreID = (this.entity as Wallnut.Domain.Models.Customer).StoreID ?? 0;
            cbSalesPersonID.ValueMember = "SalesPersonID";
            cbSalesPersonID.DisplayMember = "Name";
            cbSalesPersonID.SelectedValue = StoreID;
            //(this.entity as Wallnut.Domain.Models.Customer).StoreID = StoreID;
            cbSalesPersonID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.Customer).StoreID =
                    (int?)cbSalesPersonID.SelectedValue;
            };*/
            #endregion

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
            (this.entity as Wallnut.Domain.Models.Store).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
