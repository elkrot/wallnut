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

namespace Wallnut.UI.Production.ProductListPriceHistory
{
    public partial class fProductListPriceHistory : Wallnut.UI.Implementations.ListForm
    {
        public int productID { get; set; }
        public ListFormBehavior<Wallnut.Domain.Models.ProductListPriceHistory,
            fAddProductListPriceHistory> behavior;
        public fProductListPriceHistory()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.ProductListPriceHistory,
                fAddProductListPriceHistory>(x => x.ProductID == productID, Reread);
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
            var StartDate = 
                DateTime.Now;
            behavior.AddEntity(productID, StartDate);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ProductListPriceHistory;
            int ProductID = entity.ProductID;
            DateTime StartDate = entity.StartDate;
            behavior.UpdateEntity(ProductID, StartDate);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ProductListPriceHistory;
            int ProductID = entity.ProductID;
            DateTime StartDate = entity.StartDate;
            behavior.RemoveEntity(ProductID, StartDate);
        }








    }
}
