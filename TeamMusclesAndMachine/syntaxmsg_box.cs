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
    public partial class syntaxmsg_box : Form
    {
        public syntaxmsg_box(int input)
        {
            InitializeComponent();
            if (input == 0)
            {
                title_label.Text = "Please Enter A Last Name";
            }
            else if(input ==1 )
            {
                title_label.Text = "Please Enter A Name";
            }
            else
            {
                title_label.Text = "User With This Name Already Exists,"+ Environment.NewLine + "Please Enter A Different Name";
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
