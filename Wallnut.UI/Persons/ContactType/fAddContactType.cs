using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI.Persons.ContactType
{
    public partial class fAddContactType : Wallnut.UI.Implementations.AddForm
    {
        public fAddContactType()
        {

            InitializeComponent();
        }
        private void BindingData()
        {

            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.ContactType,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.ContactType).ModifiedDate = DateTime.Now;
        }

        private void fAddContactType_Load(object sender, EventArgs e)
        {
            BindingData();
        }

    }
}
