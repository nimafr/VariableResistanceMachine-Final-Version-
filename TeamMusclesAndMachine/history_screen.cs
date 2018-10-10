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
    public partial class history_screen : Form
    {
        public history_screen()
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

        

        private void chart1_Click(object sender, EventArgs e)
        {

        }



        private void workButton_Click(object sender, EventArgs e)
        {
            foreach (var series in workGraph.Series)
            {
                series.Points.Clear();
            }

            workGraph.ChartAreas[0].CursorX.IsUserEnabled = true;
            workGraph.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            workGraph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            workGraph.ChartAreas[0].AxisX.Title = "Distance";
            workGraph.ChartAreas[0].AxisY.Title = "Force";
            graphText.Text = "Work Graph";


            workGraph.Series[0].Points.AddXY(1, 3);
            workGraph.Series[0].Points.AddXY(2, 1);
            workGraph.Series[0].Points.AddXY(3, 7);
            workGraph.Series[0].Points.AddXY(4, 14);
            workGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            foreach (var series in workGraph.Series)
            {
                series.Points.Clear();
            }

            workGraph.ChartAreas[0].CursorX.IsUserEnabled = true;
            workGraph.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            workGraph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            workGraph.ChartAreas[0].AxisX.Title = "Time";
            workGraph.ChartAreas[0].AxisY.Title = "Work";
            graphText.Text = "Power Graph";


            workGraph.Series[0].Points.AddXY(1, 5);
            workGraph.Series[0].Points.AddXY(2, 1);
            workGraph.Series[0].Points.AddXY(3, 7);
            workGraph.Series[0].Points.AddXY(4, 2);
            workGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var calendar_view = new calendar_view();
            calendar_view.FormClosed += (s, args) => this.Close();
            calendar_view.Show();
        }

        private void history_screen_Load(object sender, EventArgs e)
        {
            foreach (var series in workGraph.Series)
            {
                series.Points.Clear();
            }

            workGraph.ChartAreas[0].CursorX.IsUserEnabled = true;
            workGraph.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            workGraph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            workGraph.ChartAreas[0].AxisX.Title = "Distance";
            workGraph.ChartAreas[0].AxisY.Title = "Force";
            graphText.Text = "Work Graph";


            workGraph.Series[0].Points.AddXY(1, 3);
            workGraph.Series[0].Points.AddXY(2, 1);
            workGraph.Series[0].Points.AddXY(3, 7);
            workGraph.Series[0].Points.AddXY(4, 14);
            workGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            ListViewItem lv1 = new ListViewItem("Squat");
            ListViewItem lv2 = new ListViewItem("Bench");
            ListViewItem lv3 = new ListViewItem("Lat Pulldown");
            ListViewItem lv4 = new ListViewItem("Deadlift");

            workoutList.Items.Add(lv1);
            workoutList.Items.Add(lv2);
            workoutList.Items.Add(lv3);
            workoutList.Items.Add(lv4);

        }
    }
}
