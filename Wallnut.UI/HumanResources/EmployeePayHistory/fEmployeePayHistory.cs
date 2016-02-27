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
        public fEmployeePayHistory()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Wallnut.Domain.Models.EmployeePayHistory>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddEmployeePayHistory, Wallnut.Domain.Models.EmployeePayHistory>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.EmployeePayHistory;
            int BusinessEntityID = entity.BusinessEntityID;
            DateTime RateChangeDate = entity.RateChangeDate;
            UpdateEntity<fAddEmployeePayHistory, Wallnut.Domain.Models.EmployeePayHistory>(BusinessEntityID, RateChangeDate);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.EmployeePayHistory;
            int BusinessEntityID = entity.BusinessEntityID;
            DateTime RateChangeDate = entity.RateChangeDate;
            RemoveEntity<Wallnut.Domain.Models.EmployeePayHistory>(BusinessEntityID, RateChangeDate);
        }








    }
}
