using HouseRentManagement.HRMcontextDB;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class ChangePassword : Form
    {
        private string username;

        public ChangePassword(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            var context = new Model2();
            //định dạng mật khẩu phải có từ 8-16 kí tự và phải có ít nhất 1 số 
            string pattern = @"^(?=.*?[0-9])(?=.*?[a-zA-Z]).{8,16}$";
            Regex rg = new Regex(pattern);

            string newPass = txtNewPassword.Text;
            string comPass = txtEditConfirmPassword.Text;

            try
            {
                // Tìm người dùng trong cơ sở dữ liệu
                var user = context.USERS.FirstOrDefault(u => u.MaTheCuDan == username);
                if (!rg.IsMatch(newPass) || !rg.IsMatch(comPass))
                {
                    MessageBox.Show("Password must be between 8-22 characters and have at least 1 number", "Notice", MessageBoxButtons.OK);
                    return;
                }
                if (txtEditConfirmPassword.Text != txtNewPassword.Text)
                {
                    MessageBox.Show("Password mismatch", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (user != null)
                {
                    // Cập nhật mật khẩu mới
                    user.MatKhau = txtNewPassword.Text;
                    context.SaveChanges();

                    MessageBox.Show("The password has been changed successfully!", "Notice", MessageBoxButtons.OK);

                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The user does not exis!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

    }
}