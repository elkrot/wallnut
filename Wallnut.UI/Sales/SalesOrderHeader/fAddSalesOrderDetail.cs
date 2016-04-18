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

namespace Wallnut.UI.Sales.SalesOrderDetail
{
    public partial class fAddSalesOrderDetail : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Product> ProductList;
        public List<Wallnut.Domain.Models.SpecialOffer> SpecialOfferList;
        public fAddSalesOrderDetail()
        {
            InitializeComponent();
        }

        #region BindingData
        private void BindingData()
        {   
            #region Fill ProductList
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.ProductList = unitOfWork.ProductsRepository.GetAll().ToList<Wallnut.Domain.Models.Product>();
                cbProductID.DataSource = ProductList;
                foreach (var item in ProductList)
                {
                    cbProductID.AutoCompleteCustomSource.Add(item.Name);
                }
            }            
            #endregion

            #region Binding Product
            var productID = (this.entity as Wallnut.Domain.Models.SalesOrderDetail).ProductID;
            cbProductID.ValueMember = "ProductID";
            cbProductID.DisplayMember = "Name";
            cbProductID.SelectedValue = productID;
            (this.entity as Wallnut.Domain.Models.SalesOrderDetail).ProductID = productID;
            cbProductID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderDetail).ProductID =
                    (int)cbProductID.SelectedValue;
            };           
            #endregion

            #region Fill SpecialOfferList
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.SpecialOfferList = unitOfWork.SpecialOfferRepository
                    .GetAll().ToList<SpecialOffer>();
                cbSpecialOfferID.DataSource = SpecialOfferList;
                foreach (var item in SpecialOfferList)
                {
                    cbSpecialOfferID.AutoCompleteCustomSource.Add(item.Description);
                }
            }
            #endregion

            #region Binding SpecialOffer
            var SpecialOfferID = (this.entity as Wallnut.Domain.Models.SalesOrderDetail).SpecialOfferID;
            cbSpecialOfferID.ValueMember = "SpecialOfferID";
            cbSpecialOfferID.DisplayMember = "Description";
            cbSpecialOfferID.SelectedValue = SpecialOfferID;
            (this.entity as Wallnut.Domain.Models.SalesOrderDetail).SpecialOfferID = SpecialOfferID;
            cbSpecialOfferID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SalesOrderDetail).SpecialOfferID =
                    (int)cbSpecialOfferID.SelectedValue;
            };
            #endregion

            #region OrderQty
            this.tbOrderQty.NumericPrecision = 16;
            this.tbOrderQty.NumericScaleOnFocus = 3;
            this.tbOrderQty.NumericScaleOnLostFocus = 2;
            this.tbOrderQty.ZeroIsValid = false;
            this.tbOrderQty.DataBindings.Add("NumericValue",
            this.entity as Wallnut.Domain.Models.SalesOrderDetail,
            "OrderQty",
            true,
            DataSourceUpdateMode.OnPropertyChanged);


            this.tbOrderQty.Validated += (x, y) =>
            {
                CalculateTotalDue();
            };
	        #endregion   

            #region CarrierTrackingNumber


             this.tbCarrierTrackingNumber.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.SalesOrderDetail,
            "CarrierTrackingNumber",
            false,
            DataSourceUpdateMode.OnPropertyChanged);		 
	#endregion

            #region UnitPrice
             this.tbUnitPrice.NumericPrecision = 16;
             this.tbUnitPrice.NumericScaleOnFocus = 2;
             this.tbUnitPrice.NumericScaleOnLostFocus = 2;
             this.tbUnitPrice.ZeroIsValid = false;

             this.tbUnitPrice.DataBindings.Add("NumericValue",
            this.entity as Wallnut.Domain.Models.SalesOrderDetail,
            "UnitPrice",
            true,
            DataSourceUpdateMode.OnPropertyChanged);


	#endregion

            CalculateTotalDue();
        }        
        #endregion

        private void CalculateTotalDue()
        {
            lbLineTotalLoc.Text = string.Format("{0:0.00}", (this.entity as Wallnut.Domain.Models.SalesOrderDetail).LineTotalLoc);
        }


        private void fEdit_Load(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.SalesOrderDetail).SalesOrderID = (int)AddParams[0];
            (this.entity as Wallnut.Domain.Models.SalesOrderDetail).SpecialOfferID = 4;
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbOrderQty.Text))
            {
                e.Cancel = true; tbOrderQty.Focus(); ep.SetError(tbOrderQty, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbOrderQty, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
