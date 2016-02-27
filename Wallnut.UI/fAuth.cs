using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Utils;

namespace Wallnut.UI
{
    public partial class fAuth : Form
    {
        public fAuth()
        {
            InitializeComponent();
            txtLogin.Text = "ser";
            txtPassword.Text = "1";
        }


        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPassword.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var ret = false;

            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Имя пользователя не должно быть пустым", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
            }
            else
            {
                try
                {
                    ret = Security.UserAutenticated(txtLogin.Text, txtPassword.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               // ret = true;
                   if (ret)
                {
                    
                             
                    this.Hide();
                    fMain fm = new fMain();
                    fm.ShowDialog();
                    this.Close();
                   }

            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin.Focus();
            }
        }
    }
}
