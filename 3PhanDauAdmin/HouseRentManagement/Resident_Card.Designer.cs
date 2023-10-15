namespace HouseRentManagement
{
    partial class Resident_Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resident_Card));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlProfileUser = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProfileUser = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txttenantID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSEARCH = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtExDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDELETE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUPDATE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnADD = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTenantIDCard = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvDSReCard = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.TenantIDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlProfileUser.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSReCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProfileUser
            // 
            this.pnlProfileUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.pnlProfileUser.Controls.Add(this.lblProfileUser);
            this.pnlProfileUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileUser.Location = new System.Drawing.Point(0, 0);
            this.pnlProfileUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlProfileUser.Name = "pnlProfileUser";
            this.pnlProfileUser.Size = new System.Drawing.Size(1015, 79);
            this.pnlProfileUser.TabIndex = 6;
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
            this.lblProfileUser.Size = new System.Drawing.Size(231, 45);
            this.lblProfileUser.TabIndex = 0;
            this.lblProfileUser.Text = "RESIDENT CARD";
            this.lblProfileUser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProfileUser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Controls.Add(this.dtpNgayLap);
            this.guna2Panel1.Controls.Add(this.txttenantID);
            this.guna2Panel1.Controls.Add(this.btnSEARCH);
            this.guna2Panel1.Controls.Add(this.txtExDate);
            this.guna2Panel1.Controls.Add(this.btnDELETE);
            this.guna2Panel1.Controls.Add(this.btnUPDATE);
            this.guna2Panel1.Controls.Add(this.btnADD);
            this.guna2Panel1.Controls.Add(this.txtTenantIDCard);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(118, 103);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(792, 249);
            this.guna2Panel1.TabIndex = 7;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Checked = true;
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayLap.Location = new System.Drawing.Point(171, 106);
            this.dtpNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(206, 29);
            this.dtpNgayLap.TabIndex = 13;
            this.dtpNgayLap.Value = new System.DateTime(2023, 10, 12, 22, 40, 50, 375);
            // 
            // txttenantID
            // 
            this.txttenantID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenantID.DefaultText = "";
            this.txttenantID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenantID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenantID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenantID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenantID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenantID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttenantID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenantID.Location = new System.Drawing.Point(524, 107);
            this.txttenantID.Name = "txttenantID";
            this.txttenantID.PasswordChar = '\0';
            this.txttenantID.PlaceholderText = "";
            this.txttenantID.SelectedText = "";
            this.txttenantID.Size = new System.Drawing.Size(146, 33);
            this.txttenantID.TabIndex = 1;
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.ActiveBorderThickness = 1;
            this.btnSEARCH.ActiveCornerRadius = 20;
            this.btnSEARCH.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSEARCH.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSEARCH.ActiveLineColor = System.Drawing.Color.Red;
            this.btnSEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnSEARCH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSEARCH.BackgroundImage")));
            this.btnSEARCH.ButtonText = "SEARCH";
            this.btnSEARCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSEARCH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEARCH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSEARCH.IdleBorderThickness = 1;
            this.btnSEARCH.IdleCornerRadius = 20;
            this.btnSEARCH.IdleFillColor = System.Drawing.Color.Red;
            this.btnSEARCH.IdleForecolor = System.Drawing.Color.White;
            this.btnSEARCH.IdleLineColor = System.Drawing.Color.LightCoral;
            this.btnSEARCH.Location = new System.Drawing.Point(686, 181);
            this.btnSEARCH.Margin = new System.Windows.Forms.Padding(5);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(92, 52);
            this.btnSEARCH.TabIndex = 9;
            this.btnSEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExDate
            // 
            this.txtExDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExDate.DefaultText = "";
            this.txtExDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExDate.Location = new System.Drawing.Point(524, 15);
            this.txtExDate.Name = "txtExDate";
            this.txtExDate.PasswordChar = '\0';
            this.txtExDate.PlaceholderText = "";
            this.txtExDate.SelectedText = "";
            this.txtExDate.Size = new System.Drawing.Size(146, 33);
            this.txtExDate.TabIndex = 1;
            // 
            // btnDELETE
            // 
            this.btnDELETE.ActiveBorderThickness = 1;
            this.btnDELETE.ActiveCornerRadius = 20;
            this.btnDELETE.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnDELETE.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDELETE.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnDELETE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDELETE.BackgroundImage")));
            this.btnDELETE.ButtonText = "DELETE";
            this.btnDELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDELETE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDELETE.IdleBorderThickness = 1;
            this.btnDELETE.IdleCornerRadius = 20;
            this.btnDELETE.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDELETE.IdleForecolor = System.Drawing.Color.White;
            this.btnDELETE.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDELETE.Location = new System.Drawing.Point(354, 181);
            this.btnDELETE.Margin = new System.Windows.Forms.Padding(5);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(102, 52);
            this.btnDELETE.TabIndex = 10;
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.ActiveBorderThickness = 1;
            this.btnUPDATE.ActiveCornerRadius = 20;
            this.btnUPDATE.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnUPDATE.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUPDATE.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnUPDATE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUPDATE.BackgroundImage")));
            this.btnUPDATE.ButtonText = "UPDATE";
            this.btnUPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUPDATE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUPDATE.IdleBorderThickness = 1;
            this.btnUPDATE.IdleCornerRadius = 20;
            this.btnUPDATE.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUPDATE.IdleForecolor = System.Drawing.Color.White;
            this.btnUPDATE.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUPDATE.Location = new System.Drawing.Point(183, 181);
            this.btnUPDATE.Margin = new System.Windows.Forms.Padding(5);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(108, 52);
            this.btnUPDATE.TabIndex = 11;
            this.btnUPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnADD
            // 
            this.btnADD.ActiveBorderThickness = 1;
            this.btnADD.ActiveCornerRadius = 20;
            this.btnADD.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnADD.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnADD.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnADD.BackgroundImage")));
            this.btnADD.ButtonText = "ADD";
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnADD.IdleBorderThickness = 1;
            this.btnADD.IdleCornerRadius = 20;
            this.btnADD.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnADD.IdleForecolor = System.Drawing.Color.White;
            this.btnADD.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnADD.Location = new System.Drawing.Point(29, 181);
            this.btnADD.Margin = new System.Windows.Forms.Padding(5);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(104, 52);
            this.btnADD.TabIndex = 12;
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtTenantIDCard
            // 
            this.txtTenantIDCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenantIDCard.DefaultText = "";
            this.txtTenantIDCard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenantIDCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenantIDCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenantIDCard.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenantIDCard.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenantIDCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenantIDCard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenantIDCard.Location = new System.Drawing.Point(171, 14);
            this.txtTenantIDCard.Name = "txtTenantIDCard";
            this.txtTenantIDCard.PasswordChar = '\0';
            this.txtTenantIDCard.PlaceholderText = "";
            this.txtTenantIDCard.SelectedText = "";
            this.txtTenantIDCard.Size = new System.Drawing.Size(191, 33);
            this.txtTenantIDCard.TabIndex = 1;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(400, 107);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(73, 23);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Tenant ID";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(40, 106);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(111, 23);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Card Insurance";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(400, 16);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(114, 23);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Expiration Date";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(111, 23);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Tenant ID Card";
            // 
            // dgvDSReCard
            // 
            this.dgvDSReCard.AllowCustomTheming = false;
            this.dgvDSReCard.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDSReCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSReCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSReCard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.dgvDSReCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSReCard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSReCard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSReCard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSReCard.ColumnHeadersHeight = 40;
            this.dgvDSReCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenantIDCard,
            this.CardInsurance,
            this.ExpirationDate,
            this.TenantID});
            this.dgvDSReCard.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDSReCard.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDSReCard.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDSReCard.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDSReCard.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDSReCard.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDSReCard.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDSReCard.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDSReCard.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDSReCard.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSReCard.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvDSReCard.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDSReCard.CurrentTheme.Name = null;
            this.dgvDSReCard.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSReCard.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDSReCard.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDSReCard.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDSReCard.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSReCard.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSReCard.EnableHeadersVisualStyles = false;
            this.dgvDSReCard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDSReCard.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDSReCard.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDSReCard.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDSReCard.Location = new System.Drawing.Point(31, 408);
            this.dgvDSReCard.Name = "dgvDSReCard";
            this.dgvDSReCard.RowHeadersVisible = false;
            this.dgvDSReCard.RowTemplate.Height = 40;
            this.dgvDSReCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSReCard.Size = new System.Drawing.Size(920, 264);
            this.dgvDSReCard.TabIndex = 13;
            this.dgvDSReCard.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // TenantIDCard
            // 
            this.TenantIDCard.HeaderText = "Tenant ID Card";
            this.TenantIDCard.Name = "TenantIDCard";
            // 
            // CardInsurance
            // 
            this.CardInsurance.HeaderText = "Card Insurance";
            this.CardInsurance.Name = "CardInsurance";
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.Name = "ExpirationDate";
            // 
            // TenantID
            // 
            this.TenantID.HeaderText = "Tenant ID";
            this.TenantID.Name = "TenantID";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(532, 193);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(137, 39);
            this.txtSearch.TabIndex = 14;
            // 
            // Resident_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1015, 884);
            this.Controls.Add(this.dgvDSReCard);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlProfileUser);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resident_Card";
            this.Text = "Resident_Card";
            this.Load += new System.EventHandler(this.Resident_Card_Load);
            this.pnlProfileUser.ResumeLayout(false);
            this.pnlProfileUser.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSReCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlProfileUser;
        private Bunifu.UI.WinForms.BunifuLabel lblProfileUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSEARCH;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDELETE;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUPDATE;
        private Bunifu.Framework.UI.BunifuThinButton2 btnADD;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txttenantID;
        private Guna.UI2.WinForms.Guna2TextBox txtExDate;
        private Guna.UI2.WinForms.Guna2TextBox txtTenantIDCard;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDSReCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantIDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}