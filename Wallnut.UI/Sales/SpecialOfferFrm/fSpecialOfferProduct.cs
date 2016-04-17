using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.UI.Implementations;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Implementations;

namespace Wallnut.UI.Sales.SpecialOfferFrm
{
    public partial class fSpecialOfferProduct : Wallnut.UI.Implementations.ListForm
    {
        
        public fSpecialOfferProduct()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<SpecialOfferProduct>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddSpecialOfferProduct, SpecialOfferProduct>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SpecialOfferProduct;
            int id = entity.SpecialOfferID;
            int pid = entity.ProductID;
            UpdateEntity<fAddSpecialOfferProduct, SpecialOfferProduct>(id, pid);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SpecialOfferProduct;
            int id = entity.SpecialOfferID;
            int pid = entity.ProductID;
            RemoveEntity<SpecialOfferProduct>(id, pid);
        }








    }
}
