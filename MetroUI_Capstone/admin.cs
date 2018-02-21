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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void home2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_form f2 = new home_form();
            f2.ShowDialog();
            this.Close();
        }

        private void exit_form3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_Tile_Click(object sender, EventArgs e)
        {

        }

        private void admin2_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void click_home(object sender, EventArgs e)
        {
            this.Hide();
            home_form home1 = new home_form();
            home1.ShowDialog();
            this.Close();
        }

        private void click_patient(object sender, EventArgs e)
        {
            this.Hide();
            patients_form p1 = new patients_form();
            p1.ShowDialog();
            this.Close();
        }
    }
}
