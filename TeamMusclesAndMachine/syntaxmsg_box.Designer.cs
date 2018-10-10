namespace TeamMusclesAndMachine
{
    partial class syntaxmsg_box
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
            this.ok_button = new MaterialSkin.Controls.MaterialFlatButton();
            this.title_label = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.AutoSize = true;
            this.ok_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ok_button.BackColor = System.Drawing.Color.Red;
            this.ok_button.Depth = 0;
            this.ok_button.FlatAppearance.BorderSize = 2;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(350, 279);
            this.ok_button.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.ok_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_button.Name = "ok_button";
            this.ok_button.Primary = false;
            this.ok_button.Size = new System.Drawing.Size(53, 36);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK         ";
            this.ok_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Depth = 0;
            this.title_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title_label.Location = new System.Drawing.Point(176, 105);
            this.title_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(119, 37);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Choose";
            // 
            // syntaxmsg_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(746, 379);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.ok_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(3500, 5500);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "syntaxmsg_box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "okmsg_box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton ok_button;
        private MaterialSkin.Controls.MaterialLabel title_label;
    }
}