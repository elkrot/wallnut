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

namespace Wallnut.UI.Sales.SalesTerritory
{
    public partial class fSalesTerritory : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Wallnut.Domain.Models.SalesTerritory, fAddSalesTerritory> behavior;
        public fSalesTerritory()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.SalesTerritory, fAddSalesTerritory>(x => true, Reread);
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
           behavior.RefreshData();
        }
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesTerritory;
            int TerritoryID = entity.TerritoryID;
            behavior.UpdateEntity(TerritoryID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesTerritory;
            int TerritoryID = entity.TerritoryID;
             behavior.RemoveEntity(TerritoryID);
        }

        private void bn_RefreshItems(object sender, EventArgs e)
        {

        }








    }
}
