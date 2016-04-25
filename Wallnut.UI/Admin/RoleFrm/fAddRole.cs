using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI.Admin.RoleFrm
{
    public partial class fAddRole : Wallnut.UI.Implementations.AddForm
    {
        public fAddRole()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            this.tbRoleTitle.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Role,
            "RoleTitle",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRoleTitle.Text))
            {
                e.Cancel = true; tbRoleTitle.Focus(); ep.SetError(tbRoleTitle, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbRoleTitle, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}
