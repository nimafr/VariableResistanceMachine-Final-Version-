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
    public partial class user_screen : Form
    {
        public static int user_id = 0;
        public static Boolean delete = false;
        daemon daemon = new daemon();
        public user_screen()
        {
            InitializeComponent();
            List<String> list = daemon.getUsers();
            int locationy = 150;
            int locationx = (this.Width / 2)-(320/2);
            for (int i = 0; i < list.Count; i++)
            {
                Button b = new Button();
                b.Anchor = AnchorStyles.None;
                b.Location = new Point(locationx, locationy);
                b.Name = i.ToString();
                b.Text = list[i];
                b.Size = new Size(320, 60);
                b.Font = createCustomFonts(22);
                b.Padding = new Padding(0);

                b.Click += new EventHandler(userbutton_Click);

                this.Controls.Add(b);
                locationy += 65;

            }
        }

        public Font createCustomFonts(int fontsize)
        {

            FontFamily[] fontFamilies;
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();

            privateFontCollection.AddFontFile(Path.Combine(Application.StartupPath, "Resources\\BebasNeue-Regular.ttf"));

            return new Font(privateFontCollection.Families[0].Name, fontsize, FontStyle.Regular);
        }

        private void userbutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            user_id = Int32.Parse(button.Name);
            List<String> list = daemon.getUsers();

            if (delete == false)
            {
                this.Hide();
                var main_menu = new main_menu();
                main_menu.FormClosed += (s, args) => this.Close();
                main_menu.Show();
            }
            else
            {
                //MessageBox.Show("delete " + list[user_id]);
                DialogResult deleteUserBox = new DialogResult();

                deleteUserBox = MessageBox.Show(" All data will be permanently deleted. Are you sure you want to delete " 
                                                + daemon.getUser(user_id) + " from the system?" , "Delete User", 
                                                MessageBoxButtons.YesNo, MessageBoxIcon.None);
                

                if (deleteUserBox == DialogResult.Yes)
                {
                    // Delete user info
                    // DELETE FOLDER HERE
                    daemon.deleteUser(user_id);
                    delete = false;

                    daemon.getUsers();


                    //this.Refresh();

                    this.Hide();
                    var u_screen = new user_screen();
                    u_screen.FormClosed += (s, args) => this.Close();
                    u_screen.Show();
                }

                

            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var enter_name_screen = new enter_name_screen();
            enter_name_screen.FormClosed += (s, args) => this.Close();
            enter_name_screen.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // cancel deleting a user
            if (delete == true)
            {
                delete = false;
                title_label.Text = "CHOOSE A USER";
                delete_button.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.delete_user;
            }
            else
            {
                // enable delete function
                delete = true;
                //okmsg_box msgBox = new okmsg_box();
                //msgBox.Show();
                title_label.Text = "DELETE A USER";
                delete_button.BackgroundImage = TeamMusclesAndMachine.Properties.Resources.cancel;
            }

            
        }

        public int return_id()
        {
            return user_id;
        }
        public void next_id()
        {
            daemon.update();
            List<String> list = daemon.getUsers();
            user_id = list.Count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
