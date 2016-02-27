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
    public partial class fAddEmployee : Form
    {
        public bool UpdateInForm = false;
        public string EMPTY_PASS { get { return "9999999999"; } }
        public Employee employee { get; set; }

        public fAddEmployee()
        {
            InitializeComponent();
            /* foreach (TextBox tb in Controls.Cast<Control>().Where(x => x is TextBox).Select(x => x as TextBox))
             {

             }*/
        }

        #region InitUpdateInFormEvent
        private void InitUpdateInFormEvent()
        {
            foreach (var pc in this.tabControl.Controls)
            {
                if (pc is TabPage)
                {
                    (pc as TabPage).Select();
                    foreach (var item in (pc as TabPage).Controls)
                    {
                        if (item is TextBox)
                        {
                            (item as TextBox).TextChanged += (o, e) =>
                            {
                                UpdateInForm = true;
                                MessageBox.Show((o as TextBox).Name);

                            };
                        }
                        else if (item is ComboBox)
                        {
                            (item as ComboBox).SelectedIndexChanged += (o, e) => { UpdateInForm = true; };
                        }
                        else if (item is CheckBox)
                        {
                            (item as CheckBox).CheckedChanged += (o, e) => { UpdateInForm = true; };
                        }
                    }
                }
            }
        }
        #endregion

        #region Load
        private void fAddEmployee_Load(object sender, EventArgs e)
        {
           
            this.employeeBindingSource.DataSource = employee;
          
            cbMaritalStatus.DataSource = new BindingSource(
                new Dictionary<string, string>() { { "M", "Состоит в браке" }, { "S", "Не состоит в браке" } }, null);
            cbMaritalStatus.ValueMember = "Key";
            cbMaritalStatus.DisplayMember = "Value";
            employee.MaritalStatus = employee.MaritalStatus ?? "M";
            cbMaritalStatus.SelectedValue = employee.MaritalStatus ;

            cbMaritalStatus.SelectedIndexChanged += (x, y) =>
            { employee.MaritalStatus = cbMaritalStatus.SelectedValue.ToString(); };

           /**/ 
            
            cbSalariedFlag.DataSource = new BindingSource(
                new Dictionary<bool, string>() { { true, "Почасовая" }, { false, "С окладом" } }, null);
            cbSalariedFlag.ValueMember = "Key";
            cbSalariedFlag.DisplayMember = "Value";
            cbSalariedFlag.SelectedValue =(bool)employee.SalariedFlag;
            //;

            cbSalariedFlag.SelectedIndexChanged += (x, y) =>
            { employee.SalariedFlag = (bool)cbSalariedFlag.SelectedValue; };/**/
            if (employee.Gender ==null){
                employee.Gender = "M";
            }
            rbGenderM.Checked = (employee.Gender == "M");
            rbGenderF.Checked = employee.Gender == "F";
            rbGenderF.CheckedChanged += (x, y) => { employee.Gender = rbGenderF.Checked ? "F" : "M"; };
            rbGenderM.CheckedChanged += (x, y) => { employee.Gender = rbGenderM.Checked ? "M" : "F"; };
            PasswordTextBox.Text = EMPTY_PASS;
            PasswordTextBox2.Text = EMPTY_PASS;

            if (employee.Person.PersonType == null) {
                employee.Person.PersonType = "EM";
            }

            InitUpdateInFormEvent(); 

        }
        #endregion
        
        private void OKP(object sender, EventArgs e)
        {
            MessageBox.Show(e.ToString(), "Pressed");
        }

        private void fAddEmployee_Activated(object sender, EventArgs e)
        {
           
            firstNameTextBox.Focus();
        }

        #region FormClosing
        private void fAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UpdateInForm && ((sender as Form).DialogResult)!=System.Windows.Forms.DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (PasswordTextBox.Text != PasswordTextBox2.Text)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Не верно введен пароль");
                    }
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    //Не сохраняем
                }
                else e.Cancel = true;//Отменяем действие
            }
        }
        #endregion
        

    }
}
