using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamMusclesAndMachine
{
    public partial class settings_screen : Form
    {
        public settings_screen()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main_menu = new main_menu();
            main_menu.FormClosed += (s, args) => this.Close();
            main_menu.Show();
        }
    }
}
