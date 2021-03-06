﻿using System;
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
using System.Linq.Expressions;
using Wallnut.Domain.Entities;

namespace Wallnut.UI.Sales.SalesOrderHeader
{
    public partial class fSalesOrderHeader : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Wallnut.Domain.Models.SalesOrderHeader, fAddSalesOrderHeader> behavior;
        public ListFormBehavior<Wallnut.Domain.Models.SalesOrderDetail, fAddSalesOrderDetail> detailBehavior;
        private static fSalesOrderHeader aForm = null;
        private fSalesOrderHeader()
        {
            fSalesCondition frm = new fSalesCondition();
            frm.DataSource = new SalesCondition();
            (frm.DataSource as SalesCondition).DateFirst = DateTime.Now.AddDays(-DateTime.Now.Day);
            (frm.DataSource as SalesCondition).DateLast = DateTime.Now.AddDays(1);

            behavior = new ListFormBehavior<Wallnut.Domain.Models.SalesOrderHeader, 
                fAddSalesOrderHeader>(Reread, frm,  GetPredicate);

            detailBehavior = new ListFormBehavior<Wallnut.Domain.Models.SalesOrderDetail
                , fAddSalesOrderDetail>(x => false, Reread);
            InitializeComponent();
        }

        public Expression<Func<Wallnut.Domain.Models.SalesOrderHeader, bool>> GetPredicate(object src)
        {
            
            SalesCondition cond = (src as SalesCondition);
            return cond.GetCondition();

        }
        #region RereadData
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
            dgv.DataSource = bs;
            dgv.Refresh();
            
            DetailReread();
        }

        public void DetailReread()
        {
            if ((bs.DataSource as List< Wallnut.Domain.Models.SalesOrderHeader>).Count > 0)
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
            behavior.UpdateCondition();
            behavior.RefreshData();
           // detailBehavior.RefreshData();
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

        private void bs_CurrentChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0)
            {
                DetailReread();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            behavior.UpdateCondition();
            behavior.RefreshData();
            detailBehavior.RefreshData();
        }

        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*if (dgv.SortOrder.ToString() == "Ascending") // Check if sorting is Ascending
            {
                dgv.Sort(dgv.Columns[dgv.SortedColumn.Name], ListSortDirection.Descending);
            }
            else
            {
                dgv.Sort(dgv.Columns[dgv.SortedColumn.Name], ListSortDirection.Ascending);
            }*/
        }













    }
}
