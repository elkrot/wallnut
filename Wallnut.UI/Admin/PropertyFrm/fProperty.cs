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

namespace Wallnut.UI.Admin.PropertyFrm
{
    public partial class fProperty : Wallnut.UI.Implementations.ListForm
    {
        public fProperty()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Property>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddProperty, Property>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Property;
            string id = entity.PropertyCode;
            UpdateEntity<fAddProperty, Property>(id);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Property;
            string id = entity.PropertyCode;
            RemoveEntity<Property>(id);
        }








    }
}
