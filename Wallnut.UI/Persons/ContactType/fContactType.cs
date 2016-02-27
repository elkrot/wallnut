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

namespace Wallnut.UI.Persons.ContactType
{
    public partial class fContactType : Wallnut.UI.Implementations.ListForm
    {
        public fContactType()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Wallnut.Domain.Models.ContactType>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddContactType, Wallnut.Domain.Models.ContactType>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ContactType;
            int id = entity.ContactTypeID;
            UpdateEntity<fAddContactType, Wallnut.Domain.Models.ContactType>(id);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.ContactType;
            int id = entity.ContactTypeID;
            RemoveEntity<Wallnut.Domain.Models.ContactType>(id);
        }








    }
}
