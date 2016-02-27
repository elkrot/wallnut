using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.BusinessLogic.Implementations;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Interfaces;

namespace Wallnut.UI.Persons.AddressTypes
{
    public partial class fAddAddressType : Form
    {
        public AddressType AddressType;

        public fAddAddressType()
        {
            InitializeComponent();
            
        }
        public void BidingData()
        {
            this.tbName.DataBindings.Add("Text",
                        this.AddressType,
                        "Name",
                        false,
                        DataSourceUpdateMode.OnPropertyChanged);
            
        }

        private void fAddAddressType_Load(object sender, EventArgs e)
        {
            BidingData();
        }
    }
}
