using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUI_Capstone
{
    public partial class home_form : Form
    {
        public home_form()
        {
            InitializeComponent();
    
        }

        private void exit_form2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {
          
          
        }

        private void usernameLogin_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Profiles1_Click(object sender, EventArgs e)
        {
            this.Hide();
            patients_form f3 = new patients_form();
            f3.ShowDialog();
            this.Close();
        }

        private void click_admin(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.ShowDialog();
            this.Close();
        }
    }
}
