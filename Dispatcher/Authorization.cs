using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dispatcher.Controllers;

namespace Dispatcher
{
    public partial class Authorization : Form
    {

        public Authorization()
        {
            InitializeComponent();
            Program.formsContext.Add(this);
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string user = txtLogin.Text;
            string password = txtPassword.Text;
            if (user == "" || password == "")
            {
                                MessageBox.Show(
                    "Заполините все поля!",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else
            {

                if (AuthorizationController.Auth(user, password))
                {
                    MainMenu menu = new MainMenu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Логин или пароль неверный!",
                        "Ошибка авторизации",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    // Дополнительно: очистка полей и фокус на логин
                    txtLogin.Clear();
                    txtPassword.Clear();
                    txtLogin.Focus();
                }
            }
                
        }

        private void chkPassword_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }
    }
}
