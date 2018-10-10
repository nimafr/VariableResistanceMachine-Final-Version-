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
    public partial class enter_name_screen : Form
    {

        user_screen user = new user_screen();
        daemon daemon = new daemon();
        public static String Name_text;
        public enter_name_screen()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var user_screen = new user_screen();
            user_screen.FormClosed += (s, args) => this.Close();
            user_screen.Show();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            bool error = false;
            Name_text = name_textfield.Text;

            daemon.getUsers();
            List<String> list = daemon.return_Userlist();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(Name_text.ToUpper()))
                {
                    error = true;
                    syntaxmsg_box msgBox = new syntaxmsg_box(2);
                    msgBox.Show();
                }
            }

            if (!string.IsNullOrWhiteSpace(name_textfield.Text) && !error)
            {
               
                    user.next_id();
                    daemon.addUser(Name_text.ToUpper());
                    daemon.update();
                    list = daemon.getUsers();
                    int uid = daemon.get_usersid(Name_text.ToUpper());
                    daemon.add_default_workouts(uid);
                    //daemon.add_to_whistory(Name_text.ToUpper(), uid, "10:00", "0", 10, 140, 140);
                   // daemon.create_workout(Name_text.ToUpper(), 0, "Omega", 16, "back", 0, 100);
                /*
                List<String> workouts = daemon.return_workout_list(daemon.get_usersid(Name_text.ToUpper()));
                Console.WriteLine(workouts[0]);

                Console.WriteLine(daemon.return_startposition(daemon.get_usersid(Name_text.ToUpper()), 0));

                Console.WriteLine(daemon.return_endposition(daemon.get_usersid(Name_text.ToUpper()), 0));

                daemon.get_workout_history(daemon.get_usersid(Name_text.ToUpper()), 0,"7/25/2018");
                List<String> timer = daemon.return_timers();
                List<String> reps = daemon.return_reps();
                List<String> max = daemon.return_maxforces();
                List<String> avg = daemon.return_avgforces();
                Console.WriteLine(timer[0]);
                Console.WriteLine(reps[0]);
                Console.WriteLine(max[0]);
                Console.WriteLine(avg[0]);*/


                this.Hide();
                    var main_menu = new main_menu();
                    main_menu.FormClosed += (s, args) => this.Close();
                    main_menu.Show();
            }
            else if (string.IsNullOrWhiteSpace(name_textfield.Text))
            {
                syntaxmsg_box msgBox = new syntaxmsg_box(1);
                msgBox.Show();
            }
        }
        public String return_name()
        {
            return Name_text;
        }
    }
}
