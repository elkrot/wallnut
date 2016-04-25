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

namespace Wallnut.UI.Admin.PropertyToEntityFrm
{
    public partial class fPropertyToEntity : Wallnut.UI.Implementations.ListForm
    {
        public fPropertyToEntity()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<PropertyToEntity>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddPropertyToEntity, PropertyToEntity>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as PropertyToEntity;
            string code = entity.PropertyCode;
            int be = entity.BusinesEntityID;
            UpdateEntity<fAddPropertyToEntity, PropertyToEntity>(code,be);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as PropertyToEntity;
            string code = entity.PropertyCode;
            int be = entity.BusinesEntityID;
            RemoveEntity<PropertyToEntity>(code, be);
        }








    }
}
