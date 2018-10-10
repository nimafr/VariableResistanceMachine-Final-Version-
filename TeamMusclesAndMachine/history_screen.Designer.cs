namespace TeamMusclesAndMachine
{
    partial class history_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history_screen));
            this.back_button = new System.Windows.Forms.Button();
            this.workGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphText = new System.Windows.Forms.Label();
            this.workButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.workoutList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.calendarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.back2;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Location = new System.Drawing.Point(40, 37);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.back_button.Size = new System.Drawing.Size(173, 62);
            this.back_button.TabIndex = 3;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // workGraph
            // 
            this.workGraph.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.workGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.workGraph.Legends.Add(legend1);
            this.workGraph.Location = new System.Drawing.Point(416, 373);
            this.workGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.workGraph.Name = "workGraph";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.workGraph.Series.Add(series1);
            this.workGraph.Size = new System.Drawing.Size(565, 268);
            this.workGraph.TabIndex = 4;
            this.workGraph.Text = "workChart";
            this.workGraph.Click += new System.EventHandler(this.chart1_Click);
            // 
            // graphText
            // 
            this.graphText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graphText.AutoSize = true;
            this.graphText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphText.Location = new System.Drawing.Point(632, 325);
            this.graphText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.graphText.Name = "graphText";
            this.graphText.Size = new System.Drawing.Size(81, 29);
            this.graphText.TabIndex = 5;
            this.graphText.Text = "label1";
            // 
            // workButton
            // 
            this.workButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workButton.Location = new System.Drawing.Point(416, 302);
            this.workButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(100, 28);
            this.workButton.TabIndex = 6;
            this.workButton.Text = "Work";
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Click += new System.EventHandler(this.workButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerButton.Location = new System.Drawing.Point(416, 337);
            this.powerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(100, 28);
            this.powerButton.TabIndex = 7;
            this.powerButton.Text = "Power";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Graph Type";
            // 
            // workoutList
            // 
            this.workoutList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workoutList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutList.Location = new System.Drawing.Point(989, 302);
            this.workoutList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.workoutList.Name = "workoutList";
            this.workoutList.Size = new System.Drawing.Size(193, 339);
            this.workoutList.TabIndex = 9;
            this.workoutList.UseCompatibleStateImageBehavior = false;
            this.workoutList.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1024, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Workouts";
            // 
            // calendarButton
            // 
            this.calendarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calendarButton.Location = new System.Drawing.Point(1047, 219);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(137, 43);
            this.calendarButton.TabIndex = 11;
            this.calendarButton.Text = "Calendar View";
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // history_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 862);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workoutList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.graphText);
            this.Controls.Add(this.workGraph);
            this.Controls.Add(this.back_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "history_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "history_screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.history_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart workGraph;
        private System.Windows.Forms.Label graphText;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView workoutList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calendarButton;
    }
}