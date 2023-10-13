using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class Admin : DevExpress.XtraEditors.XtraForm
    {
        private ChildFormManager fformManeger = new ChildFormManager();
        public Admin()
        {
            InitializeComponent();
            
        }
        private void ShowPriceForm()
        {
            if(fformManeger.CurrentChildForm is PriceAdmin)
            {
                return;
            }
            fformManeger.CloseCurrentChildForm();
            PriceAdmin pa = new PriceAdmin();
            fformManeger.ShowChildForm(pnlAdmin, pa);
        }
        private void ShowReportForm()
        {
            if (fformManeger.CurrentChildForm is ReportAdminForm)
            {
                return;
            }
            fformManeger.CloseCurrentChildForm();
            ReportAdminForm ra = new ReportAdminForm();
            fformManeger.ShowChildForm(pnlAdmin, ra);
        }
        private void ShowExportForm()
        {
            if (fformManeger.CurrentChildForm is ExportAdmin)
            {
                return;
            }
            fformManeger.CloseCurrentChildForm();
            ExportAdmin ea = new ExportAdmin();
            fformManeger.ShowChildForm(pnlAdmin, ea);
        }
        private void btnPrice_Click(object sender, EventArgs e)
        {
            ShowPriceForm();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowReportForm();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ShowExportForm();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

    }

}
