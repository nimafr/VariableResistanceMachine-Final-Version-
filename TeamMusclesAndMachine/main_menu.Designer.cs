namespace TeamMusclesAndMachine
{
    partial class main_menu
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
            this.logout_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.workout_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.Transparent;
            this.logout_button.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.logout;
            this.logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logout_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.Location = new System.Drawing.Point(30, 30);
            this.logout_button.Margin = new System.Windows.Forms.Padding(0);
            this.logout_button.Name = "logout_button";
            this.logout_button.Padding = new System.Windows.Forms.Padding(10);
            this.logout_button.Size = new System.Drawing.Size(130, 50);
            this.logout_button.TabIndex = 0;
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // history_button
            // 
            this.history_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.history_button.BackColor = System.Drawing.Color.Orange;
            this.history_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.history_button.Font = new System.Drawing.Font("Bebas Neue", 52F);
            this.history_button.Image = global::TeamMusclesAndMachine.Properties.Resources.data;
            this.history_button.Location = new System.Drawing.Point(311, 179);
            this.history_button.Margin = new System.Windows.Forms.Padding(2);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(300, 500);
            this.history_button.TabIndex = 1;
            this.history_button.Text = "WORKOUT\r\nHISTORY";
            this.history_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.history_button.UseVisualStyleBackColor = false;
            this.history_button.Click += new System.EventHandler(this.history_button_Click);
            // 
            // workout_button
            // 
            this.workout_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workout_button.BackColor = System.Drawing.Color.LawnGreen;
            this.workout_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workout_button.Font = new System.Drawing.Font("Bebas Neue", 52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workout_button.Image = global::TeamMusclesAndMachine.Properties.Resources.dumbbell;
            this.workout_button.Location = new System.Drawing.Point(713, 179);
            this.workout_button.Margin = new System.Windows.Forms.Padding(2);
            this.workout_button.Name = "workout_button";
            this.workout_button.Size = new System.Drawing.Size(300, 500);
            this.workout_button.TabIndex = 2;
            this.workout_button.Text = "BEGIN\r\nWORKOUT";
            this.workout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.workout_button.UseVisualStyleBackColor = false;
            this.workout_button.Click += new System.EventHandler(this.workout_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_button.BackColor = System.Drawing.Color.Transparent;
            this.settings_button.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.settings;
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settings_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.Location = new System.Drawing.Point(1200, 30);
            this.settings_button.Margin = new System.Windows.Forms.Padding(2);
            this.settings_button.Name = "settings_button";
            this.settings_button.Padding = new System.Windows.Forms.Padding(10);
            this.settings_button.Size = new System.Drawing.Size(130, 50);
            this.settings_button.TabIndex = 3;
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome, ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(343, 30);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(195, 57);
            this.welcome_label.TabIndex = 6;
            this.welcome_label.Text = "user_name";
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // main_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TeamMusclesAndMachine.Properties.Resources.bg_app2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.workout_button);
            this.Controls.Add(this.history_button);
            this.Controls.Add(this.logout_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main_menu";
            this.Text = "main_menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Button workout_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome_label;
    }
}