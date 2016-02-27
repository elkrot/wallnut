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

namespace Wallnut.UI
{
    public partial class fProducts : Form
    {
        public fProducts()
        {
            InitializeComponent();
            // this.KeyUp += new KeyEventHandler(OKP);


        }

        //описание обработчика события


        private void fProducts_Load(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                bsProducts.DataSource = unitOfWork.ProductsRepository.GetAll().ToList();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void UpdateProduct()
        {
            var frm = new fAddProduct();

            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                var prod = dgvProducts.SelectedRows[0].DataBoundItem as Product;
                frm.product = unitOfWork.ProductsRepository.Get(prod.ProductID);
                frm.unitMeasureList = unitOfWork.UnitMeasureRepository.GetAll().ToList<UnitMeasure>();

                DialogResult result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    unitOfWork.ProductsRepository.Update(frm.product);
                    unitOfWork.Complete();
                    bsProducts.DataSource = unitOfWork.ProductsRepository.GetAll().ToList();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct()
        {
            var frm = new fAddProduct();
            frm.Text = "Добавление продукта";
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                frm.product = new Product();
                frm.unitMeasureList = unitOfWork.UnitMeasureRepository.GetAll().ToList<UnitMeasure>();
                frm.product.ModifiedDate = DateTime.Now;
                DialogResult result = frm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    unitOfWork.ProductsRepository.Add(frm.product);
                    unitOfWork.Complete();
                    bsProducts.DataSource = unitOfWork.ProductsRepository.GetAll().ToList();
                }
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }



        private void fProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                MessageBox.Show(e.KeyCode.ToString(), "Pressed");
            }
        }

        private void tsbAdd_Click_1(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            RemoveProduct();
        }

        #region RemoveProduct
         private void RemoveProduct()
        {
            System.Windows.Forms.DialogResult res = MessageBox.Show("Удалить запись?", "Удалить запись?", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {
                    var prod_id =
                        (dgvProducts.SelectedRows[0].DataBoundItem as Product).ProductID;

                    var prod = unitOfWork.ProductsRepository.Get(prod_id);
                    unitOfWork.ProductsRepository.Remove(prod);
                    unitOfWork.Complete();
                    bsProducts.DataSource = unitOfWork.ProductsRepository.GetAll().ToList();

                }
            }
        }
        #endregion
       


    }
}
