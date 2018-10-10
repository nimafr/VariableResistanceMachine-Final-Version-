namespace TeamMusclesAndMachine
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.motorEnabledButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.enableStatusLabel = new System.Windows.Forms.Label();
            this.moveStatusLabel = new System.Windows.Forms.Label();
            this.motorProgressBar = new System.Windows.Forms.ProgressBar();
            this.motorMoveButton = new System.Windows.Forms.Button();
            this.motorStopButton = new System.Windows.Forms.Button();
            this.progLabel = new System.Windows.Forms.Label();
            this.motorAutoMove = new System.Windows.Forms.Button();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.accLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.motorConnectLabel = new System.Windows.Forms.Label();
            this.ready_Label = new System.Windows.Forms.Label();
            this.initLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.canChannelOption = new System.Windows.Forms.NumericUpDown();
            this.canLabel = new System.Windows.Forms.Label();
            this.velTextBox = new System.Windows.Forms.NumericUpDown();
            this.accTextBox = new System.Windows.Forms.NumericUpDown();
            this.distTextBox = new System.Windows.Forms.NumericUpDown();
            this.motorStartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canChannelOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // motorEnabledButton
            // 
            this.motorEnabledButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.motorEnabledButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorEnabledButton.Location = new System.Drawing.Point(20, 135);
            this.motorEnabledButton.Name = "motorEnabledButton";
            this.motorEnabledButton.Size = new System.Drawing.Size(150, 35);
            this.motorEnabledButton.TabIndex = 5;
            this.motorEnabledButton.TabStop = false;
            this.motorEnabledButton.Text = "Motor Enable";
            this.motorEnabledButton.UseVisualStyleBackColor = true;
            this.motorEnabledButton.Click += new System.EventHandler(this.enableMotorButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.statusLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(180, 30);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(200, 50);
            this.statusLabel.TabIndex = 101;
            this.statusLabel.Text = "Motor Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enableStatusLabel
            // 
            this.enableStatusLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.enableStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enableStatusLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableStatusLabel.Location = new System.Drawing.Point(180, 128);
            this.enableStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.enableStatusLabel.Name = "enableStatusLabel";
            this.enableStatusLabel.Size = new System.Drawing.Size(200, 40);
            this.enableStatusLabel.TabIndex = 20;
            this.enableStatusLabel.Text = "enabled_status";
            this.enableStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moveStatusLabel
            // 
            this.moveStatusLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.moveStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moveStatusLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveStatusLabel.Location = new System.Drawing.Point(180, 171);
            this.moveStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.moveStatusLabel.Name = "moveStatusLabel";
            this.moveStatusLabel.Size = new System.Drawing.Size(200, 40);
            this.moveStatusLabel.TabIndex = 30;
            this.moveStatusLabel.Text = "move_status";
            this.moveStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moveStatusLabel.Click += new System.EventHandler(this.moveStatusLabel_Click);
            // 
            // motorProgressBar
            // 
            this.motorProgressBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.motorProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.motorProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.motorProgressBar.Location = new System.Drawing.Point(0, 497);
            this.motorProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.motorProgressBar.Maximum = 99;
            this.motorProgressBar.Name = "motorProgressBar";
            this.motorProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.motorProgressBar.Size = new System.Drawing.Size(812, 34);
            this.motorProgressBar.Step = 1;
            this.motorProgressBar.TabIndex = 102;
            this.motorProgressBar.Value = 30;
            // 
            // motorMoveButton
            // 
            this.motorMoveButton.Location = new System.Drawing.Point(20, 175);
            this.motorMoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.motorMoveButton.Name = "motorMoveButton";
            this.motorMoveButton.Size = new System.Drawing.Size(150, 35);
            this.motorMoveButton.TabIndex = 6;
            this.motorMoveButton.TabStop = false;
            this.motorMoveButton.Text = "Move";
            this.motorMoveButton.UseVisualStyleBackColor = true;
            this.motorMoveButton.Click += new System.EventHandler(this.motorMoveButton_Click);
            // 
            // motorStopButton
            // 
            this.motorStopButton.Location = new System.Drawing.Point(20, 215);
            this.motorStopButton.Margin = new System.Windows.Forms.Padding(0);
            this.motorStopButton.Name = "motorStopButton";
            this.motorStopButton.Size = new System.Drawing.Size(150, 35);
            this.motorStopButton.TabIndex = 7;
            this.motorStopButton.TabStop = false;
            this.motorStopButton.Text = "Stop";
            this.motorStopButton.UseVisualStyleBackColor = true;
            this.motorStopButton.Click += new System.EventHandler(this.motorStopButton_Click);
            // 
            // progLabel
            // 
            this.progLabel.AutoSize = true;
            this.progLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progLabel.Location = new System.Drawing.Point(0, 474);
            this.progLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progLabel.Name = "progLabel";
            this.progLabel.Size = new System.Drawing.Size(153, 23);
            this.progLabel.TabIndex = 7;
            this.progLabel.Text = "Actuator Progress";
            // 
            // motorAutoMove
            // 
            this.motorAutoMove.Location = new System.Drawing.Point(20, 255);
            this.motorAutoMove.Margin = new System.Windows.Forms.Padding(5);
            this.motorAutoMove.Name = "motorAutoMove";
            this.motorAutoMove.Size = new System.Drawing.Size(150, 35);
            this.motorAutoMove.TabIndex = 8;
            this.motorAutoMove.TabStop = false;
            this.motorAutoMove.Text = "Auto Move Loop";
            this.motorAutoMove.UseVisualStyleBackColor = true;
            this.motorAutoMove.Click += new System.EventHandler(this.motorAutoMove_Click);
            // 
            // velocityLabel
            // 
            this.velocityLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.velocityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.velocityLabel.Font = new System.Drawing.Font("AunchantedExpandedBoldOblique", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityLabel.Location = new System.Drawing.Point(549, 33);
            this.velocityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(200, 50);
            this.velocityLabel.TabIndex = 13;
            this.velocityLabel.Text = "SPEED";
            this.velocityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.velocityLabel.Click += new System.EventHandler(this.velocityLabel_Click);
            // 
            // accLabel
            // 
            this.accLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.accLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accLabel.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accLabel.Location = new System.Drawing.Point(497, 187);
            this.accLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accLabel.Name = "accLabel";
            this.accLabel.Size = new System.Drawing.Size(140, 47);
            this.accLabel.TabIndex = 14;
            this.accLabel.Text = "Acceleration";
            this.accLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // distanceLabel
            // 
            this.distanceLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.distanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distanceLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(497, 240);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(140, 47);
            this.distanceLabel.TabIndex = 16;
            this.distanceLabel.Text = "Distance";
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // motorConnectLabel
            // 
            this.motorConnectLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.motorConnectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motorConnectLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorConnectLabel.Location = new System.Drawing.Point(180, 85);
            this.motorConnectLabel.Margin = new System.Windows.Forms.Padding(0);
            this.motorConnectLabel.Name = "motorConnectLabel";
            this.motorConnectLabel.Size = new System.Drawing.Size(200, 40);
            this.motorConnectLabel.TabIndex = 17;
            this.motorConnectLabel.Text = "connect_status";
            this.motorConnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ready_Label
            // 
            this.ready_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ready_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ready_Label.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready_Label.Location = new System.Drawing.Point(180, 227);
            this.ready_Label.Margin = new System.Windows.Forms.Padding(0);
            this.ready_Label.Name = "ready_Label";
            this.ready_Label.Size = new System.Drawing.Size(200, 40);
            this.ready_Label.TabIndex = 22;
            this.ready_Label.Text = "ready_error_status";
            this.ready_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initLabel
            // 
            this.initLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.initLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initLabel.Location = new System.Drawing.Point(180, 267);
            this.initLabel.Margin = new System.Windows.Forms.Padding(0);
            this.initLabel.Name = "initLabel";
            this.initLabel.Size = new System.Drawing.Size(200, 40);
            this.initLabel.TabIndex = 23;
            this.initLabel.Text = "initialize_status";
            this.initLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectButton
            // 
            this.connectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(20, 95);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(150, 35);
            this.connectButton.TabIndex = 4;
            this.connectButton.TabStop = false;
            this.connectButton.Text = "Motor Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // canChannelOption
            // 
            this.canChannelOption.Location = new System.Drawing.Point(20, 53);
            this.canChannelOption.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.canChannelOption.Name = "canChannelOption";
            this.canChannelOption.Size = new System.Drawing.Size(77, 27);
            this.canChannelOption.TabIndex = 9;
            this.canChannelOption.TabStop = false;
            this.canChannelOption.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // canLabel
            // 
            this.canLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canLabel.Location = new System.Drawing.Point(17, 23);
            this.canLabel.Margin = new System.Windows.Forms.Padding(0);
            this.canLabel.Name = "canLabel";
            this.canLabel.Size = new System.Drawing.Size(98, 27);
            this.canLabel.TabIndex = 27;
            this.canLabel.Text = "CAN Channel";
            this.canLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // velTextBox
            // 
            this.velTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.velTextBox.Font = new System.Drawing.Font("AunchantedExpandedBoldOblique", 52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velTextBox.Location = new System.Drawing.Point(549, 86);
            this.velTextBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.velTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.velTextBox.Name = "velTextBox";
            this.velTextBox.ReadOnly = true;
            this.velTextBox.Size = new System.Drawing.Size(200, 77);
            this.velTextBox.TabIndex = 0;
            this.velTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.velTextBox.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.velTextBox.ValueChanged += new System.EventHandler(this.velTextBox_ValueChanged);
            // 
            // accTextBox
            // 
            this.accTextBox.Font = new System.Drawing.Font("AunchantedExpandedBoldOblique", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accTextBox.Location = new System.Drawing.Point(640, 186);
            this.accTextBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.accTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.accTextBox.Name = "accTextBox";
            this.accTextBox.ReadOnly = true;
            this.accTextBox.Size = new System.Drawing.Size(109, 45);
            this.accTextBox.TabIndex = 1;
            this.accTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accTextBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // distTextBox
            // 
            this.distTextBox.Font = new System.Drawing.Font("AunchantedExpandedBoldOblique", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distTextBox.Location = new System.Drawing.Point(640, 239);
            this.distTextBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.distTextBox.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.distTextBox.Name = "distTextBox";
            this.distTextBox.Size = new System.Drawing.Size(110, 45);
            this.distTextBox.TabIndex = 2;
            this.distTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.distTextBox.ValueChanged += new System.EventHandler(this.distTextBox_ValueChanged);
            // 
            // motorStartButton
            // 
            this.motorStartButton.BackColor = System.Drawing.Color.Transparent;
            this.motorStartButton.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.Start_button;
            this.motorStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.motorStartButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.motorStartButton.FlatAppearance.BorderSize = 0;
            this.motorStartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.motorStartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.motorStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motorStartButton.ForeColor = System.Drawing.Color.Transparent;
            this.motorStartButton.Location = new System.Drawing.Point(549, 289);
            this.motorStartButton.Name = "motorStartButton";
            this.motorStartButton.Size = new System.Drawing.Size(200, 200);
            this.motorStartButton.TabIndex = 12;
            this.motorStartButton.TabStop = false;
            this.motorStartButton.UseVisualStyleBackColor = false;
            this.motorStartButton.Click += new System.EventHandler(this.motorStartButton_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.distTextBox);
            this.Controls.Add(this.accTextBox);
            this.Controls.Add(this.velTextBox);
            this.Controls.Add(this.canLabel);
            this.Controls.Add(this.canChannelOption);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.motorStartButton);
            this.Controls.Add(this.initLabel);
            this.Controls.Add(this.ready_Label);
            this.Controls.Add(this.motorConnectLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.accLabel);
            this.Controls.Add(this.velocityLabel);
            this.Controls.Add(this.motorAutoMove);
            this.Controls.Add(this.progLabel);
            this.Controls.Add(this.motorStopButton);
            this.Controls.Add(this.motorMoveButton);
            this.Controls.Add(this.motorProgressBar);
            this.Controls.Add(this.moveStatusLabel);
            this.Controls.Add(this.enableStatusLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.motorEnabledButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(812, 531);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canChannelOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button motorEnabledButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label enableStatusLabel;
        private System.Windows.Forms.Label moveStatusLabel;
        private System.Windows.Forms.ProgressBar motorProgressBar;
        private System.Windows.Forms.Button motorMoveButton;
        private System.Windows.Forms.Button motorStopButton;
        private System.Windows.Forms.Label progLabel;
        private System.Windows.Forms.Button motorAutoMove;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label accLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label motorConnectLabel;
        private System.Windows.Forms.Label ready_Label;
        private System.Windows.Forms.Label initLabel;
        private System.Windows.Forms.Button motorStartButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.NumericUpDown canChannelOption;
        private System.Windows.Forms.Label canLabel;
        private System.Windows.Forms.NumericUpDown velTextBox;
        private System.Windows.Forms.NumericUpDown accTextBox;
        private System.Windows.Forms.NumericUpDown distTextBox;
    }
}
