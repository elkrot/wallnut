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
using Wallnut.Domain.Entities;
using System.Linq.Expressions;

namespace Wallnut.UI.Production.ExpenditureCostHistory
{
    public partial class fExpenditureCostHistory : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Wallnut.Domain.Models.ExpenditureCostHistory
            , fAddExpenditureCostHistory> behavior;
        public fExpenditureCostHistory()
        {
            fExpenditureCostHistoryCondition frm = new fExpenditureCostHistoryCondition();
            frm.DataSource = new ExpenditureCostHistoryCondition();
            (frm.DataSource as ExpenditureCostHistoryCondition).DateFirst = DateTime.Now.AddDays(-DateTime.Now.Day);
            (frm.DataSource as ExpenditureCostHistoryCondition).DateLast = DateTime.Now.AddDays(1);

            behavior = new ListFormBehavior<Wallnut.Domain.Models.ExpenditureCostHistory,
                fAddExpenditureCostHistory>(Reread, frm, GetPredicate);



            InitializeComponent();
        }

        public Expression<Func<Wallnut.Domain.Models.ExpenditureCostHistory, bool>> GetPredicate(object src)
        {
            ExpenditureCostHistoryCondition cond = (src as ExpenditureCostHistoryCondition);
            return cond.GetCondition();
        }


        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }
        private void fList_Load(object sender, EventArgs e)
        {
            behavior.UpdateCondition();
            behavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity(0,DateTime.Now);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ExpenditureCostHistory;
            int id = entity.ExpenditureID;
            DateTime StartDate = entity.StartDate;
            behavior.UpdateEntity(id, StartDate);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ExpenditureCostHistory;
            int id = entity.ExpenditureID;
            DateTime StartDate = entity.StartDate;
            behavior.RemoveEntity(id, StartDate);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            behavior.UpdateCondition();
            behavior.RefreshData();
        }








    }
}
