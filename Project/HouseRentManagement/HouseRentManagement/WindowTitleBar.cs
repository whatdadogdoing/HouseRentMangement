using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public class WindowTitleBar
    {
        // Import các hàm Win32 API
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        private static extern int RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Thay đổi màu sắc và hình dạng của thanh window
        public static void SetWin11TitleBar(Form form)
        {
            form.BackColor = Color.FromArgb(237, 234, 229);

            form.ForeColor = Color.Black;

            form.FormBorderStyle = FormBorderStyle.FixedSingle;

            form.MaximizeBox = false;
        }
        public static void SetRoundBorder(Form form, int radius)
        {
            Rectangle screenRectangle = Screen.PrimaryScreen.WorkingArea;
            int windowWidth = form.Width >= screenRectangle.Width ? screenRectangle.Width : form.Width;
            int windowHeight = form.Height >= screenRectangle.Height ? screenRectangle.Height : form.Height;

            Rectangle roundRect = new Rectangle(0, 0, windowWidth, windowHeight);

            Region roundRegion = Region.FromHrgn(CreateRoundRectRgn(0, 0, windowWidth, windowHeight, radius, radius));

            form.Region = roundRegion;
        }
    }
}