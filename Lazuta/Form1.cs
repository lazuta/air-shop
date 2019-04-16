using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lazuta
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Logins.BringToFront();
        }

        private void CloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mood_Click(object sender, EventArgs e)
        {
            if(Mood.Text == ":: Регистрация")
            {
                Mood.Text = ":: Авторизация";
                registration1.BringToFront();
            }
            else {             
                Mood.Text = ":: Регистрация";
                Logins.BringToFront();
            }
        }
    }
}
