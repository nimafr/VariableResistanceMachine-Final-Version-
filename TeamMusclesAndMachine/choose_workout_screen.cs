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
    public partial class choose_workout_screen : Form
    {
        daemon daemon = new daemon();
        user_screen us = new user_screen();

        public choose_workout_screen()
        {
            InitializeComponent();
        }

        private void workout_name_textbox_Clicked(object sender, EventArgs e)
        {
            if(workout_name_textbox.ForeColor != System.Drawing.SystemColors.WindowText)
            {
                workout_name_textbox.Text = "";
                workout_name_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        public Font createCustomFonts(int fontsize)
        {

            FontFamily[] fontFamilies;
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();

            privateFontCollection.AddFontFile(Path.Combine(Application.StartupPath, "Resources\\BebasNeue-Regular.ttf"));

            return new Font(privateFontCollection.Families[0].Name, fontsize, FontStyle.Regular);
        }

        private void back_button_Click(object sender, EventArgs e)
        {

            this.Hide();
            var main_menu = new main_menu();
            main_menu.FormClosed += (s, args) => this.Close();
            main_menu.Show();
        }

        private void add_workout_button(string workout_name)
        {
            Button b = new Button();
            b.Width = 220;
            b.Height = 110;

            b.Name = b.Text = workout_name;
            b.Font = createCustomFonts(24);
            b.Click += workout_button_Click;
            ChooseWorkoutPanel.Controls.Add(b);
        }

        private void workout_button_Click(object sender, EventArgs e)
        {
            Button clickbutton = (Button) sender;

            if(delete_workout_panel.Visible == false && create_workout_panel.Visible == false)
            {
                
                var workout_screen = new workout_screen(clickbutton.Text);

                workout_screen.FormClosed += (s, args) => this.Close();
                this.Hide();
                workout_screen.Show();
            }
            else if(delete_workout_panel.Visible == true)
            {
                daemon.remove_workout(daemon.return_useridfromindex(us.return_id()), 17);
                clickbutton.Visible = false;
                delete_workout_panel.Visible = false;
            }
        }

        private void enter_text_button_Click(object sender, EventArgs e)
        {
            //check if user has entered anything into the textbox
            if (workout_name_textbox.ForeColor == System.Drawing.SystemColors.WindowText && workout_name_textbox.Text != "")
            {
                create_workout_panel.Visible = false;
                daemon.create_workout(daemon.getUser(us.return_id()), daemon.return_useridfromindex(us.return_id()), workout_name_textbox.Text, 17, "none", 0, 0);
               // daemon.change_workout_name(workout_name_textbox.Text, daemon.return_useridfromindex(us.return_id()), 17);
                add_workout_button(workout_name_textbox.Text);
                //**update daemon on a new workout created**
            }

        }

        private void choose_workout_screen_Load(object sender, EventArgs e)
        {
            List<string> workouts = daemon.return_workout_list(daemon.return_useridfromindex(us.return_id()));
           // List<string> body_g = daemon.return_workout_bodygroups(daemon.return_useridfromindex(us.return_id()));
            for (int i = 0; i < workouts.Count(); i++)
            {
                add_workout_button(workouts[i] );  
            }
        }

        private void create_workout_button_Click(object sender, EventArgs e)
        {
            //workout creation here
            if (create_workout_panel.Visible == false && delete_workout_panel.Visible == false)
            {
                workout_name_textbox.Text = "Enter workout name here...";
                workout_name_textbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
                create_workout_panel.Visible = true;
            }
        }

        private void delete_workout_button_Click(object sender, EventArgs e)
        {
            //workout deletion here
            if (create_workout_panel.Visible == false && delete_workout_panel.Visible == false)
            {
                delete_workout_panel.Visible = true;
            }
        }

        private void edit_workout_button_Click(object sender, EventArgs e)
        {

        }
    }
}
