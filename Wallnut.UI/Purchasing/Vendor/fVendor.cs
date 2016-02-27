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

namespace Wallnut.UI.Purchasing.Vendor
{
    public partial class fVendor : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Wallnut.Domain.Models.Vendor, fAddVendor> behavior;
        public fVendor()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.Vendor,
                  fAddVendor>(x => true, Reread);
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
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Vendor;
            int BusinessEntityID = entity.BusinessEntityID;
            behavior.UpdateEntity(BusinessEntityID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Vendor;
            int BusinessEntityID = entity.BusinessEntityID;
            behavior.RemoveEntity(BusinessEntityID);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetModifiedDate();
        }

        private void SetModifiedDate()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Vendor;
                DateTime mDate = entity.ModifiedDate;
                ss.Items[0].Text = string.Format("{0}", mDate);
            }
        }

        private void dgv_DockChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_LocationChanged(object sender, EventArgs e)
        {
    
        }








    }
}
