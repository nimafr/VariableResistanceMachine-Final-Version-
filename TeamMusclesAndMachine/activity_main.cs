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
    public partial class activity_main : Form
    {
        public activity_main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var user_screen = new user_screen();
            user_screen.FormClosed += (s, args) => this.Close();
            user_screen.Show();
        }
        
    }
}
