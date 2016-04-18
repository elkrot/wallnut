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
using Wallnut.UI.Production.WorkOrder;
using Wallnut.Utils;

namespace Wallnut.UI.Production.frmWorkOrderHistory
{
    public partial class fWorkOrderHistory : Wallnut.UI.Implementations.ListForm
    {
        public int workOrderID;

        public short operationSequence;

        private static fWorkOrderHistory aForm = null;
        public ListFormBehavior<Wallnut.Domain.Models.WorkOrderHistory, fAddWorkOrderHistory> behavior;

        #region Constructor
        public fWorkOrderHistory()
        {
            behavior = new ListFormBehavior<WorkOrderHistory, fAddWorkOrderHistory>(
                x => x.WorkOrderID == workOrderID && x.OperationSequence == operationSequence, Reread);
            InitializeComponent();
        }        
        #endregion

        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }
        private void fList_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
            behavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            var WorkOrderID = workOrderID;

            var OperationSequence = operationSequence;
            behavior.AddEntity(workOrderID, operationSequence,0);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as WorkOrderHistory;

   var WorkOrderID = entity.WorkOrderID;
   var WorkOrderDetailID = entity.WorkOrderDetailID;
    behavior.UpdateEntity(WorkOrderID, WorkOrderDetailID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as WorkOrderHistory;
            var WorkOrderID = entity.WorkOrderID;
            var WorkOrderDetailID = entity.WorkOrderDetailID;
            behavior.RemoveEntity(WorkOrderID, WorkOrderDetailID);
        }

        public static fWorkOrderHistory Instance(params object[] prm)
        {

            if (aForm == null)
            {
                aForm = new fWorkOrderHistory();
                aForm.workOrderID= (int)prm[0];
                aForm.operationSequence = Convert.ToInt16(prm[1]);
            }
            aForm.behavior.Refresh();
            return aForm;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (aForm.operationSequence == 2)
            {
                OpenEmployeeToWork();
            }
            else {
                OpenBackFromProduction();
            }
            behavior.RefreshData();
        }

        #region OpenBackFromProduction
        private void OpenBackFromProduction()
        {
            var frm = new fBackFromProduction();
            var res = frm.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                if (frm.FormResult != null)
                {
                    using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                    {
                        foreach (var item in frm.FormResult)
                        {

                            #region QtyKernel
                            unitOfWork.WorkOrderHistoryRepository.Add( new WorkOrderHistory()
                            { BusinessEntityID = item.EmployeeId
                                , WorkOrderID = aForm.workOrderID
                                , ProductID = item.ProductId
                                , Qty = item.QtyKernel
                                , ModifiedDate = DateTime.Now
                                , OperationSequence = aForm.operationSequence
                                , ActualStartDate = item.WorkDate
                                , LocationID = Settings.LocationStorehouseId
                                , ActualCost = 10 });
                            #endregion

                            #region QtyShucks
                            unitOfWork.WorkOrderHistoryRepository.Add(new WorkOrderHistory()
                            {   BusinessEntityID = item.EmployeeId
                                , WorkOrderID = aForm.workOrderID
                                , ProductID =Settings.ShucksId
                                , Qty = item.QtyShucks
                                , ModifiedDate = DateTime.Now
                                , OperationSequence = aForm.operationSequence
                                , ActualStartDate = item.WorkDate
                                , LocationID = 1
                                , ActualCost = 10 });                            
                            #endregion

                            #region QtyNuts
                            unitOfWork.WorkOrderHistoryRepository.Add(new WorkOrderHistory()
                            {
                                BusinessEntityID = item.EmployeeId
                                ,  WorkOrderID = aForm.workOrderID
                                , ProductID = Settings.IntaktNutId
                                , Qty = item.QtyNuts
                                , ModifiedDate = DateTime.Now
                                , OperationSequence = aForm.operationSequence
                                , ActualStartDate = item.WorkDate
                                , LocationID = 1
                                , ActualCost = 10
                            });
                            #endregion
                            unitOfWork.Complete();
                        }

                    }
                }
            }
        }
        #endregion
        

        #region OpenEmployeeToWork
         private static void OpenEmployeeToWork()
        {
            var frm = new fEmployeeToWorkCondition();
            var res = frm.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                if (frm.FormResult != null)
                {
                    using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                    {
                        foreach (var item in frm.FormResult)
                        {
                            unitOfWork.WorkOrderHistoryRepository.Add(
                            new WorkOrderHistory()
                            {
                                BusinessEntityID = item.EmployeeId
                                ,
                                WorkOrderID = aForm.workOrderID
                                ,
                                ProductID = item.ProductId
                                ,
                                Qty = item.Qty
                                ,
                                ModifiedDate = DateTime.Now
                                ,
                                OperationSequence = aForm.operationSequence
                                ,
                                ActualStartDate = item.WorkDate
                                ,
                                LocationID = Settings.LocationWorkshopId
                                ,
                                ActualCost = 10
                            });
                            unitOfWork.Complete();
                        }

                    }
                }
            }
        #endregion
       
        }






    }
}
