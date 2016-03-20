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
        public ListFormBehavior<Wallnut.Domain.Models.StateProvince,
            fAddStateProvince> behavior;
        public fStateProvince()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.StateProvince,
    fAddStateProvince>(x => true, Reread);
            InitializeComponent();
        }
        #region RereadData
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }
        #endregion
        private void fList_Load(object sender, EventArgs e)
        {
            behavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.StateProvince;
            int id = entity.StateProvinceID;
            behavior.UpdateEntity(id);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.StateProvince;
            int id = entity.StateProvinceID;
            behavior.RemoveEntity(id);
        }








    }
}
