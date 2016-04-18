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
using Wallnut.UI.Production.frmWorkOrderHistory;
using System.Linq.Expressions;
using Wallnut.Domain.Entities;

namespace Wallnut.UI.Production.WorkOrder
{
    public partial class fWorkOrder : Wallnut.UI.Implementations.ListForm
    {
        private static fWorkOrder aForm = null;
        
        public ListFormBehavior<Wallnut.Domain.Models.WorkOrder, fAddWorkOrder> behavior;

        private fWorkOrder()
        {
            fWorkOrderCondition frm = new fWorkOrderCondition();
            frm.DataSource = new WorkOrderCondition();
            (frm.DataSource as WorkOrderCondition).DateFirst = DateTime.Now.AddDays(-DateTime.Now.Day);
            (frm.DataSource as WorkOrderCondition).DateLast = DateTime.Now.AddDays(1);

            behavior = new ListFormBehavior<Wallnut.Domain.Models.WorkOrder,
                fAddWorkOrder>(Reread, frm, GetPredicate);


            InitializeComponent();
        }

        public Expression<Func<Wallnut.Domain.Models.WorkOrder, bool>> GetPredicate(object src)
        {
            WorkOrderCondition cond = (src as WorkOrderCondition);
            return cond.GetCondition();
        }


        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }
        private void fList_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
            behavior.UpdateCondition();
            behavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.WorkOrder;
                int id = entity.WorkOrderID;
                behavior.UpdateEntity(id);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.WorkOrder;
                int id = entity.WorkOrderID;
                behavior.RemoveEntity(id);
            }
        }

        public static fWorkOrder Instance()
        {
            if (aForm == null)
            {
                aForm = new fWorkOrder();
            }
            return aForm;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.WorkOrder;
                int workorderid = entity.WorkOrderID;
                fWorkOrderHistory f = fWorkOrderHistory.Instance(workorderid, 1);

                f.MdiParent = this.MdiParent;

                f.Show();
                f.Activate();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.WorkOrder;
                int workorderid = entity.WorkOrderID;
                fWorkOrderHistory f = fWorkOrderHistory.Instance(workorderid, 2);

                f.MdiParent = this.MdiParent;

                f.Show();
                f.Activate();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            behavior.UpdateCondition();
            behavior.RefreshData();

        }






    }
}
