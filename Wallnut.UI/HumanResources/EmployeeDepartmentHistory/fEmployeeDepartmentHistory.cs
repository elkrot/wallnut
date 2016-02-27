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

namespace Wallnut.UI.HumanResources.EmployeeDepartmentHistory
{
    public partial class fEmployeeDepartmentHistory : Wallnut.UI.Implementations.ListForm
    {
        public int employeeID { get; set; }
        public ListFormBehavior<Wallnut.Domain.Models.EmployeeDepartmentHistory, fAddEmployeeDepartmentHistory> behavior;
        public fEmployeeDepartmentHistory()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.EmployeeDepartmentHistory,
                fAddEmployeeDepartmentHistory>(x => x.BusinessEntityID == employeeID, Reread);
            InitializeComponent();
            behavior.RefreshData();
        }
        public void Reread()
        {
            bs.DataSource = behavior.EntityList;
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
            if (dgv.SelectedRows[0].DataBoundItem != null)
            {
            
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.EmployeeDepartmentHistory;
            int BusinessEntityID = entity.BusinessEntityID;
            int DepartmentID = entity.DepartmentID;
            int ShiftID = entity.ShiftID;
            DateTime StartDate = entity.StartDate;
            behavior.UpdateEntity(
                BusinessEntityID, DepartmentID, ShiftID, StartDate);
        }
    }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.EmployeeDepartmentHistory;
            int BusinessEntityID = entity.BusinessEntityID;
            int DepartmentID = entity.DepartmentID;
            int ShiftID = entity.ShiftID;
            DateTime StartDate = entity.StartDate;
            behavior.RemoveEntity(BusinessEntityID, DepartmentID, ShiftID, StartDate);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }








    }
}
