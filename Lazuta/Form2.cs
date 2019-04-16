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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SidePanel.Height = BHome.Height;
            SidePanel.Top = BHome.Top;
            section_home1.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void svipe_Click(object sender, EventArgs e)
        {
            // Свернуть
        }

        private void BHome_Click(object sender, EventArgs e)
        { 
            section_home1.BringToFront();
            if (SidePanel.Visible == true)
            {
                TransitionSideBar.HideSync(SidePanel);
                TransitionSideBar.ShowSync(SidePanel);
                SidePanel.Height = BHome.Height;
                SidePanel.Top = BHome.Top;
            }
        }

        private void Button_catalog_Click(object sender, EventArgs e)
        {
            park1.BringToFront();
            if (SidePanel.Visible == true)
            {
                TransitionSideBar.HideSync(SidePanel);
                TransitionSideBar.ShowSync(SidePanel);
                SidePanel.Height = Button_catalog.Height;
                SidePanel.Top = Button_catalog.Top;
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (SidePanel.Visible == true)
            {
                TransitionSideBar.HideSync(SidePanel);
                TransitionSideBar.ShowSync(SidePanel);
                SidePanel.Height = Button_add.Height;
                SidePanel.Top = Button_add.Top;
            }
        }

        private void Button_Contact_Click(object sender, EventArgs e)
        {
            if (SidePanel.Visible == true)
            {
                TransitionSideBar.HideSync(SidePanel);
                TransitionSideBar.ShowSync(SidePanel);
                SidePanel.Height = Button_Contact.Height;
                SidePanel.Top = Button_Contact.Top;
            }
        }
    }
}
