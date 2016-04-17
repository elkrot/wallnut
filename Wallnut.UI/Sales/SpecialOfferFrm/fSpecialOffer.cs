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
    public partial class fSpecialOffer : Wallnut.UI.Implementations.ListForm
    {
        public fSpecialOffer()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<SpecialOffer>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddSpecialOffer, SpecialOffer>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as SpecialOffer;
            int id = entity.SpecialOfferID;
            UpdateEntity<fAddSpecialOffer, SpecialOffer>(id);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as SpecialOffer;
            int id = entity.SpecialOfferID;
            RemoveEntity<SpecialOffer>(id);
        }








    }
}
