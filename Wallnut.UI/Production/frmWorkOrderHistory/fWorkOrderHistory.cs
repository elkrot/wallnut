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






    }
}
