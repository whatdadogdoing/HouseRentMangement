namespace HouseRentManagement
{
    partial class ReportMoneyAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMoneyAdmin));
            this.pnlMoney = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.clSoHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhiTIen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTuNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDenNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTIen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMoney
            // 
            this.pnlMoney.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlMoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMoney.BackgroundImage")));
            this.pnlMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMoney.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlMoney.BorderRadius = 3;
            this.pnlMoney.BorderThickness = 1;
            this.pnlMoney.Controls.Add(this.dgvDB);
            this.pnlMoney.Controls.Add(this.bunifuPanel1);
            this.pnlMoney.Location = new System.Drawing.Point(0, 0);
            this.pnlMoney.Name = "pnlMoney";
            this.pnlMoney.ShowBorders = true;
            this.pnlMoney.Size = new System.Drawing.Size(801, 450);
            this.pnlMoney.TabIndex = 3;
            // 
            // dgvDB
            // 
            this.dgvDB.AllowUserToAddRows = false;
            this.dgvDB.AllowUserToDeleteRows = false;
            this.dgvDB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSoHoaDon,
            this.clMaCanHo,
            this.clPhiTIen,
            this.clTuNgay,
            this.clDenNgay,
            this.clNgayLap,
            this.clGiaTien,
            this.clSoLuong,
            this.clDonViTinh,
            this.clThanhTIen,
            this.clTongTien,
            this.clTrangThai,
            this.clGhiChu});
            this.dgvDB.Location = new System.Drawing.Point(0, 111);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.ReadOnly = true;
            this.dgvDB.RowHeadersVisible = false;
            this.dgvDB.Size = new System.Drawing.Size(800, 339);
            this.dgvDB.TabIndex = 3;
            // 
            // clSoHoaDon
            // 
            this.clSoHoaDon.HeaderText = "SoHoaDon";
            this.clSoHoaDon.Name = "clSoHoaDon";
            this.clSoHoaDon.ReadOnly = true;
            // 
            // clMaCanHo
            // 
            this.clMaCanHo.HeaderText = "MaCanHo";
            this.clMaCanHo.Name = "clMaCanHo";
            this.clMaCanHo.ReadOnly = true;
            // 
            // clPhiTIen
            // 
            this.clPhiTIen.HeaderText = "PhiTien";
            this.clPhiTIen.Name = "clPhiTIen";
            this.clPhiTIen.ReadOnly = true;
            this.clPhiTIen.Width = 170;
            // 
            // clTuNgay
            // 
            this.clTuNgay.HeaderText = "TuNgay";
            this.clTuNgay.Name = "clTuNgay";
            this.clTuNgay.ReadOnly = true;
            this.clTuNgay.Width = 150;
            // 
            // clDenNgay
            // 
            this.clDenNgay.HeaderText = "DenNgay";
            this.clDenNgay.Name = "clDenNgay";
            this.clDenNgay.ReadOnly = true;
            this.clDenNgay.Width = 150;
            // 
            // clNgayLap
            // 
            this.clNgayLap.HeaderText = "NgayLap";
            this.clNgayLap.Name = "clNgayLap";
            this.clNgayLap.ReadOnly = true;
            this.clNgayLap.Width = 150;
            // 
            // clGiaTien
            // 
            this.clGiaTien.HeaderText = "GiaTien";
            this.clGiaTien.Name = "clGiaTien";
            this.clGiaTien.ReadOnly = true;
            this.clGiaTien.Width = 150;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "SoLuong";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.HeaderText = "DonViTinh";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.ReadOnly = true;
            // 
            // clThanhTIen
            // 
            this.clThanhTIen.HeaderText = "ThanhTien";
            this.clThanhTIen.Name = "clThanhTIen";
            this.clThanhTIen.ReadOnly = true;
            this.clThanhTIen.Width = 150;
            // 
            // clTongTien
            // 
            this.clTongTien.HeaderText = "TongTien";
            this.clTongTien.Name = "clTongTien";
            this.clTongTien.ReadOnly = true;
            this.clTongTien.Width = 150;
            // 
            // clTrangThai
            // 
            this.clTrangThai.HeaderText = "TrangThai";
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.ReadOnly = true;
            // 
            // clGhiChu
            // 
            this.clGhiChu.HeaderText = "GhiChu";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            this.clGhiChu.Width = 300;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Teal;
            this.bunifuPanel1.BorderRadius = 1;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 42);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(801, 63);
            this.bunifuPanel1.TabIndex = 2;
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
            this.bunifuLabel1.Size = new System.Drawing.Size(155, 32);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Report of Fees";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ReportMoneyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportMoneyAdmin";
            this.Text = "ReportMoneyAdmin";
            this.Load += new System.EventHandler(this.ReportMoneyAdmin_Load);
            this.pnlMoney.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel pnlMoney;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhiTIen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDenNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTIen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
    }
}