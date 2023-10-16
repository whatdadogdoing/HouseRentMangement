namespace HouseRentManagement
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnlPayment = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlAddPayment = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.btnPay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAmount = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnPayment = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalAmount = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTransactions = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtBoxSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.clhPaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhMaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPayment.SuspendLayout();
            this.pnlAddPayment.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.pnlPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPayment.BackgroundImage")));
            this.pnlPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPayment.BorderColor = System.Drawing.Color.Transparent;
            this.pnlPayment.BorderRadius = 3;
            this.pnlPayment.BorderThickness = 1;
            this.pnlPayment.Controls.Add(this.pnlAddPayment);
            this.pnlPayment.Controls.Add(this.dgvPayment);
            this.pnlPayment.Controls.Add(this.txtBoxSearch);
            this.pnlPayment.Controls.Add(this.btnPayment);
            this.pnlPayment.Controls.Add(this.bunifuPanel2);
            this.pnlPayment.Controls.Add(this.bunifuPanel1);
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPayment.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPayment.ForeColor = System.Drawing.Color.White;
            this.pnlPayment.Location = new System.Drawing.Point(0, 0);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.ShowBorders = true;
            this.pnlPayment.Size = new System.Drawing.Size(956, 613);
            this.pnlPayment.TabIndex = 0;
            // 
            // pnlAddPayment
            // 
            this.pnlAddPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddPayment.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddPayment.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAddPayment.BorderRadius = 1;
            this.pnlAddPayment.BorderThickness = 1;
            this.pnlAddPayment.Controls.Add(this.btnPay);
            this.pnlAddPayment.Controls.Add(this.btnCancel);
            this.pnlAddPayment.Controls.Add(this.txtBoxAmount);
            this.pnlAddPayment.Controls.Add(this.txtBoxDescription);
            this.pnlAddPayment.Controls.Add(this.lblDescription);
            this.pnlAddPayment.Controls.Add(this.lblAmount);
            this.pnlAddPayment.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlAddPayment.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnlAddPayment.Location = new System.Drawing.Point(592, 53);
            this.pnlAddPayment.Name = "pnlAddPayment";
            this.pnlAddPayment.PanelColor = System.Drawing.Color.Transparent;
            this.pnlAddPayment.PanelColor2 = System.Drawing.Color.Transparent;
            this.pnlAddPayment.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnlAddPayment.ShadowDept = 2;
            this.pnlAddPayment.ShadowDepth = 5;
            this.pnlAddPayment.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.pnlAddPayment.ShadowTopLeftVisible = false;
            this.pnlAddPayment.Size = new System.Drawing.Size(350, 271);
            this.pnlAddPayment.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnlAddPayment.TabIndex = 5;
            this.pnlAddPayment.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.ActiveBorderThickness = 1;
            this.btnPay.ActiveCornerRadius = 20;
            this.btnPay.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
            this.btnPay.ActiveForecolor = System.Drawing.Color.White;
            this.btnPay.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPay.BackgroundImage")));
            this.btnPay.ButtonText = "Pay";
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.IdleBorderThickness = 1;
            this.btnPay.IdleCornerRadius = 20;
            this.btnPay.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(15)))));
            this.btnPay.IdleForecolor = System.Drawing.Color.White;
            this.btnPay.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(15)))));
            this.btnPay.Location = new System.Drawing.Point(267, 217);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(65, 40);
            this.btnPay.TabIndex = 7;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.IdleForecolor = System.Drawing.Color.White;
            this.btnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(196, 217);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(14, 45);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(318, 34);
            this.txtBoxAmount.TabIndex = 6;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(14, 106);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(318, 104);
            this.txtBoxDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AllowParentOverrides = false;
            this.lblDescription.AutoEllipsis = false;
            this.lblDescription.CursorType = null;
            this.lblDescription.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(14, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(76, 20);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblAmount
            // 
            this.lblAmount.AllowParentOverrides = false;
            this.lblAmount.AutoEllipsis = false;
            this.lblAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAmount.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblAmount.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(14, 19);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmount.Size = new System.Drawing.Size(53, 20);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAmount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnPayment
            // 
            this.btnPayment.ActiveBorderThickness = 1;
            this.btnPayment.ActiveCornerRadius = 20;
            this.btnPayment.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(199)))), ((int)(((byte)(21)))));
            this.btnPayment.ActiveForecolor = System.Drawing.Color.White;
            this.btnPayment.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(199)))), ((int)(((byte)(21)))));
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayment.BackgroundImage")));
            this.btnPayment.ButtonText = "Add Payment";
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.IdleBorderThickness = 1;
            this.btnPayment.IdleCornerRadius = 20;
            this.btnPayment.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(199)))), ((int)(((byte)(21)))));
            this.btnPayment.IdleForecolor = System.Drawing.Color.White;
            this.btnPayment.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(199)))), ((int)(((byte)(21)))));
            this.btnPayment.Location = new System.Drawing.Point(817, 5);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(125, 40);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel2.Controls.Add(this.lblTotalAmount);
            this.bunifuPanel2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel2.ForeColor = System.Drawing.Color.White;
            this.bunifuPanel2.Location = new System.Drawing.Point(227, 3);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(200, 90);
            this.bunifuPanel2.TabIndex = 0;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(173, 50);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(15, 37);
            this.bunifuLabel3.TabIndex = 0;
            this.bunifuLabel3.Text = "0";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AllowParentOverrides = false;
            this.lblTotalAmount.AutoEllipsis = false;
            this.lblTotalAmount.CursorType = null;
            this.lblTotalAmount.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(3, 3);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalAmount.Size = new System.Drawing.Size(162, 37);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "Total Amount";
            this.lblTotalAmount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalAmount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel1.Controls.Add(this.lblTransactions);
            this.bunifuPanel1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel1.ForeColor = System.Drawing.Color.White;
            this.bunifuPanel1.Location = new System.Drawing.Point(12, 3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(200, 90);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(173, 50);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(15, 37);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "0";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTransactions
            // 
            this.lblTransactions.AllowParentOverrides = false;
            this.lblTransactions.AutoEllipsis = false;
            this.lblTransactions.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTransactions.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTransactions.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactions.ForeColor = System.Drawing.Color.White;
            this.lblTransactions.Location = new System.Drawing.Point(3, 3);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTransactions.Size = new System.Drawing.Size(147, 37);
            this.lblTransactions.TabIndex = 0;
            this.lblTransactions.Text = "Transactions";
            this.lblTransactions.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTransactions.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.AcceptsReturn = false;
            this.txtBoxSearch.AcceptsTab = false;
            this.txtBoxSearch.AnimationSpeed = 200;
            this.txtBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBoxSearch.BackgroundImage")));
            this.txtBoxSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBoxSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBoxSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBoxSearch.BorderRadius = 1;
            this.txtBoxSearch.BorderThickness = 1;
            this.txtBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.DefaultFont = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.DefaultText = "";
            this.txtBoxSearch.FillColor = System.Drawing.Color.White;
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearch.HideSelection = true;
            this.txtBoxSearch.IconLeft = global::HouseRentManagement.Properties.Resources.btnSearch;
            this.txtBoxSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.IconPadding = 10;
            this.txtBoxSearch.IconRight = null;
            this.txtBoxSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(3, 126);
            this.txtBoxSearch.MaxLength = 32767;
            this.txtBoxSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBoxSearch.Modified = false;
            this.txtBoxSearch.Multiline = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearch.OnIdleState = stateProperties4;
            this.txtBoxSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearch.PlaceholderText = "Search Payment";
            this.txtBoxSearch.ReadOnly = false;
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.ShortcutsEnabled = true;
            this.txtBoxSearch.Size = new System.Drawing.Size(260, 43);
            this.txtBoxSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBoxSearch.TabIndex = 33;
            this.txtBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxSearch.TextMarginBottom = 0;
            this.txtBoxSearch.TextMarginLeft = 3;
            this.txtBoxSearch.TextMarginTop = 0;
            this.txtBoxSearch.TextPlaceholder = "Search Payment";
            this.txtBoxSearch.UseSystemPasswordChar = false;
            this.txtBoxSearch.WordWrap = true;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clhPaymentID,
            this.clhNgayLap,
            this.clhTongTien,
            this.clhTrangThai,
            this.clhMaCanHo});
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPayment.Location = new System.Drawing.Point(0, 175);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.Size = new System.Drawing.Size(956, 438);
            this.dgvPayment.TabIndex = 34;
            // 
            // clhPaymentID
            // 
            this.clhPaymentID.HeaderText = "Payment ID";
            this.clhPaymentID.MinimumWidth = 6;
            this.clhPaymentID.Name = "clhPaymentID";
            this.clhPaymentID.ReadOnly = true;
            this.clhPaymentID.Width = 125;
            // 
            // clhNgayLap
            // 
            this.clhNgayLap.HeaderText = "Create Date";
            this.clhNgayLap.MinimumWidth = 6;
            this.clhNgayLap.Name = "clhNgayLap";
            this.clhNgayLap.ReadOnly = true;
            this.clhNgayLap.Width = 125;
            // 
            // clhTongTien
            // 
            this.clhTongTien.HeaderText = "Total Money";
            this.clhTongTien.MinimumWidth = 6;
            this.clhTongTien.Name = "clhTongTien";
            this.clhTongTien.ReadOnly = true;
            this.clhTongTien.Width = 125;
            // 
            // clhTrangThai
            // 
            this.clhTrangThai.HeaderText = "Status";
            this.clhTrangThai.MinimumWidth = 6;
            this.clhTrangThai.Name = "clhTrangThai";
            this.clhTrangThai.ReadOnly = true;
            this.clhTrangThai.Width = 125;
            // 
            // clhMaCanHo
            // 
            this.clhMaCanHo.HeaderText = "Condo ID";
            this.clhMaCanHo.MinimumWidth = 6;
            this.clhMaCanHo.Name = "clhMaCanHo";
            this.clhMaCanHo.ReadOnly = true;
            this.clhMaCanHo.Width = 125;
            // 
            // Payment
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 613);
            this.Controls.Add(this.pnlPayment);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::HouseRentManagement.Properties.Resources.appLogo;
            this.Name = "Payment";
            this.Text = "Payment";
            this.pnlPayment.ResumeLayout(false);
            this.pnlAddPayment.ResumeLayout(false);
            this.pnlAddPayment.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblTransactions;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalAmount;
        private Bunifu.UI.WinForms.BunifuPanel pnlPayment;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnlAddPayment;
        private Bunifu.UI.WinForms.BunifuLabel lblDescription;
        private Bunifu.UI.WinForms.BunifuLabel lblAmount;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPayment;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPay;
        private Bunifu.UI.WinForms.BunifuTextBox txtBoxSearch;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhPaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhMaCanHo;
    }
}