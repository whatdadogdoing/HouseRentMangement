using DevExpress.XtraEditors;
using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HouseRentManagement
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private bool isDragging = false;
        private Point startPoint;
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new Model2();

            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter Full Login Information", "Notice",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please Enter Your Username", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter Your Password", "Notice", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            // Tìm thông tin trong bảng Users có thông tin trùng khớp
            var admin = context.ADMINS.FirstOrDefault(u => u.MaQL == username && u.MatKhau == password);

            var user = context.USERS.FirstOrDefault(a => a.MaTheCuDan == username && a.MatKhau == password);

            if (admin != null)
            {
               Admin ad = new Admin();
               ad.Show();
               this.Hide();
            }
            else if (user != null)
            {
                User us = new User();
                us.Show();
                this.Hide();
            }
            else
            {
                // Sai thông tin đăng nhập
                MessageBox.Show("Wrong Username or Password", "Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Text = txtBoxUsername.Text = string.Empty;
        }

        private void btnHideShowPass_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.PasswordChar == '*')
            {
                txtBoxPassword.PasswordChar = '\0';
            }
            else
            { 
                txtBoxPassword.PasswordChar = '*';
            }
        } 

        private void lblLinkForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword fgpw = new ForgotPassword();
            fgpw.Show();
            this.Hide();
        }
    }
}