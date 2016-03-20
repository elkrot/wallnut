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
using Wallnut.UI.Sales.SalesOrderDetail;

namespace Wallnut.UI.Sales.SalesOrderHeader
{
    public partial class fSalesOrderHeader : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Wallnut.Domain.Models.SalesOrderHeader, fAddSalesOrderHeader> behavior;
        public ListFormBehavior<Wallnut.Domain.Models.SalesOrderDetail, fAddSalesOrderDetail> detailBehavior;
        private static fSalesOrderHeader aForm = null;
        private fSalesOrderHeader()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.SalesOrderHeader, 
                fAddSalesOrderHeader>(x => true, Reread);
            detailBehavior = new ListFormBehavior<Wallnut.Domain.Models.SalesOrderDetail
 , fAddSalesOrderDetail>(x => true, Reread);
            InitializeComponent();
        }
        #region RereadData
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
            DetailReread();
        }

        public void DetailReread()
        {
            if (dgv.RowCount > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesOrderHeader;
                int SalesOrderId = entity.SalesOrderID;

                detailBehavior.Predicate = (x => x.SalesOrderID == SalesOrderId);
                if (detailBehavior.EntityList != null)
                {
                    detailBehavior.Refresh();
                    bsDetail.DataSource = detailBehavior.EntityList.ToList();
                }
            }
        }
        #endregion
        private void fList_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
            behavior.RefreshData();
            detailBehavior.RefreshData();
        }
        public static fSalesOrderHeader Instance()
        {
            if (aForm == null)
            {
                aForm = new fSalesOrderHeader();
            }
            return aForm;
        }
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
          behavior.AddEntity();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
  
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesOrderHeader;
            int SalesOrderID = entity.SalesOrderID;
            behavior.UpdateEntity(SalesOrderID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesOrderHeader;
            int SalesOrderID = entity.SalesOrderID;
            behavior.RemoveEntity(SalesOrderID);
        }


        private void tsbAddDetail_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesOrderHeader;
            int SalesOrderId = entity.SalesOrderID;

            detailBehavior.AddEntity(SalesOrderId);
        }

        private void tsbEditDetail_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesOrderHeader;
            int SalesOrderId = entity.SalesOrderID;
            var detailEntity = dgvDetail.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesOrderDetail;
            int SalesOrderDetailID = detailEntity.SalesOrderDetailID;
            detailBehavior.UpdateEntity(SalesOrderId, SalesOrderDetailID);
        }

        private void tsbDeleteDetail_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesOrderHeader;
            int SalesOrderId = entity.SalesOrderID;
            var detailEntity = dgvDetail.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalesOrderDetail;
            int SalesOrderDetailID = detailEntity.SalesOrderDetailID;
            detailBehavior.RemoveEntity(SalesOrderId, SalesOrderDetailID);
        }

  








    }
}
