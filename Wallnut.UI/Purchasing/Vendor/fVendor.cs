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

namespace Wallnut.UI.Purchasing.Vendor
{
    public partial class fVendor : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Wallnut.Domain.Models.Vendor, fAddVendor> behavior;
        #region Конструктор
        public fVendor()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.Vendor,
                  fAddVendor>(x => true, Reread);
            behavior.AfterRemoveEntity += new EventHandler(behavior_AfterRemoveEntity);
            InitializeComponent();
            behavior.RefreshData();
        }

        void behavior_AfterRemoveEntity(object sender, EventArgs e)
        {
     
           
        }        
        #endregion

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
            AddVendor();
        }

        #region AddVendor
        private void AddVendor()
        {
            

            behavior.AddEntity();
        }
        #endregion


        private void tsbEdit_Click(object sender, EventArgs e)
        {
            EditVendor();
        }

        #region EditVendor
        private void EditVendor()
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Vendor;
            int BusinessEntityID = entity.BusinessEntityID;
            behavior.UpdateEntity(BusinessEntityID);
        }
        #endregion


        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DeleteVendor();
        }

        #region DeleteVendor
        private void DeleteVendor()
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Vendor;
            int BusinessEntityID = entity.BusinessEntityID;
            behavior.RemoveEntity(BusinessEntityID);
        }
        #endregion



        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  SetModifiedDate();
        }

        #region SetModifiedDate
        private void SetModifiedDate()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                MessageBox.Show(dgv.SelectedRows[0].State.ToString());
                if (dgv.SelectedRows[0].Index < dgv.RowCount-1)
                {
                    var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Vendor;
                    DateTime mDate = entity.ModifiedDate;
                    ss.Items[0].Text = string.Format("{0}", mDate);
                }
            }
        }
        #endregion


        private void fVendor_KeyDown(object sender, KeyEventArgs e)
        {
            OnHotKeyDown(e);
        }

        #region OnHotKeyDown
        private void OnHotKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4: EditVendor();
                    break;
                case Keys.F7: AddVendor();
                    break;
                case Keys.F8: DeleteVendor();
                    break;
                case Keys.F9:
                    break;
                case Keys.Escape: this.Close();
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditVendor();
        }

        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditVendor();
        }









    }
}
