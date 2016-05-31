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

namespace Wallnut.UI.HumanResources.EmployeePayHistory
{
    public partial class fEmployeePayHistory : Wallnut.UI.Implementations.ListForm
    {
        public int employeeID { get; set; }
        public ListFormBehavior<Wallnut.Domain.Models.EmployeePayHistory, fAddEmployeePayHistory> behavior;
        public fEmployeePayHistory()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.EmployeePayHistory,
               fAddEmployeePayHistory>(x => x.BusinessEntityID == employeeID, Reread);
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
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.EmployeePayHistory;
            int BusinessEntityID = entity.BusinessEntityID;
            DateTime RateChangeDate = entity.RateChangeDate;
            behavior.UpdateEntity(BusinessEntityID, RateChangeDate);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.EmployeePayHistory;
            int BusinessEntityID = entity.BusinessEntityID;
            DateTime RateChangeDate = entity.RateChangeDate;
            behavior.RemoveEntity(BusinessEntityID, RateChangeDate);
        }








    }
}
