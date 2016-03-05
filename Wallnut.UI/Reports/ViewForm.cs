using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wallnut.UI.Reports
{
    public partial class ViewForm : Form
    {
        public string report { get {return "Wallnut.UI.Reports.Report1.rdlc";}  }
        public ViewForm()
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = report;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wallnutProductionDataSet1.vEmployeeCurrentJub". При необходимости она может быть перемещена или удалена.
            this.vEmployeeCurrentJubTableAdapter.Fill(this.wallnutProductionDataSet1.vEmployeeCurrentJub);

            this.reportViewer1.RefreshReport();
        }
    }
}
