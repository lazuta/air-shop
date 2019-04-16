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
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void RLogin_Click(object sender, EventArgs e)
        {
            string RtextOnline = RLogin.Text;
            RtextOnline = RtextOnline.Trim();
            if (RtextOnline == "Логин" ||
                RtextOnline == "")
            {
                RLogin.Text = "";
            }
            RLogin.MaxLength = 15;
        }
               
        private void RFullname_Click(object sender, EventArgs e)
        {
            string RFullnameOnline = RFullname.Text;
            RFullnameOnline = RFullnameOnline.Trim();
            if (RFullnameOnline == "Ф.И.О." ||
                RFullnameOnline == "")
            {
                RFullname.Text = "";
            }
            RFullname.MaxLength = 30;
        }

        private void RPass1_Click(object sender, EventArgs e)
        {
            string RPasswordOnline = RPass1.Text;
            RPasswordOnline = RPasswordOnline.Trim();
            if (RPasswordOnline == "Пароль" ||
                RPasswordOnline == "")
            {
                RPass1.Text = "";
            }
            RPass1.PasswordChar = '•';
            RPass1.MaxLength = 15;
        }

        private void RegPassword1_Click(object sender, EventArgs e)
        {
            string RPasswordOnline1 = RegPassword1.Text;
            RPasswordOnline1 = RPasswordOnline1.Trim();
            if (RPasswordOnline1 == "Повторитепароль" ||
                RPasswordOnline1 == "Повторите пароль" ||
                RPasswordOnline1 == "")
            {
                RegPassword1.Text = "";
            }
            RegPassword1.PasswordChar = '•';
            RegPassword1.MaxLength = 15;
        }

    }
}
