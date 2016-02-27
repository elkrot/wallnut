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
    public partial class fAddProduct : Form
    {
        public Product product;
        public List<UnitMeasure> unitMeasureList;
        public fAddProduct()
        {
            InitializeComponent();
        }



        private void fAddProduct_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = product;

            cbUnitMesure.DataSource = unitMeasureList;
            cbUnitMesure.ValueMember = "UnitMeasureCode";
            cbUnitMesure.DisplayMember = "Name";
            cbUnitMesure.SelectedValue = product.WeightUnitMeasureCode??"";
            cbUnitMesure.SelectedIndexChanged += (x,y) => 
                { 
                    product.WeightUnitMeasureCode = cbUnitMesure.SelectedValue.ToString(); 
                };
           // cbUnitMesure.DataBindings.Add(new Binding("SelectedValue", unitMeasureList, "product.WeightUnitMeasureCode"));
        }

        private void fAddProduct_Activated(object sender, EventArgs e)
        {
            nameTextBox.Focus();
        }






    }
}
