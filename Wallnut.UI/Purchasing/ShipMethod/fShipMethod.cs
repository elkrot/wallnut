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

namespace Wallnut.UI.Purchasing.ShipMethod
{
    
    public partial class fShipMethod : Wallnut.UI.Implementations.ListFormMdi
    {
        private static fShipMethod aForm = null;
        public ListFormBehavior<Wallnut.Domain.Models.ShipMethod, fAddShipMethod> behavior;
        public fShipMethod()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.ShipMethod,
            fAddShipMethod>(x => true, Reread);
            InitializeComponent();
            behavior.RefreshData();
        }
        public static fShipMethod Instance()
        {
            if (aForm == null)
            {
                aForm = new fShipMethod();
            }
            return aForm;
        }

  
        public void Reread()
        {
            bs.DataSource = behavior.EntityList;
        }
        private void fList_Load(object sender, EventArgs e)
        {
           // this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
            behavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ShipMethod;
            int ShipMethodID = entity.ShipMethodID;
            behavior.UpdateEntity(ShipMethodID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ShipMethod;
            int ShipMethodID = entity.ShipMethodID;
            behavior.RemoveEntity(ShipMethodID);
        }








    }
}
