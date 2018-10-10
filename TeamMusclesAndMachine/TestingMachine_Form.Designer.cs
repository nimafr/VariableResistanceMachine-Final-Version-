namespace TeamMusclesAndMachine
{
    partial class TestingMachine_Form
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
            this.userControl11 = new TeamMusclesAndMachine.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Silver;
            this.userControl11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Margin = new System.Windows.Forms.Padding(0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(812, 531);
            this.userControl11.TabIndex = 0;
            // 
            // TestingMachine_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 530);
            this.Controls.Add(this.userControl11);
            this.Name = "TestingMachine_Form";
            this.Text = "TestingMachine_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
    }
}