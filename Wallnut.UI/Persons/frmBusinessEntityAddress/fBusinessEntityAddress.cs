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

namespace Wallnut.UI.Persons.frmBusinessEntityAddress
{
    public partial class fBusinessEntityAddress : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<BusinessEntityAddress, AddBusinessEntityAddress> behavior;
        public int BusinessEntityID { get; set; }
        public fBusinessEntityAddress()
        {
            behavior = new ListFormBehavior<BusinessEntityAddress, AddBusinessEntityAddress>(x=>x.BusinessEntityID==BusinessEntityID, Reread);
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
            behavior.AddEntity(BusinessEntityID);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as BusinessEntityAddress;
           
            int AddressID = entity.AddressID;
            int AddressTypeID = entity.AddressTypeID;
            behavior.UpdateEntity(entity.BusinessEntityID, AddressID, AddressTypeID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as BusinessEntityAddress;
            
            int AddressID = entity.AddressID;
            int AddressTypeID = entity.AddressTypeID;
            behavior.RemoveEntity(this.BusinessEntityID, AddressID, AddressTypeID);
        }
    }
}
