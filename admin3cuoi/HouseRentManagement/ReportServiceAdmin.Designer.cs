namespace HouseRentManagement
{
    partial class ReportServiceAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportServiceAdmin));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.clMaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoPhieuChuyenDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoPhieuThiCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhanHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongSoTienSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongSoTIenPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.dgvDB);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(800, 423);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Teal;
            this.bunifuPanel2.BorderRadius = 1;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 42);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(800, 63);
            this.bunifuPanel2.TabIndex = 4;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(193, 32);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Report of Services";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvDB
            // 
            this.dgvDB.AllowUserToAddRows = false;
            this.dgvDB.AllowUserToDeleteRows = false;
            this.dgvDB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaCanHo,
            this.clSoPhieuChuyenDo,
            this.clSoPhieuThiCong,
            this.clSuaChua,
            this.clPhat,
            this.clPhanHoi,
            this.clTongSoTienSuaChua,
            this.clTongSoTIenPhat});
            this.dgvDB.Location = new System.Drawing.Point(3, 111);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.ReadOnly = true;
            this.dgvDB.RowHeadersVisible = false;
            this.dgvDB.Size = new System.Drawing.Size(794, 312);
            this.dgvDB.TabIndex = 5;
            // 
            // clMaCanHo
            // 
            this.clMaCanHo.HeaderText = "MaCanHo";
            this.clMaCanHo.Name = "clMaCanHo";
            this.clMaCanHo.ReadOnly = true;
            // 
            // clSoPhieuChuyenDo
            // 
            this.clSoPhieuChuyenDo.HeaderText = "ChuyenDo";
            this.clSoPhieuChuyenDo.Name = "clSoPhieuChuyenDo";
            this.clSoPhieuChuyenDo.ReadOnly = true;
            this.clSoPhieuChuyenDo.Width = 70;
            // 
            // clSoPhieuThiCong
            // 
            this.clSoPhieuThiCong.HeaderText = "ThiCong";
            this.clSoPhieuThiCong.Name = "clSoPhieuThiCong";
            this.clSoPhieuThiCong.ReadOnly = true;
            this.clSoPhieuThiCong.Width = 70;
            // 
            // clSuaChua
            // 
            this.clSuaChua.HeaderText = "SuaChua";
            this.clSuaChua.Name = "clSuaChua";
            this.clSuaChua.ReadOnly = true;
            this.clSuaChua.Width = 70;
            // 
            // clPhat
            // 
            this.clPhat.HeaderText = "Phat";
            this.clPhat.Name = "clPhat";
            this.clPhat.ReadOnly = true;
            this.clPhat.Width = 70;
            // 
            // clPhanHoi
            // 
            this.clPhanHoi.HeaderText = "PhanHoi";
            this.clPhanHoi.Name = "clPhanHoi";
            this.clPhanHoi.ReadOnly = true;
            this.clPhanHoi.Width = 70;
            // 
            // clTongSoTienSuaChua
            // 
            this.clTongSoTienSuaChua.HeaderText = "TongSoTienSuaChua";
            this.clTongSoTienSuaChua.Name = "clTongSoTienSuaChua";
            this.clTongSoTienSuaChua.ReadOnly = true;
            this.clTongSoTienSuaChua.Width = 170;
            // 
            // clTongSoTIenPhat
            // 
            this.clTongSoTIenPhat.HeaderText = "TongSoTIenPhat";
            this.clTongSoTIenPhat.Name = "clTongSoTIenPhat";
            this.clTongSoTIenPhat.ReadOnly = true;
            this.clTongSoTIenPhat.Width = 170;
            // 
            // ReportServiceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportServiceAdmin";
            this.Text = "ReportCondoAdmin";
            this.Load += new System.EventHandler(this.ReportServiceAdmin_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.DataGridView dgvDB;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoPhieuChuyenDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoPhieuThiCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhanHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongSoTienSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongSoTIenPhat;
    }
}