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

namespace Wallnut.UI.Persons.Address
{
    public partial class fAddress : Wallnut.UI.Implementations.ListForm
    {
        public fAddress()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Wallnut.Domain.Models.Address>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddAddress, Wallnut.Domain.Models.Address>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Address;
            int AddressID = entity.AddressID;
           
            UpdateEntity<fAddAddress, Wallnut.Domain.Models.Address>(AddressID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Address;
            int AddressID = entity.AddressID;
            
            RemoveEntity<Wallnut.Domain.Models.Address>(AddressID);
        }
    }
}
