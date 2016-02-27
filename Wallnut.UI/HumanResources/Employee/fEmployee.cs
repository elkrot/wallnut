using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.BusinessLogic.Implementations;
using Wallnut.Domain;
using Wallnut.BusinessLogic;
using Wallnut.Domain.Models;
using Wallnut.UI.HumanResources.EmployeeDepartmentHistory;

namespace Wallnut.UI
{
    public partial class fEmployee : Form
    {
        public fEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /* System.Data.Entity.Database.SetInitializer(
                 new Wallnut.Domain.CatalogInitializer());  */

            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                var employees = unitOfWork.EmployeeRepository.GetAll();
                eFEmployeesRBS.DataSource = employees;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            NewEmployee();
        }


        #region EditEmployee
        private void EditEmployee()
        {
            var frm = new fAddEmployee();

            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                if (dgvEmployee.SelectedRows[0] != null)
                {
                    var emp = dgvEmployee.SelectedRows[0].DataBoundItem as Employee;
                    frm.employee = unitOfWork.EmployeeRepository.Get(emp.BusinessEntityID);
                    DialogResult result = frm.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        unitOfWork.EmployeeRepository.SaveEmployee(frm.employee);
                        SetPassword(ref frm);
                        unitOfWork.Complete();

                        eFEmployeesRBS.DataSource = unitOfWork.EmployeeRepository.GetAll().ToList();

                    }
                }
            }
        }
        #endregion
        
        #region NewEmployee
        private void NewEmployee()
        {
            var frm = new fAddEmployee();
            frm.employee = new Employee();
            frm.employee.Person = new Person();
            frm.employee.ModifiedDate = DateTime.Now;
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                DialogResult result = frm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    frm.employee.ModifiedDate = DateTime.Now;
                    frm.employee.Person.ModifiedDate = DateTime.Now;
                    frm.employee.BirthDate = DateTime.Parse("1975.07.27");
                    frm.employee.HireDate = DateTime.Now;
                    unitOfWork.EmployeeRepository.SaveEmployee(frm.employee);
                    SetPassword(ref frm);
                    unitOfWork.Complete();
                    eFEmployeesRBS.DataSource = unitOfWork.EmployeeRepository.GetAll().ToList();
                }
            }
        }
        #endregion
        
        #region SetPassword
        private static void SetPassword(ref fAddEmployee frm)
        {
            if (frm.PasswordTextBox.Text != frm.EMPTY_PASS)
            {
                var hsh = PasswordHash.PasswordHash.CreateHash(frm.PasswordTextBox.Text);

                char[] delimiter = { ':' };
                string[] split = hsh.Split(delimiter);

                string salt = split[PasswordHash.PasswordHash.SALT_INDEX];
                string hash = split[PasswordHash.PasswordHash.PBKDF2_INDEX];
                if (frm.employee.Person.Password == null)
                {
                    frm.employee.Person.Password = new Password();
                    frm.employee.Person.Password.BusinessEntityID = frm.employee.Person.BusinessEntityID;
                    frm.employee.Person.Password.ModifiedDate = DateTime.Now;
                }

                frm.employee.Person.Password.PasswordHash = hash;
                frm.employee.Person.Password.PasswordSalt = salt;
            }
        }
        #endregion

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            RemoveEmployee();
        }

        #region RemoveEmployee
        private void RemoveEmployee()
        {
            DialogResult result = MessageBox.Show("Удалить запись из таблицы?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {
                    var emp = dgvEmployee.SelectedRows[0].DataBoundItem as Employee;
                    var employee = unitOfWork.EmployeeRepository.Get(emp.BusinessEntityID);
                    unitOfWork.EmployeeRepository.Remove(employee);
                    unitOfWork.Complete();
                    eFEmployeesRBS.DataSource = unitOfWork.EmployeeRepository.GetAll().ToList();
                }
            }
        }
        #endregion

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var frm = new fEmployeeDepartmentHistory();
                                var emp = dgvEmployee.SelectedRows[0].DataBoundItem as Employee;
                    var employeeId =emp.BusinessEntityID;
            frm.employeeID = employeeId;
            frm.ShowDialog();
        }
        



    }
}
