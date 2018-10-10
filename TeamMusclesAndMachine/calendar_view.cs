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
    public partial class calendar_view : Form
    {
        public calendar_view()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void calendar_view_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var history_screen = new history_screen();
            history_screen.FormClosed += (s, args) => this.Close();
            history_screen.Show();
        }
    }
}
