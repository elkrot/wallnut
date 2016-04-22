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

namespace Wallnut.UI.Admin.RoleFrm
{
    public partial class fRole : Wallnut.UI.Implementations.ListForm
    {
        public fRole()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Role>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<AddForm, object>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Role;
            var id = entity.BusinessEntityID;
            UpdateEntity<fAddRole, Role>(id);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Role;
            var id = entity.BusinessEntityID;
            RemoveEntity<Role>(id);
        }








    }
}
