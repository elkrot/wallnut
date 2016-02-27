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
    public partial class fDepartment : Form
    {
        public fDepartment()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var fad = new fAddDepartment();
            fad.department = new Department();
            fad.department.Name = "Новое подразделение";
            fad.department.GroupName = "Группа";
            fad.department.ModifiedDate = DateTime.Now;
            fad.BidingData();
            DialogResult fres = fad.ShowDialog();
            if (fres == System.Windows.Forms.DialogResult.OK) {

                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {
                    unitOfWork.DepartmentRepository.Add(fad.department);
                    unitOfWork.Complete();
                    bsDepartment.DataSource = unitOfWork.DepartmentRepository.GetAll().ToList();
                }
            }
        }

        private void fDepartment_Load(object sender, EventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                bsDepartment.DataSource = unitOfWork.DepartmentRepository.GetAll().ToList();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var dp = dgvDepartment.SelectedRows[0].DataBoundItem as Department;
            var fad = new fAddDepartment();
            fad.department = dp;

            fad.department.ModifiedDate = DateTime.Now;
            fad.BidingData();
            DialogResult fres = fad.ShowDialog();
            if (fres == System.Windows.Forms.DialogResult.OK)
            {

                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {

                    unitOfWork.DepartmentRepository.UpdateDepartment(fad.department);
                    unitOfWork.Complete();
                    bsDepartment.DataSource = unitOfWork.DepartmentRepository.GetAll().ToList();
                }
            }
        }
    }
}
