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

namespace Wallnut.UI.HumanResources.frmEmployeeRole
{
    public partial class fEmployeeRole : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<EmployeeRole, fAddEmployeeRole> behavior;
        public int employeeID;
        public fEmployeeRole()
        {
            behavior = new ListFormBehavior<EmployeeRole, fAddEmployeeRole>(x=>x.EmployeeID==employeeID, Reread);
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
            behavior.AddEntity(employeeID);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as EmployeeRole;
            int id = entity.EmployeeID;
            int RoleId = entity.RoleID;
            behavior.UpdateEntity(id,RoleId);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as EmployeeRole;
            int id = entity.EmployeeID;
            int RoleId = entity.RoleID;
            behavior.RemoveEntity(id, RoleId);
        }








    }
}
