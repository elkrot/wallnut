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

namespace Wallnut.UI.Production.frmProductInventory
{
    public partial class fProductInventory : Wallnut.UI.Implementations.ListForm
    {
        private static fProductInventory aForm = null;
        public ListFormBehavior<ProductInventory, fAddProductInventory> behavior;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public fProductInventory()
        {
            behavior = new ListFormBehavior<ProductInventory, fAddProductInventory>(x=>true, Reread);
            behavior.BeforeAddEntity += new EventHandler(BeforAddProductInventory);
            behavior.BeforeUpdateEntity += new EventHandler(BeforUpdateProductInventory);
            InitializeComponent();
        }        
        #endregion

        #region Events
        void BeforAddProductInventory(object sender, EventArgs e)
        {
          // (behavior.frm.entity as ProductInventory).Bin = 10; 
        }

        void BeforUpdateProductInventory(object sender, EventArgs e)
        {
           // (behavior.frm.entity as ProductInventory).Bin = 10;
        }        
        #endregion

        #region Reread
        /// <summary>
        /// Обновление данных
        /// </summary>
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }        
        #endregion



        private void fList_Load(object sender, EventArgs e)
        {
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
            var entity = dgv.SelectedRows[0].DataBoundItem as ProductInventory;
            int productId = entity.ProductID;
            int locationId = entity.LocationID;
            behavior.UpdateEntity(productId, locationId);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as ProductInventory;
            int productId = entity.ProductID;
            int locationId = entity.LocationID;
            behavior.RemoveEntity(productId, locationId);
        }

        public static fProductInventory Instance()
        {
            if (aForm == null)
            {
                aForm = new fProductInventory();
            }
            return aForm;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }







        
    }
}
