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

namespace Wallnut.UI.Production.frmWorkOrderHistory
{
    public partial class fWorkOrderHistory : Wallnut.UI.Implementations.ListForm
    {
        public int workOrderID;

        public short operationSequence;

        private static fWorkOrderHistory aForm = null;
        public ListFormBehavior<Wallnut.Domain.Models.WorkOrderHistory, fAddWorkOrderHistory> behavior;
        public fWorkOrderHistory()
        {
            behavior = new ListFormBehavior<WorkOrderHistory, fAddWorkOrderHistory>(
                x => x.WorkOrderID == workOrderID 
                        && x.OperationSequence == operationSequence
                , Reread);
            InitializeComponent();
        }
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
            behavior.AddEntity(workOrderID, operationSequence);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as WorkOrderHistory;

   var WorkOrderID = entity.WorkOrderID;
	var ProductID = entity.ProductID;
	var BusinessEntityID = entity.BusinessEntityID;
    var OperationSequence = entity.OperationSequence;

    var ActualStartDate = entity.ActualStartDate;
    behavior.UpdateEntity(WorkOrderID, ProductID, BusinessEntityID, OperationSequence
        , ActualStartDate);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as WorkOrderHistory;
            var WorkOrderID = entity.WorkOrderID;
            var ProductID = entity.ProductID;
            var BusinessEntityID = entity.BusinessEntityID;
            var OperationSequence = entity.OperationSequence;
            
            var ActualStartDate = entity.ActualStartDate;
            behavior.RemoveEntity(WorkOrderID, ProductID, BusinessEntityID, OperationSequence
        , ActualStartDate);
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
                                    LocationID = 1
                                    ,
                                    ActualCost = 10
                                });
                                unitOfWork.Complete();
                            }

                        }
                    }
                }
            }
            behavior.RefreshData();
        }






    }
}
