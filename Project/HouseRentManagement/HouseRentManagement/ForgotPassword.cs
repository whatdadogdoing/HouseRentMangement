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
using System.Net.Mail;
using DevExpress.Utils.Svg;
using System.Net;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;
using System.Text.RegularExpressions;
using System.Security.Principal;
using DevExpress.XtraEditors.Filtering.Templates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Runtime.Remoting.Messaging;

namespace HouseRentManagement
{
    public partial class ForgotPassword : Form
    {
        public static ForgotPassword instance;
        private string mk;
        private string ten;
        private string email;
        public string Mk { get => mk; set => mk = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Email { get => email; set => email = value; }
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer aTimer;

        private bool isDragging = false;
        private Point startPoint;
        private string captchaText;
        private Random rd = new Random();

        DateTime date;
        int otp = 0;
        int atick = 90;


        public static byte[] encryptData(String data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }

        //Hàm mã hóa MD5 thành mảng byte, chuyển nó thành chuỗi hex rồi trả vè chuỗi MD5
        public static string md5(String data)
        {
            //Hàm mã hóa MD5 thành mảng byte, chuyển nó thành chuỗi hex rồi trả vè chuỗi MD5
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }

        public String randomString()
        {
            //Random số có 5 chữ số
            int number = rd.Next(10000, 99999);
            string text = md5(number.ToString());
            text = text.ToUpper();
            //Lấy kí tự đầu của chuỗi MD5 bằng substring()
            text = text.Substring(0, 6);
            return text;
        }

        //Vẽ captcha
        private Bitmap drawImage(string txt, int w, int h)
        {
            //Khởi tạo đối tượng Bitmap với kích thước w, h.
            Bitmap bt = new Bitmap(w, h);

            //Lấy đối tượng Graphics từ Bitmap để vẽ lên Bitmap.
            Graphics g = Graphics.FromImage(bt);

            //Tạo SolidBrush màu trắng để tô nền.
            SolidBrush sb = new SolidBrush(Color.White);

            //Gọi FillRectangle để tô toàn bộ Bitmap bằng màu trắng.
            g.FillRectangle(sb, 0, 0, bt.Width, bt.Height);

            System.Drawing.Font font = new System.Drawing.Font("Tahoma", 30);
            sb = new SolidBrush(Color.Blue);
            //Gọi DrawString để vẽ chuỗi txt lên giữa Bitmap, canh giữa bằng cách tính toán tọa độ x.
            //Tọa độ y là giữa Bitmap trừ đi chiều cao font.
            g.DrawString(txt, font, sb, bt.Width / 2 - (txt.Length / 2) * font.Size, (bt.Height / 2) - font.Size);

            //Tạo hiệu ứng cho captcha

            //vẽ dấu chấm
            int count = 0;
            while (count < 1000)
            {
                sb = new SolidBrush(Color.YellowGreen);
                g.FillEllipse(sb, rd.Next(0, bt.Width), rd.Next(0, bt.Height), 4, 2);
                count++;
            }
            count = 0;

            //vẽ đường gạch ngang
            while (count < 25)
            {
                g.DrawLine(new Pen(Color.Pink), rd.Next(0, bt.Width), rd.Next(0, bt.Height), rd.Next(0, bt.Width), rd.Next(0, bt.Height));
                count++;
            }
            //End tạo hiệu ứng
            return bt;
        }

               //Hàm khởi tạo lại captcha
        private void Reset()
        {
            captchaText = this.randomString();
            txtCaptcha.Text = "";
            // vẽ captcha lên panel 1
            pnlCaptcha.BackgroundImage = drawImage(captchaText, pnlCaptcha.Width, pnlCaptcha.Height);
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            lblTCheck.Hide();
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
        public bool CheckInfo() 
        {
            if (string.IsNullOrEmpty(txtCaptcha.Text) || string.IsNullOrEmpty(txtBoxUsername.Text) || string.IsNullOrEmpty(txtGetOTP.Text))
                return false;
            return true;
        }
        int t = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new Model2();

            string username = txtBoxUsername.Text;

            if (CheckInfo()==false)
            {
                MessageBox.Show("Please Enter Full Information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reset();
                return;
            }            
            if (int.Parse(txtGetOTP.Text) != otp)
            {
                MessageBox.Show("Wrong OTP", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetOTP.Text = "";
                return;
            }
            if (otp == 0)
            {
                MessageBox.Show("Please Get OTP", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Focus().ToString();
            }
            if ((DateTime.Now - Convert.ToDateTime(date)).TotalSeconds > 90)
            {
                MessageBox.Show("The OTP has expired", "Notice");
                atick = 90;
                return;
            }
            if (txtCaptcha.Text != captchaText)
            {
                MessageBox.Show ("Wrong Captcha","Notice",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return;
            }

            //tạo biến trỏ đến vị trí đầu tiên của DB ứng với biến username và kiểm tra đúng captcha
            var user = context.USERS.FirstOrDefault(a => a.MaTheCuDan == username && txtCaptcha.Text == captchaText);

            if (user != null && int.Parse(txtGetOTP.Text) == otp && txtCaptcha.Text == captchaText)
            {
                MessageBox.Show("Successful confirmation", "Notice");
                ChangePassword cp = new ChangePassword(username);
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Hàm di chuyển form
        private void ForgotPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }

        private void ForgotPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void ForgotPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        //Send OTP

        public int randomMaOTP()
        {
            Random random = new Random();
            int rdotp = random.Next(100000, 999999);
            return rdotp;
        }
        
        public void SendOTP(string nguoiGui, string nguoiNhan, int ma)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(nguoiGui);
            mail.To.Add(nguoiNhan);
            mail.Subject = "Get OTP for Change Password";
            mail.Body = ma.ToString();

            SmtpServer.EnableSsl = true;
            SmtpServer.Port = 587;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jungleuncleapartmentmanagement@gmail.com", "yjmi xxzk ljpr hamt");
            try
            {
                SmtpServer.Send(mail);
                MessageBox.Show("Successfully send OTP","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsValidEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            //ràng buộc phải @gmail.com
            string strRegex = @"^([a-zA-Z0-9]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(inputEmail))//nếu là re đúng vs định dạng thì true còn k thì false
                return (true);
            else
            {
                return (false);
            }
        }

        public bool checkMail(string chkmail)
        {
            Model2 md2 = new Model2();
            NGUOITHUE nt = md2.NGUOITHUE.FirstOrDefault(p => p.Email.ToString().Trim() == chkmail.ToString().Trim());

            if (nt != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void aTimer_Tick(object sender, EventArgs e)
        {
            atick--;
            if (atick == 0)
            {   
                aTimer.Stop();
                lblTCheck.Visible = false;
                btnGetOTP.Enabled = true;
                btnGetOTP.Visible = true;              
            }
            lblTCheck.Text = atick.ToString();
        }

        private void btnGetOTP_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Contains("@") && !txtEmail.Text.EndsWith(".") && IsValidEmail(txtEmail.Text))
            {
                if (checkMail(txtEmail.Text))
                {
                    otp = randomMaOTP();
                    date = DateTime.Now;
                    email = txtEmail.Text.Trim();
                    aTimer = new System.Windows.Forms.Timer(); //Khởi tạo đối tượng Timer mới
                    btnGetOTP.Enabled = false;//tắt chức năng của nút gửi mã OTP
                    aTimer.Tick += new EventHandler(aTimer_Tick); //Tạo sự kiện aTimer_Tick
                    aTimer.Interval = 1000; // thời gian ngắt quãng của Timer là 1 giây
                    aTimer.Start(); //Bắt đầu khởi động Timer
                    lblTCheck.Text = atick.ToString();
                    SendOTP("jungleuncleapartmentmanagement@gmail.com", email, otp);
                    btnGetOTP.Visible = false;
                    lblTCheck.Visible = true;
                }
                else
                {
                    MessageBox.Show("Mail does not exist in the system");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct format Email");
            }
        }
            
    }
}   


