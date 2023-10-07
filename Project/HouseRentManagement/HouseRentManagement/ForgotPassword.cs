using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using HouseRentManagement.HRMcontextDB;
using System.Web.UI.WebControls;

namespace HouseRentManagement
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private string captchaText;

        public static byte[] encryptData(String data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }

        public static string md5(String data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }

        public String randomString()
        {
            Random rnd = new Random();
            int number = rnd.Next(10000, 99999);
            string text = md5(number.ToString());
            text = text.ToUpper();
            text = text.Substring(0, 6);
            return text;

        }

        private Bitmap drawImage(string txt, int w, int h)
        {
            Bitmap bt = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bt);
            SolidBrush sb = new SolidBrush(Color.White);

            g.FillRectangle(sb, 0, 0, bt.Width, bt.Height);
            System.Drawing.Font font = new System.Drawing.Font("Tahoma", 30);
            sb = new SolidBrush(Color.Blue);
            g.DrawString(txt, font, sb, bt.Width / 2 - (txt.Length / 2) * font.Size, (bt.Height / 2) - font.Size);

            //Tạo hiệu ứng cho captcha
            //vẽ dấu chấm

            int count = 0;

            Random rand = new Random();
            while (count < 1000)
            {
                sb = new SolidBrush(Color.YellowGreen);
                g.FillEllipse(sb, rand.Next(0, bt.Width), rand.Next(0, bt.Height), 4, 2);
                count++;
            }
            count = 0;
            //vẽ đường gạch ngang
            while (count < 25)
            {
                g.DrawLine(new Pen(Color.Pink), rand.Next(0, bt.Width), rand.Next(0, bt.Height), rand.Next(0, bt.Width), rand.Next(0, bt.Height));
                count++;
            }
            //End tạo hiệu ứng
            return bt;
        }

        private void Reset()
        {
            captchaText = this.randomString();
            txtCaptcha.Text = "";
            // vẽ captcha lên panel 1
            pnlCaptcha.BackgroundImage = drawImage(captchaText, pnlCaptcha.Width, pnlCaptcha.Height);
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new Model1();

            string username = txtBoxUsername.Text;


            if (string.IsNullOrEmpty(txtCaptcha.Text) || string.IsNullOrEmpty(txtBoxUsername.Text))
            {
                MessageBox.Show("Please Enter Full Information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return;
            }

            if (txtCaptcha.Text != captchaText)
            {
                MessageBox.Show ("Wrong Captcha","Notice",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return;
            }

            var user = context.USERS.FirstOrDefault(a => a.MaTheCuDan == username && txtCaptcha.Text == captchaText);

            if (user != null)
            {
                ChangePassword cp = new ChangePassword();
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Can't Find Username", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}

