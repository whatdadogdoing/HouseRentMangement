namespace HouseRentManagement
{
    partial class ReportRoomResidenceAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportRoomResidenceAdmin));
            this.pnlRRReport = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.clCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChuSoHuu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlRRReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRRReport
            // 
            this.pnlRRReport.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlRRReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRRReport.BackgroundImage")));
            this.pnlRRReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRRReport.BorderColor = System.Drawing.Color.Transparent;
            this.pnlRRReport.BorderRadius = 3;
            this.pnlRRReport.BorderThickness = 1;
            this.pnlRRReport.Controls.Add(this.dgvDB);
            this.pnlRRReport.Controls.Add(this.bunifuPanel1);
            this.pnlRRReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRRReport.Location = new System.Drawing.Point(0, 0);
            this.pnlRRReport.Name = "pnlRRReport";
            this.pnlRRReport.ShowBorders = true;
            this.pnlRRReport.Size = new System.Drawing.Size(800, 450);
            this.pnlRRReport.TabIndex = 0;
            // 
            // dgvDB
            // 
            this.dgvDB.AllowUserToAddRows = false;
            this.dgvDB.AllowUserToDeleteRows = false;
            this.dgvDB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCanHo,
            this.clTang,
            this.clTinhTrang,
            this.clNguoiThue,
            this.clChuSoHuu,
            this.clLoai});
            this.dgvDB.Location = new System.Drawing.Point(7, 111);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.ReadOnly = true;
            this.dgvDB.RowHeadersVisible = false;
            this.dgvDB.Size = new System.Drawing.Size(785, 336);
            this.dgvDB.TabIndex = 4;
            // 
            // clCanHo
            // 
            this.clCanHo.HeaderText = "MaCanHo";
            this.clCanHo.Name = "clCanHo";
            this.clCanHo.ReadOnly = true;
            this.clCanHo.Width = 130;
            // 
            // clTang
            // 
            this.clTang.HeaderText = "Tang";
            this.clTang.Name = "clTang";
            this.clTang.ReadOnly = true;
            this.clTang.Width = 130;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.HeaderText = "TinhTrang";
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.ReadOnly = true;
            this.clTinhTrang.Width = 130;
            // 
            // clNguoiThue
            // 
            this.clNguoiThue.HeaderText = "NguoiThue";
            this.clNguoiThue.Name = "clNguoiThue";
            this.clNguoiThue.ReadOnly = true;
            this.clNguoiThue.Width = 130;
            // 
            // clChuSoHuu
            // 
            this.clChuSoHuu.HeaderText = "ChuSoHuu";
            this.clChuSoHuu.Name = "clChuSoHuu";
            this.clChuSoHuu.ReadOnly = true;
            this.clChuSoHuu.Width = 130;
            // 
            // clLoai
            // 
            this.clLoai.HeaderText = "Loai";
            this.clLoai.Name = "clLoai";
            this.clLoai.ReadOnly = true;
            this.clLoai.Width = 130;
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
            this.bunifuPanel1.Size = new System.Drawing.Size(800, 63);
            this.bunifuPanel1.TabIndex = 1;
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
            this.bunifuLabel1.Size = new System.Drawing.Size(188, 32);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Report of Condos";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ReportRoomResidenceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRRReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportRoomResidenceAdmin";
            this.Text = "ReportAdmin";
            this.Load += new System.EventHandler(this.ReportRoomResidenceAdmin_Load);
            this.pnlRRReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlRRReport;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChuSoHuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoai;
    }
}