namespace HouseRentManagement
{
    partial class ResidentCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentCard));
            this.lblProfileUser = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlProfileUser = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProfileUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfileUser
            // 
            this.lblProfileUser.AllowParentOverrides = false;
            this.lblProfileUser.AutoEllipsis = false;
            this.lblProfileUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProfileUser.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblProfileUser.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileUser.ForeColor = System.Drawing.Color.White;
            this.lblProfileUser.Location = new System.Drawing.Point(10, 2);
            this.lblProfileUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblProfileUser.Name = "lblProfileUser";
            this.lblProfileUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProfileUser.Size = new System.Drawing.Size(289, 54);
            this.lblProfileUser.TabIndex = 0;
            this.lblProfileUser.Text = "RESIDENT CARD";
            this.lblProfileUser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProfileUser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlProfileUser
            // 
            this.pnlProfileUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.pnlProfileUser.Controls.Add(this.lblProfileUser);
            this.pnlProfileUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileUser.Location = new System.Drawing.Point(0, 0);
            this.pnlProfileUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlProfileUser.Name = "pnlProfileUser";
            this.pnlProfileUser.Size = new System.Drawing.Size(873, 79);
            this.pnlProfileUser.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(72, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 15;
            // 
            // ResidentCard
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProfileUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::HouseRentManagement.Properties.Resources.appLogo16x16;
            this.Name = "ResidentCard";
            this.Text = "ResidentCard";
            this.pnlProfileUser.ResumeLayout(false);
            this.pnlProfileUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lblProfileUser;
        private Guna.UI2.WinForms.Guna2Panel pnlProfileUser;
        private System.Windows.Forms.Panel panel1;
    }
}