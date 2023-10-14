using System;
using System.Windows.Forms;
using System.Drawing;

namespace HouseRentManagement
{
    public partial class Admin : DevExpress.XtraEditors.XtraForm
    {
        private string username;
        private ReportFormAdmin reportFormAdmin;
        private PriceForm priceForm;
        private ExportAdmin exportAdmin;
        private bool isDragging = false;
        private Point startPoint;
        public Admin(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        bool menuExpand = true;

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
        private void ShowReportForm()
        {
            if (reportFormAdmin == null)
            {
                reportFormAdmin = new ReportFormAdmin();
                reportFormAdmin.FormClosed += reportFormAdmin_FormClosed;
                reportFormAdmin.MdiParent = this;
                reportFormAdmin.Dock = DockStyle.Fill;
                reportFormAdmin.Show();
            }
            else
            {
                reportFormAdmin.Activate();
            }
        }
        private void reportFormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportFormAdmin = null;
        }
        private void ShowPriceForm()
        {
            if (reportFormAdmin == null)
            {
                priceForm = new PriceForm();
                priceForm.FormClosed += priceForm_FormClosed;
                priceForm.MdiParent = this;
                priceForm.Dock = DockStyle.Fill;
                priceForm.Show();
            }
            else
            {
                priceForm.Activate();
            }
        }

        private void priceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            priceForm = null;
        }
        private void ShowExportAdmin()
        {
            if (exportAdmin == null)
            {
                exportAdmin = new ExportAdmin();
                exportAdmin.FormClosed += exportAdmin_FormClosed;
                exportAdmin.MdiParent = this;
                exportAdmin.Dock = DockStyle.Fill;
                exportAdmin.Show();
            }
            else
            {
                exportAdmin.Activate();
            }
        }

        private void exportAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            exportAdmin = null;
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                if (pnlProfileLoad.Height + 5 >= 540)
                {
                    pnlProfileLoad.Height = 540;
                    menuTransition.Stop();
                    menuExpand = false;
                }
                else
                {
                    pnlProfileLoad.Height += 5;
                }
            }
            else
            {
                if (pnlProfileLoad.Height - 5 <= 54)
                {
                    pnlProfileLoad.Height = 54;
                    menuTransition.Stop();
                    menuExpand = true;
                }
                else
                {
                    pnlProfileLoad.Height -= 5;
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowReportForm();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            ShowPriceForm();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            ShowExportAdmin();
        }
    }

}
