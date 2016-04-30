using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Implementations;

namespace Wallnut.UI.HumanResources.frmEmployeeRole
{
    public partial class fAddEmployeeRole : Wallnut.UI.Implementations.AddForm
    {
        private List<Wallnut.Domain.Models.Role> RoleList;

        public fAddEmployeeRole()
        {

            InitializeComponent();
        }
        #region BindingData
        private void BindingData()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.RoleList = unitOfWork.RoleRepository.GetAll()
                .ToList<Wallnut.Domain.Models.Role>();
                cbRoleID.DataSource = RoleList;
            }

            cbRoleID.ValueMember = "BusinessEntityID";
            cbRoleID.DisplayMember = "RoleTitle";

            cbRoleID.SelectedValue = (this.entity as Wallnut.Domain.Models.EmployeeRole).RoleID;
            cbRoleID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.EmployeeRole).RoleID = (int)cbRoleID.SelectedValue;

            };
        }
        #endregion
        

        private void fEdit_Load(object sender, EventArgs e)
        {
                        if (this.AddParams!=null)
            {
               (this.entity as Wallnut.Domain.Models.EmployeeRole).EmployeeID = (int) this.AddParams[0];
            }
           
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
           /* if (string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true; tbName.Focus(); ep.SetError(tbName, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbName, "");
            }*/
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
