using System.Windows.Forms;

namespace TeamMusclesAndMachine
{
    partial class UserControl_MoveMotor
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
            this.AutoButton = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.posTextBox = new System.Windows.Forms.TextBox();
            this.DecelTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.AccelTextBox = new System.Windows.Forms.TextBox();
            this.AccelerationLabel = new System.Windows.Forms.Label();
            this.enableButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.haltMoveButton = new System.Windows.Forms.Button();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.motorMoveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(52, 7);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(208, 32);
            this.AutoButton.TabIndex = 42;
            this.AutoButton.Text = "Auto Move Motor";
            this.AutoButton.Click += new System.EventHandler(this.AutoMoveButton_Click);
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(236, 127);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(82, 16);
            this.Label8.TabIndex = 41;
            this.Label8.Text = "counts/s^2";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(236, 55);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(71, 16);
            this.Label6.TabIndex = 39;
            this.Label6.Text = "counts/s";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(236, 87);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(82, 16);
            this.Label7.TabIndex = 40;
            this.Label7.Text = "counts/s^2";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(236, 207);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 16);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "counts";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(236, 167);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 16);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "counts";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(20, 207);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(136, 16);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Actual Position";
            // 
            // posTextBox
            // 
            this.posTextBox.Location = new System.Drawing.Point(156, 207);
            this.posTextBox.Name = "posTextBox";
            this.posTextBox.ReadOnly = true;
            this.posTextBox.Size = new System.Drawing.Size(72, 20);
            this.posTextBox.TabIndex = 35;
            this.posTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DecelTextBox
            // 
            this.DecelTextBox.Location = new System.Drawing.Point(156, 127);
            this.DecelTextBox.Name = "DecelTextBox";
            this.DecelTextBox.Size = new System.Drawing.Size(72, 20);
            this.DecelTextBox.TabIndex = 34;
            this.DecelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(20, 127);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Deceleration";
            // 
            // AccelTextBox
            // 
            this.AccelTextBox.Location = new System.Drawing.Point(156, 87);
            this.AccelTextBox.Name = "AccelTextBox";
            this.AccelTextBox.Size = new System.Drawing.Size(72, 20);
            this.AccelTextBox.TabIndex = 32;
            this.AccelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AccelerationLabel
            // 
            this.AccelerationLabel.Location = new System.Drawing.Point(20, 87);
            this.AccelerationLabel.Name = "AccelerationLabel";
            this.AccelerationLabel.Size = new System.Drawing.Size(100, 23);
            this.AccelerationLabel.TabIndex = 31;
            this.AccelerationLabel.Text = "Acceleration";
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(4, 247);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(88, 24);
            this.enableButton.TabIndex = 30;
            this.enableButton.Text = "Amp Disable";
            this.enableButton.Click += new System.EventHandler(this.motorEnableButton_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(20, 167);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 16);
            this.Label2.TabIndex = 29;
            this.Label2.Text = "Move Distance ";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Location = new System.Drawing.Point(156, 167);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(72, 20);
            this.DistanceTextBox.TabIndex = 28;
            this.DistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.Location = new System.Drawing.Point(156, 55);
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(72, 20);
            this.VelocityTextBox.TabIndex = 24;
            this.VelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // haltMoveButton
            // 
            this.haltMoveButton.Location = new System.Drawing.Point(219, 247);
            this.haltMoveButton.Name = "haltMoveButton";
            this.haltMoveButton.Size = new System.Drawing.Size(88, 24);
            this.haltMoveButton.TabIndex = 27;
            this.haltMoveButton.Text = "Stop Motor";
            this.haltMoveButton.Click += new System.EventHandler(this.motorStopMoveButton_Click);
            // 
            // velocityLabel
            // 
            this.velocityLabel.Location = new System.Drawing.Point(20, 55);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(64, 16);
            this.velocityLabel.TabIndex = 26;
            this.velocityLabel.Text = "Velocity";
            // 
            // motorMoveButton
            // 
            this.motorMoveButton.Enabled = false;
            this.motorMoveButton.Location = new System.Drawing.Point(116, 247);
            this.motorMoveButton.Name = "motorMoveButton";
            this.motorMoveButton.Size = new System.Drawing.Size(80, 24);
            this.motorMoveButton.TabIndex = 25;
            this.motorMoveButton.Text = "Move Motor";
            this.motorMoveButton.Click += new System.EventHandler(this.motorMoveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AutoButton);
            this.panel1.Controls.Add(this.Label8);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.Label7);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.posTextBox);
            this.panel1.Controls.Add(this.DecelTextBox);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.AccelTextBox);
            this.panel1.Controls.Add(this.AccelerationLabel);
            this.panel1.Controls.Add(this.enableButton);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.DistanceTextBox);
            this.panel1.Controls.Add(this.VelocityTextBox);
            this.panel1.Controls.Add(this.haltMoveButton);
            this.panel1.Controls.Add(this.velocityLabel);
            this.panel1.Controls.Add(this.motorMoveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 318);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserControl_MoveMotor
            // 
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_MoveMotor";
            this.Size = new System.Drawing.Size(344, 318);
            this.Load += new System.EventHandler(this.MotorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button AutoButton;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox posTextBox;
        internal System.Windows.Forms.TextBox DecelTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox AccelTextBox;
        internal System.Windows.Forms.Label AccelerationLabel;
        internal System.Windows.Forms.Button enableButton;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox DistanceTextBox;
        internal System.Windows.Forms.TextBox VelocityTextBox;
        internal System.Windows.Forms.Button haltMoveButton;
        internal System.Windows.Forms.Label velocityLabel;
        internal System.Windows.Forms.Button motorMoveButton;
        private Panel panel1;
    }
    
}
