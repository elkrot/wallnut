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

namespace Wallnut.UI.Sales.SalesPerson
{
    public partial class fSalesPerson : Wallnut.UI.Implementations.ListForm
    {
        public fSalesPerson()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Wallnut.Domain.Models.SalesPerson>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddSalesPerson, Wallnut.Domain.Models.SalesPerson>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesPerson;
            int BusinessEntityID = entity.BusinessEntityID;
            UpdateEntity<fAddSalesPerson, Wallnut.Domain.Models.SalesPerson>(BusinessEntityID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesPerson;
            int BusinessEntityID = entity.BusinessEntityID;
            RemoveEntity<Wallnut.Domain.Models.SalesPerson>(BusinessEntityID);
        }








    }
}
