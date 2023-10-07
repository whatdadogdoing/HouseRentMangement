namespace HouseRentManagement
{
    partial class ChangePassword
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
            this.btnResetPassword = new DevExpress.XtraEditors.SimpleButton();
            this.txtEditConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(122, 193);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(151, 34);
            this.btnResetPassword.TabIndex = 19;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // txtEditConfirmPassword
            // 
            this.txtEditConfirmPassword.EditValue = "Confirm Password";
            this.txtEditConfirmPassword.Location = new System.Drawing.Point(122, 143);
            this.txtEditConfirmPassword.Name = "txtEditConfirmPassword";
            this.txtEditConfirmPassword.Size = new System.Drawing.Size(324, 34);
            this.txtEditConfirmPassword.TabIndex = 18;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.EditValue = "New Password";
            this.txtNewPassword.Location = new System.Drawing.Point(122, 103);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(324, 34);
            this.txtNewPassword.TabIndex = 17;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.txtEditConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.txtEditConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnResetPassword;
        private DevExpress.XtraEditors.TextEdit txtEditConfirmPassword;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
    }
}