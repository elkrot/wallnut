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

namespace Wallnut.UI
{
    public partial class fShifts : Form
    {
        public fShifts()
        {
            InitializeComponent();
        }

        private void shiftBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            AddShift();
        }

        #region AddShift
        private void AddShift()
        {
            fAddShift frm = new fAddShift();
            frm.Text = "Добавление Смены";
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                frm.shift = new Shift();

                frm.shift.ModifiedDate = DateTime.Now;
                DialogResult result = frm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    unitOfWork.ShiftRepository.Add(frm.shift);
                    unitOfWork.Complete();
                    bsShift.DataSource = unitOfWork.ShiftRepository.GetAll().ToList();
                }
            }
        }
        #endregion

        #region UpdateShift
        private void UpdateShift()
        {
            fAddShift frm = new fAddShift();
            frm.Text = "Изменение Смены";
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {

                var shift = dgvShift.SelectedRows[0].DataBoundItem as Shift;
                frm.shift = unitOfWork.ShiftRepository.Get(shift.ShiftID);

                frm.shift.ModifiedDate = DateTime.Now;
                DialogResult result = frm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    unitOfWork.ShiftRepository.Update(frm.shift);
                    unitOfWork.Complete();
                    bsShift.DataSource = unitOfWork.ShiftRepository.GetAll().ToList();
                }
            }
        }
        #endregion

        #region RemoveShift
        private void RemoveShift()
        {
            System.Windows.Forms.DialogResult res = MessageBox.Show("Удалить запись?", "Удалить запись?", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {
                    var prod_id =
                        (dgvShift.SelectedRows[0].DataBoundItem as Shift).ShiftID;

                    var prod = unitOfWork.ShiftRepository.Get(prod_id);
                    unitOfWork.ShiftRepository.Remove(prod);
                    unitOfWork.Complete();
                    bsShift.DataSource = unitOfWork.ShiftRepository.GetAll().ToList();

                }
            }
        }
        #endregion
        
        private void fShifts_Load(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                IShiftRepository sr = unitOfWork.ShiftRepository;
                bsShift.DataSource = sr.GetAll().ToList();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UpdateShift();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RemoveShift();
        }

        
    }
}
