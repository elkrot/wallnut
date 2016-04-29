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
        public int BusinesEntityId=0;
        public ListFormBehavior<Wallnut.Domain.Models.PropertyToEntity, fAddPropertyToEntity> behavior;
        public fPropertyToEntity()
        {
            behavior = new ListFormBehavior<PropertyToEntity, fAddPropertyToEntity>(
                x => x.BusinesEntityID == BusinesEntityId , Reread);
            InitializeComponent();
        }
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }
        private void fList_Load(object sender, EventArgs e)
        {
            behavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity(BusinesEntityId);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as PropertyToEntity;
            string code = entity.PropertyCode;
            int be = entity.BusinesEntityID;
            behavior.UpdateEntity(code, be);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as PropertyToEntity;
            string code = entity.PropertyCode;
            int be = entity.BusinesEntityID;
            behavior.RemoveEntity(code, be);
        }








    }
}
