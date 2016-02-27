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

namespace Wallnut.UI.Purchasing.ProductVendor
{
    public partial class fProductVendor : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Wallnut.Domain.Models.ProductVendor, fAddProductVendor> behavior;
        public fProductVendor()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.ProductVendor,
                  fAddProductVendor>(x => true, Reread);
            InitializeComponent();
            behavior.RefreshData();
        }
        public void Reread()
        {
            bs.DataSource = behavior.EntityList;
        }
        private void fList_Load(object sender, EventArgs e)
        {
            behavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ProductVendor;
            int ProductID=entity.ProductID;
            int BusinessEntityID = entity.BusinessEntityID;
            behavior.UpdateEntity(ProductID, BusinessEntityID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ProductVendor;
            int ProductID = entity.ProductID;
            int BusinessEntityID = entity.BusinessEntityID;
            behavior.RemoveEntity(ProductID, BusinessEntityID);
        }








    }
}
