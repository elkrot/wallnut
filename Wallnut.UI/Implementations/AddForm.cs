using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.UI.Interfaces;
using System.Windows.Forms;

namespace Wallnut.UI.Implementations
{
    public class AddForm : Form, IAddForm
    {
        public Object entity { get; set; }
        public object[] AddParams { get; set; }
        public AddForm() : base() {

          
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AddForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
