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

namespace Wallnut.UI.Sales.Customer
{
    public partial class fCustomer : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<Wallnut.Domain.Models.Customer, fAddCustomer> behavior;

        #region fCustomer
        public fCustomer()
        {
            behavior = new ListFormBehavior<Wallnut.Domain.Models.Customer, fAddCustomer>(x => true, Reread);
            InitializeComponent();
        }        
        #endregion

        #region fList_Load
         private void fList_Load(object sender, EventArgs e)
        {
           behavior.RefreshData();
        }       
        #endregion

        #region Reread
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }        
        #endregion

        #region tsbAdd_Click
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity();
        }        
        #endregion

        #region tsbEdit_Click
         private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Customer;
            int CustomerID = entity.CustomerID;
            behavior.UpdateEntity(CustomerID);
        }       
        #endregion

        #region tsbDelete_Click
         private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Customer;
            int CustomerID = entity.CustomerID;
            behavior.RemoveEntity(CustomerID);
        }         
         #endregion









    }
}
