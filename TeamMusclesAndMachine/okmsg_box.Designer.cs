namespace TeamMusclesAndMachine
{
    partial class okmsg_box
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ok_button.BackColor = System.Drawing.Color.Gray;
            this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ok_button.Depth = 0;
            this.ok_button.FlatAppearance.BorderSize = 2;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(110, 107);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ok_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_button.Name = "ok_button";
            this.ok_button.Primary = false;
            this.ok_button.Size = new System.Drawing.Size(50, 36);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK         ";
            this.ok_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(58, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(165, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Choose User To Delete";
            // 
            // okmsg_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(278, 168);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ok_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(3500, 5500);
            this.Name = "okmsg_box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "okmsg_box";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.okmsg_box_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton ok_button;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}