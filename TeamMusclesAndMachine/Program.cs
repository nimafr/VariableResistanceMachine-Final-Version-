using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TeamMusclesAndMachine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var backdrop = new Backdrop();
            backdrop.Show();
            Application.Run(new activity_main());
            backdrop.Close();
            backdrop.Hide();
            //Application.Run(new TestingMachine_Form());
        }
    }
}
