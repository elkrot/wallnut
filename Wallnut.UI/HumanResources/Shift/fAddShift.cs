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
    public partial class fAddShift : Form
    {
        public Shift shift;
        public fAddShift()
        {
            InitializeComponent();
        }

        private void fAddShift_Load(object sender, EventArgs e)
        {
            shiftBindingSource.DataSource = shift;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void shiftBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
