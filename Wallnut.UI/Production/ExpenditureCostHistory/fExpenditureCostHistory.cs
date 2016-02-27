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

namespace Wallnut.UI.Production.ExpenditureCostHistory
{
    public partial class fExpenditureCostHistory : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Wallnut.Domain.Models.ExpenditureCostHistory
            , fAddExpenditureCostHistory> behavior;
        public fExpenditureCostHistory()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.ExpenditureCostHistory
                , fAddExpenditureCostHistory>(x => true, Reread);
            InitializeComponent();
        }
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }
        private void fList_Load(object sender, EventArgs e)
        {
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








    }
}
