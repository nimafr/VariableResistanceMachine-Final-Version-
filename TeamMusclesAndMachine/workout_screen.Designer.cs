namespace TeamMusclesAndMachine
{
    partial class workout_screen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 120D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 200D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 200D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 160D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 180D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 100D);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.REPSLabel = new System.Windows.Forms.TextBox();
            this.REPSDisp = new System.Windows.Forms.TextBox();
            this.MAXLabel = new System.Windows.Forms.TextBox();
            this.MAXDisp = new System.Windows.Forms.TextBox();
            this.AVGLabel = new System.Windows.Forms.TextBox();
            this.AVGDisp = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.startPosSelect = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.speedDisplayLabel = new System.Windows.Forms.Label();
            this.speedMinusButton = new System.Windows.Forms.Button();
            this.motorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.speedPlusButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.workout_livechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.workout_name_label = new System.Windows.Forms.Label();
            this.progressBarActuator = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RTLabel = new System.Windows.Forms.TextBox();
            this.RTDisp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.endPosSelect = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.incPosButton = new System.Windows.Forms.Button();
            this.decPosButton = new System.Windows.Forms.Button();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionDisplayLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startMarker = new System.Windows.Forms.PictureBox();
            this.stopMarker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startPosSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workout_livechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPosSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopMarker)).BeginInit();
            this.SuspendLayout();
            // 
            // REPSLabel
            // 
            this.REPSLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.REPSLabel.BackColor = System.Drawing.Color.Silver;
            this.REPSLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.REPSLabel.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.REPSLabel.Location = new System.Drawing.Point(860, 210);
            this.REPSLabel.Margin = new System.Windows.Forms.Padding(0);
            this.REPSLabel.Name = "REPSLabel";
            this.REPSLabel.Size = new System.Drawing.Size(215, 29);
            this.REPSLabel.TabIndex = 26;
            this.REPSLabel.Text = "Total Reps";
            this.REPSLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // REPSDisp
            // 
            this.REPSDisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.REPSDisp.BackColor = System.Drawing.Color.White;
            this.REPSDisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.REPSDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.REPSDisp.Location = new System.Drawing.Point(860, 239);
            this.REPSDisp.Margin = new System.Windows.Forms.Padding(0);
            this.REPSDisp.MaxLength = 3;
            this.REPSDisp.Name = "REPSDisp";
            this.REPSDisp.Size = new System.Drawing.Size(215, 53);
            this.REPSDisp.TabIndex = 25;
            this.REPSDisp.Text = "--";
            this.REPSDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MAXLabel
            // 
            this.MAXLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MAXLabel.BackColor = System.Drawing.Color.Silver;
            this.MAXLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MAXLabel.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.MAXLabel.Location = new System.Drawing.Point(860, 310);
            this.MAXLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MAXLabel.Name = "MAXLabel";
            this.MAXLabel.Size = new System.Drawing.Size(213, 29);
            this.MAXLabel.TabIndex = 22;
            this.MAXLabel.Text = "Max Weight";
            this.MAXLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MAXDisp
            // 
            this.MAXDisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MAXDisp.BackColor = System.Drawing.Color.White;
            this.MAXDisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MAXDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.MAXDisp.Location = new System.Drawing.Point(860, 338);
            this.MAXDisp.Margin = new System.Windows.Forms.Padding(0);
            this.MAXDisp.MaxLength = 4;
            this.MAXDisp.Name = "MAXDisp";
            this.MAXDisp.ReadOnly = true;
            this.MAXDisp.ShortcutsEnabled = false;
            this.MAXDisp.Size = new System.Drawing.Size(213, 53);
            this.MAXDisp.TabIndex = 21;
            this.MAXDisp.TabStop = false;
            this.MAXDisp.Text = "---";
            this.MAXDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AVGLabel
            // 
            this.AVGLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AVGLabel.BackColor = System.Drawing.Color.Silver;
            this.AVGLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AVGLabel.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.AVGLabel.Location = new System.Drawing.Point(862, 409);
            this.AVGLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AVGLabel.Multiline = true;
            this.AVGLabel.Name = "AVGLabel";
            this.AVGLabel.Size = new System.Drawing.Size(213, 29);
            this.AVGLabel.TabIndex = 20;
            this.AVGLabel.Text = "Average Weight";
            this.AVGLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AVGDisp
            // 
            this.AVGDisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AVGDisp.BackColor = System.Drawing.Color.White;
            this.AVGDisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AVGDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.AVGDisp.Location = new System.Drawing.Point(862, 438);
            this.AVGDisp.Margin = new System.Windows.Forms.Padding(0);
            this.AVGDisp.MaxLength = 4;
            this.AVGDisp.Name = "AVGDisp";
            this.AVGDisp.Size = new System.Drawing.Size(213, 53);
            this.AVGDisp.TabIndex = 19;
            this.AVGDisp.Text = "---";
            this.AVGDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // back_button
            // 
            this.back_button.AutoSize = true;
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.End_Workout;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(30, 25);
            this.back_button.Margin = new System.Windows.Forms.Padding(0);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(137, 65);
            this.back_button.TabIndex = 16;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // startPosSelect
            // 
            this.startPosSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startPosSelect.Enabled = false;
            this.startPosSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPosSelect.Location = new System.Drawing.Point(1112, 298);
            this.startPosSelect.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.startPosSelect.Name = "startPosSelect";
            this.startPosSelect.Size = new System.Drawing.Size(204, 75);
            this.startPosSelect.TabIndex = 31;
            this.startPosSelect.TabStop = false;
            this.startPosSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startPosSelect.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1110, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Start Pos";
            this.label1.Visible = false;
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.BackColor = System.Drawing.Color.Green;
            this.Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label.Font = new System.Drawing.Font("AunchantedExpandedBoldOblique", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.Location = new System.Drawing.Point(1101, 66);
            this.Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(219, 57);
            this.Label.TabIndex = 33;
            this.Label.Text = "SPEED";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedDisplayLabel
            // 
            this.speedDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedDisplayLabel.BackColor = System.Drawing.Color.White;
            this.speedDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speedDisplayLabel.Font = new System.Drawing.Font("AunchantedExpandedBoldOblique", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedDisplayLabel.Location = new System.Drawing.Point(1101, 123);
            this.speedDisplayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.speedDisplayLabel.Name = "speedDisplayLabel";
            this.speedDisplayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.speedDisplayLabel.Size = new System.Drawing.Size(152, 140);
            this.speedDisplayLabel.TabIndex = 36;
            this.speedDisplayLabel.Text = "20";
            this.speedDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedMinusButton
            // 
            this.speedMinusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedMinusButton.BackColor = System.Drawing.Color.LightGray;
            this.speedMinusButton.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.arrow_down;
            this.speedMinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speedMinusButton.FlatAppearance.BorderSize = 0;
            this.speedMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.speedMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.speedMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedMinusButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.speedMinusButton.Location = new System.Drawing.Point(1256, 197);
            this.speedMinusButton.Margin = new System.Windows.Forms.Padding(0);
            this.speedMinusButton.Name = "speedMinusButton";
            this.speedMinusButton.Size = new System.Drawing.Size(60, 60);
            this.speedMinusButton.TabIndex = 35;
            this.speedMinusButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.speedMinusButton.UseVisualStyleBackColor = false;
            this.speedMinusButton.Click += new System.EventHandler(this.speedMinusButton_Click);
            // 
            // motorButton
            // 
            this.motorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.motorButton.BackColor = System.Drawing.Color.Transparent;
            this.motorButton.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.Start_button;
            this.motorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.motorButton.FlatAppearance.BorderSize = 0;
            this.motorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.motorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.motorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motorButton.Location = new System.Drawing.Point(1116, 537);
            this.motorButton.Margin = new System.Windows.Forms.Padding(0);
            this.motorButton.Name = "motorButton";
            this.motorButton.Size = new System.Drawing.Size(200, 200);
            this.motorButton.TabIndex = 29;
            this.motorButton.UseVisualStyleBackColor = false;
            this.motorButton.Click += new System.EventHandler(this.motorButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1253, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 140);
            this.label2.TabIndex = 37;
            // 
            // speedPlusButton
            // 
            this.speedPlusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedPlusButton.BackColor = System.Drawing.Color.LightGray;
            this.speedPlusButton.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.arrow_up;
            this.speedPlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speedPlusButton.FlatAppearance.BorderSize = 0;
            this.speedPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.speedPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.speedPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedPlusButton.Location = new System.Drawing.Point(1256, 126);
            this.speedPlusButton.Name = "speedPlusButton";
            this.speedPlusButton.Size = new System.Drawing.Size(60, 60);
            this.speedPlusButton.TabIndex = 38;
            this.speedPlusButton.UseVisualStyleBackColor = false;
            this.speedPlusButton.Click += new System.EventHandler(this.speedPlusButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timerStartTick);
            // 
            // timer
            // 
            this.timer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timer.BackColor = System.Drawing.Color.White;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.timer.Location = new System.Drawing.Point(860, 138);
            this.timer.Margin = new System.Windows.Forms.Padding(0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(213, 53);
            this.timer.TabIndex = 39;
            this.timer.Text = "0:00";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workout_livechart
            // 
            this.workout_livechart.BackColor = System.Drawing.Color.RoyalBlue;
            this.workout_livechart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.workout_livechart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.workout_livechart.BackSecondaryColor = System.Drawing.Color.DeepSkyBlue;
            this.workout_livechart.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            this.workout_livechart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisX.Interval = 5D;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 15;
            chartArea2.AxisX.LabelAutoFitMinFontSize = 15;
            chartArea2.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)));
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LabelStyle.Interval = 10D;
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LineWidth = 3;
            chartArea2.AxisX.LogarithmBase = 2D;
            chartArea2.AxisX.MajorGrid.Interval = 5D;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MajorTickMark.Interval = 5D;
            chartArea2.AxisX.MajorTickMark.LineWidth = 2;
            chartArea2.AxisX.MajorTickMark.Size = 2F;
            chartArea2.AxisX.MaximumAutoSize = 15F;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisX.MinorTickMark.Interval = 1D;
            chartArea2.AxisX.ScaleView.MinSize = 15D;
            chartArea2.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.ScaleView.Position = 0D;
            chartArea2.AxisX.ScaleView.Size = 30D;
            chartArea2.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.ScaleView.SmallScrollMinSize = 5D;
            chartArea2.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.ScaleView.SmallScrollSize = 5D;
            chartArea2.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.ScaleView.Zoomable = false;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea2.AxisX.ScrollBar.Size = 20D;
            chartArea2.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisX.Title = "Time (sec)";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Bebas Neue", 28F);
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisY.Interval = 50D;
            chartArea2.AxisY.LabelAutoFitMaxFontSize = 25;
            chartArea2.AxisY.LabelAutoFitMinFontSize = 12;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            chartArea2.AxisY.LineWidth = 3;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.ScaleView.MinSize = 210D;
            chartArea2.AxisY.ScaleView.Position = 0D;
            chartArea2.AxisY.ScaleView.Size = 500D;
            chartArea2.AxisY.ScaleView.SmallScrollMinSize = 210D;
            chartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea2.AxisY.ScrollBar.Enabled = false;
            chartArea2.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea2.AxisY.ScrollBar.Size = 20D;
            chartArea2.AxisY.Title = "Force (lbs)";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Bebas Neue", 28F);
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.Crossing = -1.7976931348623157E+308D;
            chartArea2.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea2.CursorX.AutoScroll = false;
            chartArea2.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.LineWidth = 2;
            chartArea2.CursorX.Position = 0D;
            chartArea2.CursorX.SelectionColor = System.Drawing.Color.LawnGreen;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.DimGray;
            chartArea2.ShadowOffset = 10;
            this.workout_livechart.ChartAreas.Add(chartArea2);
            this.workout_livechart.Cursor = System.Windows.Forms.Cursors.Default;
            this.workout_livechart.Location = new System.Drawing.Point(60, 109);
            this.workout_livechart.Margin = new System.Windows.Forms.Padding(0);
            this.workout_livechart.Name = "workout_livechart";
            this.workout_livechart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.CustomProperties = "IsXAxisQuantitative=False, LabelStyle=Top";
            series2.Font = new System.Drawing.Font("Arial Black", 10F);
            series2.IsVisibleInLegend = false;
            series2.LabelBackColor = System.Drawing.Color.Gainsboro;
            series2.LabelBorderColor = System.Drawing.Color.Gray;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.DarkRed;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "loadcelldata";
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.ShadowOffset = 2;
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series2.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            series2.SmartLabelStyle.CalloutLineWidth = 0;
            series2.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series2.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series2.SmartLabelStyle.MinMovingDistance = 10D;
            series2.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            this.workout_livechart.Series.Add(series2);
            this.workout_livechart.Size = new System.Drawing.Size(772, 494);
            this.workout_livechart.TabIndex = 42;
            title2.Font = new System.Drawing.Font("AunchantedExpandedBoldOblique", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.ShadowColor = System.Drawing.Color.Black;
            title2.ShadowOffset = 2;
            title2.Text = "USER METRICS";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.workout_livechart.Titles.Add(title2);
            // 
            // arduinoPort
            // 
            this.arduinoPort.PortName = "COM5";
            // 
            // workout_name_label
            // 
            this.workout_name_label.AutoSize = true;
            this.workout_name_label.BackColor = System.Drawing.Color.Transparent;
            this.workout_name_label.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workout_name_label.ForeColor = System.Drawing.Color.White;
            this.workout_name_label.Location = new System.Drawing.Point(198, 33);
            this.workout_name_label.Name = "workout_name_label";
            this.workout_name_label.Size = new System.Drawing.Size(261, 57);
            this.workout_name_label.TabIndex = 46;
            this.workout_name_label.Text = "workout_name";
            // 
            // progressBarActuator
            // 
            this.progressBarActuator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBarActuator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBarActuator.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBarActuator.Location = new System.Drawing.Point(55, 698);
            this.progressBarActuator.Margin = new System.Windows.Forms.Padding(0);
            this.progressBarActuator.MarqueeAnimationSpeed = 5;
            this.progressBarActuator.Maximum = 95;
            this.progressBarActuator.Name = "progressBarActuator";
            this.progressBarActuator.Size = new System.Drawing.Size(762, 39);
            this.progressBarActuator.Step = 5;
            this.progressBarActuator.TabIndex = 47;
            this.progressBarActuator.Value = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(55, 737);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(775, 45);
            this.label3.TabIndex = 48;
            this.label3.Text = "Linear Actuator Progress";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(860, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "Active Workout Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RTLabel
            // 
            this.RTLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTLabel.BackColor = System.Drawing.Color.Silver;
            this.RTLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTLabel.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.RTLabel.Location = new System.Drawing.Point(860, 508);
            this.RTLabel.Margin = new System.Windows.Forms.Padding(0);
            this.RTLabel.Multiline = true;
            this.RTLabel.Name = "RTLabel";
            this.RTLabel.Size = new System.Drawing.Size(213, 29);
            this.RTLabel.TabIndex = 51;
            this.RTLabel.Text = "Current Weight";
            this.RTLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RTDisp
            // 
            this.RTDisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTDisp.BackColor = System.Drawing.Color.White;
            this.RTDisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.RTDisp.Location = new System.Drawing.Point(860, 537);
            this.RTDisp.Margin = new System.Windows.Forms.Padding(0);
            this.RTDisp.MaxLength = 4;
            this.RTDisp.Name = "RTDisp";
            this.RTDisp.Size = new System.Drawing.Size(213, 53);
            this.RTDisp.TabIndex = 50;
            this.RTDisp.Text = "---";
            this.RTDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1110, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 53;
            this.label4.Text = "End Pos";
            this.label4.Visible = false;
            // 
            // endPosSelect
            // 
            this.endPosSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endPosSelect.Enabled = false;
            this.endPosSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endPosSelect.Location = new System.Drawing.Point(1112, 409);
            this.endPosSelect.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.endPosSelect.Name = "endPosSelect";
            this.endPosSelect.Size = new System.Drawing.Size(204, 75);
            this.endPosSelect.TabIndex = 52;
            this.endPosSelect.TabStop = false;
            this.endPosSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endPosSelect.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // incPosButton
            // 
            this.incPosButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incPosButton.BackColor = System.Drawing.Color.Silver;
            this.incPosButton.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.arrow_up;
            this.incPosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.incPosButton.FlatAppearance.BorderSize = 0;
            this.incPosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.incPosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.incPosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incPosButton.Location = new System.Drawing.Point(1040, 664);
            this.incPosButton.Margin = new System.Windows.Forms.Padding(0);
            this.incPosButton.Name = "incPosButton";
            this.incPosButton.Size = new System.Drawing.Size(50, 50);
            this.incPosButton.TabIndex = 58;
            this.incPosButton.UseVisualStyleBackColor = false;
            this.incPosButton.Visible = false;
            this.incPosButton.Click += new System.EventHandler(this.incPosButton_Click);
            // 
            // decPosButton
            // 
            this.decPosButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decPosButton.BackColor = System.Drawing.Color.Silver;
            this.decPosButton.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.arrow_down;
            this.decPosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decPosButton.FlatAppearance.BorderSize = 0;
            this.decPosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.decPosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.decPosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decPosButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.decPosButton.Location = new System.Drawing.Point(1040, 722);
            this.decPosButton.Margin = new System.Windows.Forms.Padding(0);
            this.decPosButton.Name = "decPosButton";
            this.decPosButton.Size = new System.Drawing.Size(50, 50);
            this.decPosButton.TabIndex = 55;
            this.decPosButton.UseVisualStyleBackColor = false;
            this.decPosButton.Visible = false;
            this.decPosButton.Click += new System.EventHandler(this.decPosButton_Click);
            // 
            // positionLabel
            // 
            this.positionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.positionLabel.BackColor = System.Drawing.Color.White;
            this.positionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.positionLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(860, 661);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.positionLabel.Size = new System.Drawing.Size(170, 115);
            this.positionLabel.TabIndex = 56;
            this.positionLabel.Text = "99";
            this.positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.positionLabel.Visible = false;
            // 
            // positionDisplayLabel
            // 
            this.positionDisplayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.positionDisplayLabel.BackColor = System.Drawing.Color.Gold;
            this.positionDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.positionDisplayLabel.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionDisplayLabel.ForeColor = System.Drawing.Color.White;
            this.positionDisplayLabel.Location = new System.Drawing.Point(860, 604);
            this.positionDisplayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.positionDisplayLabel.Name = "positionDisplayLabel";
            this.positionDisplayLabel.Size = new System.Drawing.Size(240, 57);
            this.positionDisplayLabel.TabIndex = 54;
            this.positionDisplayLabel.Text = "SET START POSITION";
            this.positionDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.positionDisplayLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(1030, 661);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 115);
            this.label8.TabIndex = 57;
            this.label8.Visible = false;
            // 
            // startMarker
            // 
            this.startMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startMarker.BackColor = System.Drawing.Color.Transparent;
            this.startMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startMarker.Image = global::TeamMusclesAndMachine.Properties.Resources.start_marker;
            this.startMarker.Location = new System.Drawing.Point(25, 631);
            this.startMarker.Margin = new System.Windows.Forms.Padding(0);
            this.startMarker.Name = "startMarker";
            this.startMarker.Size = new System.Drawing.Size(62, 67);
            this.startMarker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startMarker.TabIndex = 59;
            this.startMarker.TabStop = false;
            // 
            // stopMarker
            // 
            this.stopMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopMarker.BackColor = System.Drawing.Color.Transparent;
            this.stopMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stopMarker.Image = global::TeamMusclesAndMachine.Properties.Resources.end_marker;
            this.stopMarker.Location = new System.Drawing.Point(785, 631);
            this.stopMarker.Margin = new System.Windows.Forms.Padding(0);
            this.stopMarker.Name = "stopMarker";
            this.stopMarker.Size = new System.Drawing.Size(62, 67);
            this.stopMarker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopMarker.TabIndex = 60;
            this.stopMarker.TabStop = false;
            // 
            // workout_screen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.bg_app2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.stopMarker);
            this.Controls.Add(this.startMarker);
            this.Controls.Add(this.incPosButton);
            this.Controls.Add(this.decPosButton);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.positionDisplayLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endPosSelect);
            this.Controls.Add(this.RTLabel);
            this.Controls.Add(this.RTDisp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarActuator);
            this.Controls.Add(this.workout_name_label);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.speedPlusButton);
            this.Controls.Add(this.speedMinusButton);
            this.Controls.Add(this.speedDisplayLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startPosSelect);
            this.Controls.Add(this.motorButton);
            this.Controls.Add(this.REPSLabel);
            this.Controls.Add(this.REPSDisp);
            this.Controls.Add(this.MAXLabel);
            this.Controls.Add(this.MAXDisp);
            this.Controls.Add(this.AVGLabel);
            this.Controls.Add(this.AVGDisp);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workout_livechart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "workout_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "workout_screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.workout_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startPosSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workout_livechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPosSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopMarker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox REPSLabel;
        private System.Windows.Forms.TextBox REPSDisp;
        private System.Windows.Forms.TextBox MAXLabel;
        private System.Windows.Forms.TextBox MAXDisp;
        private System.Windows.Forms.TextBox AVGLabel;
        private System.Windows.Forms.TextBox AVGDisp;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button motorButton;
        private System.Windows.Forms.NumericUpDown startPosSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button speedMinusButton;
        private System.Windows.Forms.Label speedDisplayLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button speedPlusButton;
        private System.Windows.Forms.Label timer;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart workout_livechart;
        private System.IO.Ports.SerialPort arduinoPort;
        private System.Windows.Forms.Label workout_name_label;
        private System.Windows.Forms.ProgressBar progressBarActuator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RTLabel;
        private System.Windows.Forms.TextBox RTDisp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown endPosSelect;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button incPosButton;
        private System.Windows.Forms.Button decPosButton;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label positionDisplayLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox startMarker;
        private System.Windows.Forms.PictureBox stopMarker;
    }
}