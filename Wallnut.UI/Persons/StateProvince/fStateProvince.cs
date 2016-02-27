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

namespace Wallnut.UI.Persons.StateProvince
{
    public partial class fStateProvince : Wallnut.UI.Implementations.ListForm
    {
        public fStateProvince()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<object>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<AddForm, object>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            //var entity = dgv.SelectedRows[0].DataBoundItem as Entity;
            //int id=entity.%%%Id
            UpdateEntity<AddForm, object>(0);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            //var entity = dgv.SelectedRows[0].DataBoundItem as Entity;
            //int id=entity.%%%Id
            RemoveEntity<object>(0);
        }








    }
}
