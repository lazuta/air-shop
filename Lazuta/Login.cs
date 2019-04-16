using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lazuta
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        // Поле для ввода "Логин"
        private void LoginLogin_Click_1(object sender, EventArgs e)
        {
            string LtextOnline = LoginLogin.Text;
            LtextOnline = LtextOnline.Trim();
            if (LtextOnline == "Логин" ||
                LtextOnline == "")
            {
                LoginLogin.Text = "";
            }
            LoginLogin.MaxLength = 15;
        }

        // Поле для ввода "Пароль"
        private void LoginPassword_Click_1(object sender, EventArgs e)
        {
            string LPasswordOnline = LoginPassword.Text;
            LPasswordOnline = LPasswordOnline.Trim();
            if (LPasswordOnline == "Пароль" ||
                LPasswordOnline == "")
            {
                LoginPassword.Text = "";
            }
            LoginPassword.PasswordChar = '•';
            LoginPassword.MaxLength = 15;
        }

        // Авторизация
        private void DLogin_Click(object sender, EventArgs e){}

        private void LoginLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void DLogin_Click_1(object sender, EventArgs e)
        {
            string LPasswordOnline = LoginPassword.Text.Trim();
            string LtextOnline = LoginLogin.Text.Trim();

            
            if (LPasswordOnline == "admin" && LtextOnline == "admin")
            {
                Form2 name = new Form2();
                name.Show();
            } else
            {
                MessageBox.Show("Неверный пароль!", "Ой-ой, ошибочка...");
            }

            
        }

    }
}
