using HouseRentManagement.HRMcontextDB;
using System;
using System.Linq;
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

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var context = new Model1();
            try
            {
                // Tìm người dùng trong cơ sở dữ liệu
                var user = context.USERS.FirstOrDefault(u => u.MaTheCuDan == username);

                if (user != null)
                {
                    // Cập nhật mật khẩu mới
                    user.MatKhau = txtNewPassword.Text;
                    context.SaveChanges();

                    MessageBox.Show("Mật khẩu đã được thay đổi thành công!");
                }
                else
                {
                    MessageBox.Show("Người dùng không tồn tại trong cơ sở dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}