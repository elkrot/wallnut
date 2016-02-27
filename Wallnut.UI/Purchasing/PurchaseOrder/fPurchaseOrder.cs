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

namespace Wallnut.UI.Purchasing.PurchaseOrder
{
    public partial class fPurchaseOrder : Wallnut.UI.Implementations.ListForm
    {
        private static fPurchaseOrder aForm = null;
        public ListFormBehavior<Wallnut.Domain.Models.PurchaseOrderHeader, fAddPurchaseOrder> behavior;
        public ListFormBehavior<Wallnut.Domain.Models.PurchaseOrderDetail, fAddPurchaseOrderDetail> detailBehavior;
        #region Constructor
        private fPurchaseOrder()
        {

            behavior = new ListFormBehavior<Wallnut.Domain.Models.PurchaseOrderHeader
                , fAddPurchaseOrder>(x => true, Reread);
            detailBehavior = new ListFormBehavior<Wallnut.Domain.Models.PurchaseOrderDetail
       , fAddPurchaseOrderDetail>(x => true, Reread);
            InitializeComponent();
        }
        #endregion

        #region RereadData
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
            DetailReread();
        }

        public void DetailReread()
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.PurchaseOrderHeader;
            int PurchaseOrderId = entity.PurchaseOrderID;

            detailBehavior.Predicate = (x => x.PurchaseOrderID == PurchaseOrderId);
            if (detailBehavior.EntityList != null)
            {
                detailBehavior.Refresh();
                bsDetail.DataSource = detailBehavior.EntityList.ToList();
            }
        }
        #endregion

        #region Instance
        public static fPurchaseOrder Instance()
        {
            if (aForm == null)
            {
                aForm = new fPurchaseOrder();
            }
            return aForm;
        }        
        #endregion

        #region fList_Load
        private void fList_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
            behavior.RefreshData();
            detailBehavior.RefreshData();
        }        
        #endregion

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddPurchaseOrder();
        }

        #region AddPurchaseOrder
        private void AddPurchaseOrder()
        {
            behavior.AddEntity();
        }        
        #endregion


        private void tsbEdit_Click(object sender, EventArgs e)
        {
            EditPurchaseOrderHeader();
        }

        #region EditPurchaseOrderHeader
        private void EditPurchaseOrderHeader()
        {
            if (dgv.RowCount > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.PurchaseOrderHeader;
                int id = entity.PurchaseOrderID;
                behavior.UpdateEntity(id);
            }
        }        
        #endregion


        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DeleteFromPurchaseOrderHeader();
        }

        #region DeleteFromPurchaseOrderHeader
        private void DeleteFromPurchaseOrderHeader()
        {
            if (dgv.RowCount > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.PurchaseOrderHeader;
                int id = entity.PurchaseOrderID;
                behavior.RemoveEntity(id);
            }
        }        
        #endregion


        private void tsbAddDetail_Click(object sender, EventArgs e)
        {
            AddPurshaseOrderDetail();
        }

        #region AddPurshaseOrderDetail
        private void AddPurshaseOrderDetail()
        {
            if (dgv.RowCount > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.PurchaseOrderHeader;
                int PurchaseOrderId = entity.PurchaseOrderID;

                detailBehavior.AddEntity(PurchaseOrderId);
            }
        }        
        #endregion


        private void tsbEditDetail_Click(object sender, EventArgs e)
        {
            EditPurshaseOrderDetail();
        }

        #region EditPurshaseOrderDetail
        private void EditPurshaseOrderDetail()
        {
            if (dgv.RowCount > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.PurchaseOrderHeader;
                int PurchaseOrderId = entity.PurchaseOrderID;
                var detailEntity = dgvDetail.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.PurchaseOrderDetail;
                int PurchaseOrderDetailID = detailEntity.PurchaseOrderDetailID;
                detailBehavior.UpdateEntity(PurchaseOrderId, PurchaseOrderDetailID);
            }
        }        
        #endregion


        private void tsbDeleteDetail_Click(object sender, EventArgs e)
        {
            DeleteFromPurchaseOrderDetail();
        }

        #region DeleteFromPurchaseOrderDetail
        private void DeleteFromPurchaseOrderDetail()
        {
            if (dgv.RowCount > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.PurchaseOrderHeader;
                int PurchaseOrderId = entity.PurchaseOrderID;
                var detailEntity = dgvDetail.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.PurchaseOrderDetail;
                int PurchaseOrderDetailID = detailEntity.PurchaseOrderDetailID;
                detailBehavior.RemoveEntity(PurchaseOrderId, PurchaseOrderDetailID);
            }
        }        
        #endregion


        #region Перечитка деталей
        private void bs_CurrentChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0)
            {
                DetailReread();
            }
        }        
        #endregion


        #region Перехват горячих клавиш.
         private void fPurchaseOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control )
            {
                // Purshase Order Detail
                switch (e.KeyCode)
                {
                    case Keys.F4: EditPurshaseOrderDetail();
                        break;
                    case Keys.F7:AddPurshaseOrderDetail();
                        break;
                    case Keys.F8: DeleteFromPurchaseOrderDetail();
                        break;
                    case Keys.F9:
                        break;
                   
                    default:
                        break;
                }
            }
            else
                if (e.KeyCode == Keys.F7)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.F4: EditPurchaseOrderHeader();
                            break;
                        case Keys.F7: AddPurchaseOrder();
                            break;
                        case Keys.F8: DeleteFromPurchaseOrderHeader();
                            break;
                        case Keys.F9:
                            break;
                        case Keys.Escape: this.Close();
                            break;
                        default:
                            break;
                    }
                }
        }
        #endregion

         private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             EditPurchaseOrderHeader();
         }

         private void dgvDetail_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             EditPurshaseOrderDetail();
         }
       








    }
}
