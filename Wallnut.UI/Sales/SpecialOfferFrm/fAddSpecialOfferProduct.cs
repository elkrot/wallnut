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

namespace Wallnut.UI.Sales.SpecialOfferFrm
{
    public partial class fAddSpecialOfferProduct : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Product> ProductList;
        public List<Wallnut.Domain.Models.SpecialOffer> SpecialOfferList;

        public fAddSpecialOfferProduct()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            #region Fill ProductList
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.ProductList = unitOfWork.ProductsRepository
                    .GetAll().ToList<Product>();
                cbProductID.DataSource = ProductList;
                foreach (var item in ProductList)
                {
                    cbProductID.AutoCompleteCustomSource.Add(item.Name);
                }
            }
            #endregion

            #region Binding Product
            var productID = (this.entity as Wallnut.Domain.Models.SpecialOfferProduct).ProductID;
            cbProductID.ValueMember = "ProductID";
            cbProductID.DisplayMember = "Name";
            cbProductID.SelectedValue = productID;
            (this.entity as Wallnut.Domain.Models.SpecialOfferProduct).ProductID = productID;
            cbProductID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SpecialOfferProduct).ProductID =
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
            var SpecialOfferID = (this.entity as Wallnut.Domain.Models.SpecialOfferProduct).SpecialOfferID;
            cbSpecialOfferID.ValueMember = "SpecialOfferID";
            cbSpecialOfferID.DisplayMember = "Description";
            cbSpecialOfferID.SelectedValue = SpecialOfferID;
            (this.entity as Wallnut.Domain.Models.SpecialOfferProduct).SpecialOfferID = SpecialOfferID;
            cbSpecialOfferID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.SpecialOfferProduct).SpecialOfferID =
                    (int)cbSpecialOfferID.SelectedValue;
            };
            #endregion
        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {

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
