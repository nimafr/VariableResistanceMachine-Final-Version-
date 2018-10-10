namespace TeamMusclesAndMachine
{
    partial class enter_name_screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.next_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.name_textfield = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 42F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Your Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next_button
            // 
            this.next_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next_button.BackColor = System.Drawing.Color.Transparent;
            this.next_button.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.next2;
            this.next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next_button.FlatAppearance.BorderSize = 0;
            this.next_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.next_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.Location = new System.Drawing.Point(740, 272);
            this.next_button.Margin = new System.Windows.Forms.Padding(0);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(130, 50);
            this.next_button.TabIndex = 4;
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
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
            this.back_button.Location = new System.Drawing.Point(30, 30);
            this.back_button.Margin = new System.Windows.Forms.Padding(0);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(130, 50);
            this.back_button.TabIndex = 5;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // name_textfield
            // 
            this.name_textfield.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_textfield.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textfield.Location = new System.Drawing.Point(327, 272);
            this.name_textfield.MaxLength = 24;
            this.name_textfield.Name = "name_textfield";
            this.name_textfield.Size = new System.Drawing.Size(384, 49);
            this.name_textfield.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "USER NAME";
            // 
            // enter_name_screen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.bg_app;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_textfield);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "enter_name_screen";
            this.Text = "enter_name_screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.TextBox name_textfield;
        private System.Windows.Forms.Label label2;
    }
}