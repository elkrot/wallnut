using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI.Production.UnitMeasure
{
    public partial class fAddUnitMesure : Wallnut.UI.Implementations.AddForm
    {
        public fAddUnitMesure()
        {

            InitializeComponent();
        }

        private void fAddUnitMesure_Load(object sender, EventArgs e)
        {
            BindingData();
        }
        private void BindingData(){

            this.tbUnitMeasureCode.DataBindings.Add("Text",
                        this.entity as Wallnut.Domain.Models.UnitMeasure,
                        "UnitMeasureCode",
                        false,
                        DataSourceUpdateMode.OnPropertyChanged);
            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.UnitMeasure,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
        
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.UnitMeasure).ModifiedDate = DateTime.Now;
        }
    }
}
