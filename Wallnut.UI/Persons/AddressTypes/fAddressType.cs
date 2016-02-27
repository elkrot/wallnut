using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Wallnut.BusinessLogic.Implementations;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.BusinessLogic.Implementations;


namespace Wallnut.UI.Persons.AddressTypes
{
    public partial class fAddressType : Form
    {
       
        public fAddressType()
        {
            
            InitializeComponent();
        }

        private void fAddressType_Load(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                IAddressTypesRepository repo = unitOfWork.AddressTypesRepository;
                bs.DataSource = repo.GetAll().ToList();
            }
        }



        #region Add
        private void AddRow()
        {
            fAddAddressType frm = new fAddAddressType();
            frm.Text = "Добавление ";
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                frm.AddressType = new AddressType();

                frm.AddressType.ModifiedDate = DateTime.Now;
                DialogResult result = frm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    unitOfWork.AddressTypesRepository.Add(frm.AddressType);
                    unitOfWork.Complete();
                    bs.DataSource = unitOfWork.AddressTypesRepository.GetAll().ToList();
                }
            }
        }
        #endregion

        #region UpdateAT
        private void UpdateRow()
        {
            fAddAddressType frm = new fAddAddressType();
            frm.Text = "Изменение Смены";
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {

                var AddressType = dgv.SelectedRows[0].DataBoundItem as AddressType;
                frm.AddressType = unitOfWork.AddressTypesRepository.Get(AddressType.AddressTypeID);

                frm.AddressType.ModifiedDate = DateTime.Now;
                DialogResult result = frm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    unitOfWork.AddressTypesRepository.Update(frm.AddressType);
                    unitOfWork.Complete();
                    bs.DataSource = unitOfWork.AddressTypesRepository.GetAll().ToList();
                }
            }
        }
        #endregion

        #region Remove
        private void RemoveRow()
        {
            System.Windows.Forms.DialogResult res = 
                MessageBox.Show("Удалить запись?", "Удалить запись?", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {
                    var id =
                        (dgv.SelectedRows[0].DataBoundItem as AddressType).AddressTypeID;

                    var prod = unitOfWork.AddressTypesRepository.Get(id);
                    unitOfWork.AddressTypesRepository.Remove(prod);
                    unitOfWork.Complete();
                    bs.DataSource = unitOfWork.AddressTypesRepository.GetAll().ToList();

                }
            }
        }
        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            RemoveRow();
        }
        




    }
}
