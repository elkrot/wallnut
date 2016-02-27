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

namespace Wallnut.UI.Production.UnitMeasure
{
    public partial class fUnitMeasure : Wallnut.UI.Implementations.ListForm
    {
        public fUnitMeasure()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Wallnut.Domain.Models.UnitMeasure>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddUnitMesure, Wallnut.Domain.Models.UnitMeasure>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.UnitMeasure;
            string UnitMeasureCode = entity.UnitMeasureCode;
            UpdateEntity<fAddUnitMesure, Wallnut.Domain.Models.UnitMeasure>(UnitMeasureCode);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.UnitMeasure;
            string UnitMeasureCode = entity.UnitMeasureCode;
            RemoveEntity<Wallnut.Domain.Models.UnitMeasure>(UnitMeasureCode);
        }








    }
}
