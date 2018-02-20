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
    public partial class patients_form : Form
    {
        public patients_form()
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

        private void Patients_Tile_Click(object sender, EventArgs e)
        {

        }

        private void admin2_Click(object sender, EventArgs e)
        {


        }
    }
}
