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

namespace Wallnut.UI.Production.frmProductInventory
{
    public partial class fAddProductInventory : Wallnut.UI.Implementations.AddForm
    {
        public List<Wallnut.Domain.Models.Product> ProductList;
        public List<Wallnut.Domain.Models.Location> LocationList;

       // private int productID { get; set; }
       // private int locationID { get; set; }

        public fAddProductInventory()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            #region Bin
            this.tbBin.DataBindings.Add("Text",
            this.entity as ProductInventory,
            "Bin",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region Shelf
            this.tbShelf.DataBindings.Add("Text",
            this.entity as ProductInventory,
            "Shelf",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region Quantity
            this.tbQuantity.DataBindings.Add("Text",
            this.entity as ProductInventory,
            "Quantity",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region Fill Lists
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.ProductList = unitOfWork.ProductsRepository.GetAll().ToList<Wallnut.Domain.Models.Product>();
                cbProductID.DataSource = ProductList;

                foreach (var item in ProductList)
                {
                    cbProductID.AutoCompleteCustomSource.Add(item.Name);
                }


                this.LocationList = unitOfWork.LocationRepository.GetAll().ToList<Wallnut.Domain.Models.Location>();
                cbLocationID.DataSource = LocationList;

            }
            #endregion

            #region Binding Product
            var productID = (this.entity as Wallnut.Domain.Models.ProductInventory).ProductID;
            cbProductID.ValueMember = "ProductID";
            cbProductID.DisplayMember = "Name";
            cbProductID.SelectedValue = productID;
            (this.entity as Wallnut.Domain.Models.ProductInventory).ProductID = productID;
            cbProductID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.ProductInventory).ProductID =
                    (int)cbProductID.SelectedValue;
            };
            #endregion

            #region Binding Location
            var locationID = (this.entity as Wallnut.Domain.Models.ProductInventory).LocationID;
            cbLocationID.ValueMember = "LocationID";
            cbLocationID.DisplayMember = "Name";
            cbLocationID.SelectedValue = locationID;
            (this.entity as Wallnut.Domain.Models.ProductInventory).LocationID = locationID;
            cbLocationID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.ProductInventory).LocationID =
                    (short)cbLocationID.SelectedValue;
            };
            #endregion
        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbShelf.Text))
            {
                e.Cancel = true; tbShelf.Focus(); ep.SetError(tbShelf, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbShelf, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.ProductInventory).ModifiedDate = DateTime.Now;

            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
