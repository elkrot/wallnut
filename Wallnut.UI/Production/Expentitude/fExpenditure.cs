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

namespace Wallnut.UI.Production.Expentitude
{
    public partial class fExpenditure : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Expenditure, fAddExpenditure> behavior;
        public fExpenditure()
        {
            behavior = new ListFormBehavior<Expenditure, fAddExpenditure>(X=>true, Reread);
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
            behavior.AddEntity();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Expenditure;
            int id = entity.ExpenditureID;
            behavior.UpdateEntity(id);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Expenditure;
            int id = entity.ExpenditureID;
            behavior.RemoveEntity(id);
        }








    }
}
