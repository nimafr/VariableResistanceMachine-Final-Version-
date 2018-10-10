using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamMusclesAndMachine
{
    public partial class main_menu : Form
    {
        enter_name_screen x = new enter_name_screen();
        database user_database = new database();
        user_screen user = new user_screen();
        public main_menu()
        {

            

            InitializeComponent();
            //r_database.populate();
            welcome_label.Text = user_database.return_username(user.return_id());
            label1.Font = createCustomFonts(36);
        }

        public Font createCustomFonts(int fontsize)
        {

            FontFamily[] fontFamilies;
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            
            privateFontCollection.AddFontFile(Path.Combine(Application.StartupPath, "Resources\\BebasNeue-Regular.ttf"));

             return new Font(privateFontCollection.Families[0].Name, fontsize, FontStyle.Regular);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var user_screen = new user_screen();
            user_screen.FormClosed += (s, args) => this.Close();
            user_screen.Show();
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var history_screen = new history_screen();
            history_screen.FormClosed += (s, args) => this.Close();
            history_screen.Show();
        }

        private void workout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var choose_workout_screen = new choose_workout_screen();
            choose_workout_screen.FormClosed += (s, args) => this.Close();
            choose_workout_screen.Show();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var settings_screen = new settings_screen();
            settings_screen.FormClosed += (s, args) => this.Close();
            settings_screen.Show();
        }

        private void main_menu_Load(object sender, EventArgs e)
        {

        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

        }
    }
}
