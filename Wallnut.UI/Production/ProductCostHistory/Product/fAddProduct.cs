using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;
using Wallnut.UI.Production.UnitMeasure;
using Wallnut.BusinessLogic.Implementations;

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

        private void btnOK_Click(object sender, EventArgs e)
        {//ValidationConstraints.Enabled
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                e.Cancel = true; nameTextBox.Focus(); errorProvider1.SetError(nameTextBox, "Поле наименование не может быть пустым");
            }
            else {
                e.Cancel = false;  errorProvider1.SetError(nameTextBox, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new fUnitMeasure();
            frm.ShowDialog();
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                unitMeasureList = unitOfWork.UnitMeasureRepository.GetAll().ToList<UnitMeasure>();
            }
            cbUnitMesure.DataSource = unitMeasureList;
        }






    }
}
