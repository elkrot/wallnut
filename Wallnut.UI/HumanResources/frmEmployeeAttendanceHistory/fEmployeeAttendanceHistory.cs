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

namespace Wallnut.UI.HumanResources.frmEmployeeAttendanceHistory
{
    public partial class fEmployeeAttendanceHistory : Wallnut.UI.Implementations.ListForm
    {
        private static fEmployeeAttendanceHistory aForm = null;
        public ListFormBehavior<EmployeeAttendanceHistory, fAddEmployeeAttendanceHistory> behavior;
        private fEmployeeAttendanceHistory()
        {
            behavior = new ListFormBehavior<EmployeeAttendanceHistory, fAddEmployeeAttendanceHistory>(x=>true, Reread);
            InitializeComponent();
        }
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }
        private void fList_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
            behavior.RefreshData();
            behavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
          var entity = dgv.SelectedRows[0].DataBoundItem as EmployeeAttendanceHistory;
          int id = entity.BusinessEntityID;
          DateTime startdate = entity.StartDate;
            behavior.UpdateEntity(id,startdate);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as EmployeeAttendanceHistory;
            int id = entity.BusinessEntityID;
            DateTime startdate = entity.StartDate;
            behavior.RemoveEntity(id, startdate);
        }



        public static fEmployeeAttendanceHistory Instance()
        {
            if (aForm == null)
            {
                aForm = new fEmployeeAttendanceHistory();
            }
            return aForm;
        }




    }
}
