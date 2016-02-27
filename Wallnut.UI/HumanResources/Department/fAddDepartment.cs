using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI
{
    public partial class fAddDepartment : Form
    {
        public Department department;
        public fAddDepartment()
        {
            InitializeComponent();


        }

        public void BidingData()
        {
            this.tbName.DataBindings.Add("Text",
                        this.department,
                        "Name",
                        false,
                        DataSourceUpdateMode.OnPropertyChanged);
            this.tbGroup.DataBindings.Add("Text",
                    this.department,
                    "GroupName",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
