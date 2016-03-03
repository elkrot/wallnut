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
                               // MessageBox.Show((o as TextBox).Name);

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
            BindingData();

            InitUpdateInFormEvent(); 

        }
        #endregion

        #region BindingData
         private void BindingData()
        {
            if (employee.Person.EmailAddresses.Count == 0) {
                employee.Person.EmailAddresses = new List<EmailAddress>();
            }
            this.bsEmployee.DataSource = employee;
            this.bsEmailAddresses.DataSource = employee.Person.EmailAddresses;
            this.bsPersonPhones.DataSource = employee.Person.PersonPhones;
            if (employee.Person.BusinessEntity != null)
            {
                this.bsAddresses.DataSource = employee.Person.BusinessEntity.BusinessEntityAddresses;
            }

            #region MaritalStatus
            cbMaritalStatus.DataSource = new BindingSource(
                new Dictionary<string, string>() { { "M", "Состоит в браке" }, { "S", "Не состоит в браке" } }, null);
            cbMaritalStatus.ValueMember = "Key";
            cbMaritalStatus.DisplayMember = "Value";
            employee.MaritalStatus = employee.MaritalStatus ?? "M";
            cbMaritalStatus.SelectedValue = employee.MaritalStatus;
            cbMaritalStatus.SelectedIndexChanged += (x, y) =>
            { employee.MaritalStatus = cbMaritalStatus.SelectedValue.ToString(); };
            #endregion

            #region SalariedFlag
            cbSalariedFlag.DataSource = new BindingSource(
                new Dictionary<bool, string>() { { true, "Сдельная" }, { false, "С окладом" } }, null);
            cbSalariedFlag.ValueMember = "Key";
            cbSalariedFlag.DisplayMember = "Value";
            cbSalariedFlag.SelectedValue = (bool)employee.SalariedFlag;
            cbSalariedFlag.SelectedIndexChanged += (x, y) =>
            { employee.SalariedFlag = (bool)cbSalariedFlag.SelectedValue; };            
            #endregion

            #region Gender
            if (employee.Gender == null)
            {
                employee.Gender = "M";
            }
            rbGenderM.Checked = (employee.Gender == "M");
            rbGenderF.Checked = employee.Gender == "F";
            rbGenderF.CheckedChanged += (x, y) => { employee.Gender = rbGenderF.Checked ? "F" : "M"; };
            rbGenderM.CheckedChanged += (x, y) => { employee.Gender = rbGenderM.Checked ? "M" : "F"; };
            #endregion

            #region Password
            PasswordTextBox.Text = EMPTY_PASS;
            PasswordTextBox2.Text = EMPTY_PASS;            
            #endregion

            #region PersonType
            if (employee.Person.PersonType == null)
            {
                employee.Person.PersonType = "EM";
            }            
            #endregion

          
        }
        #endregion



        private void fAddEmployee_Activated(object sender, EventArgs e)
        {
         // if( tabControl.TabPages[0].Focused)
          //  lastNameTextBox.Focus();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        #region Validating
        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
           Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Имя",ref ep);
        }

        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
          Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Фамилия", ref ep);
        }

        private void middleNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Отчество", ref ep);
        }



        private void jobTitleTextBox_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Должность", ref ep);
        }

        private void cbSalariedFlag_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<ComboBox>(ref  sender, ref  e, "Классификация работы", ref ep);
        }

        private void nationalIDNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "ИНН", ref ep);
        }
        #endregion

        private void dgvEmailAddresses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employee.ModifiedDate=DateTime.Now;
            
        }
      


    }
}
