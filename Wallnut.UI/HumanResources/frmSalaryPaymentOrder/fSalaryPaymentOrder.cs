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
using Wallnut.UI.Sales.SalesOrderHeader;
using Wallnut.Domain.Entities;
using System.Linq.Expressions;

namespace Wallnut.UI.HumanResources.frmSalaryPaymentOrder
{
    public partial class fSalaryPaymentOrder : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<SalaryPaymentOrder, fAddSalaryPaymentOrder> behavior;
        public ListFormBehavior<SalaryPaymentHistory, fAddSalaryPaymentHistory> detailBehavior;
        public fSalaryPaymentOrder()
        {
            fSalaryPaymentCondition frm = new fSalaryPaymentCondition();
            frm.DataSource = new SalaryPaymentCondition();
            (frm.DataSource as SalaryPaymentCondition).DateFirst = DateTime.Now.AddDays(-DateTime.Now.Day);
            (frm.DataSource as SalaryPaymentCondition).DateLast = DateTime.Now.AddDays(1);

            behavior = new ListFormBehavior<SalaryPaymentOrder, fAddSalaryPaymentOrder>
                (Reread, frm, GetPredicate);

            detailBehavior = new ListFormBehavior<SalaryPaymentHistory
                , fAddSalaryPaymentHistory>(x => false, Reread);
            InitializeComponent();
        }

        public Expression<Func<SalaryPaymentOrder, bool>> GetPredicate(object src)
        {
            SalaryPaymentCondition cond = (src as SalaryPaymentCondition);
            return cond.GetCondition();
        }

        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
            dgv.DataSource = bs;
            DetailReread();
        }

        public void DetailReread()
        {
            if ((bs.DataSource as List<Wallnut.Domain.Models.SalaryPaymentOrder>).Count > 0)
            {
                var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalaryPaymentOrder;
                int SalaryPaymentOrderID = entity.SalaryPaymentOrderID;

                detailBehavior.Predicate = (x => x.SalaryPaymentOrderID == SalaryPaymentOrderID);
                if (detailBehavior.EntityList != null)
                {
                    detailBehavior.Refresh();
                    bsdetail.DataSource = detailBehavior.EntityList.ToList();
                }
            }
        }


        private void fList_Load(object sender, EventArgs e)
        {
            behavior.UpdateCondition();
            behavior.RefreshData();
            detailBehavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as SalaryPaymentOrder;
            int id = entity.SalaryPaymentOrderID;
            behavior.UpdateEntity(id);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as SalaryPaymentOrder;
            int id = entity.SalaryPaymentOrderID;
            behavior.RemoveEntity(id);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            behavior.UpdateCondition();
            behavior.RefreshData();
            detailBehavior.RefreshData();
        }

        private void tsbAddDetail_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as SalaryPaymentOrder;
            int id = entity.SalaryPaymentOrderID;
            detailBehavior.AddEntity(id);
        }

        private void tsbEditDetail_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as SalaryPaymentOrder;
            int id = entity.SalaryPaymentOrderID;

            var detailEntity = dgvDetail.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.SalaryPaymentHistory;
            int DetailID = detailEntity.EmployeeID;

            behavior.UpdateEntity(id, DetailID);
        }

        private void bs_CurrentChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0)
            {
                DetailReread();
            }
        }








    }
}
