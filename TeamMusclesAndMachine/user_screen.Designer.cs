namespace TeamMusclesAndMachine
{
    partial class user_screen
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
            this.title_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Bebas Neue", 56F, System.Drawing.FontStyle.Bold);
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(0, 30);
            this.title_label.Margin = new System.Windows.Forms.Padding(0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(1386, 90);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Choose a User";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.BackColor = System.Drawing.Color.Transparent;
            this.add_button.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.add_user;
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.add_button.Location = new System.Drawing.Point(1186, 588);
            this.add_button.Margin = new System.Windows.Forms.Padding(0);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(200, 200);
            this.add_button.TabIndex = 2;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete_button.BackColor = System.Drawing.Color.Transparent;
            this.delete_button.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.delete_user;
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.delete_button.Location = new System.Drawing.Point(0, 588);
            this.delete_button.Margin = new System.Windows.Forms.Padding(0);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(200, 200);
            this.delete_button.TabIndex = 3;
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // user_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.bg_app;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.title_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "user_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
    }
}