using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class ReportAdminForm : Form
    {
        public ReportAdminForm()
        {
            InitializeComponent();
            toolStripButton1.Checked = true;
            ShowReportCondo();
        }
        private ChildFormManager formManager = new ChildFormManager();
        private void ShowReportCondo()
        {
            if(formManager.CurrentChildForm is ReportRoomResidenceAdmin )
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportRoomResidenceAdmin rra = new ReportRoomResidenceAdmin();
            formManager.ShowChildForm(pnlReportAdmin, rra);
        }
        private void ShowReportMoney()
        {
            if (formManager.CurrentChildForm is ReportMoneyAdmin)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportMoneyAdmin ma = new ReportMoneyAdmin();
            formManager.ShowChildForm(pnlReportAdmin, ma);
        }
        private void ShowReportService()
        {
            if (formManager.CurrentChildForm is ReportServiceAdmin)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportServiceAdmin ca = new ReportServiceAdmin();
            formManager.ShowChildForm(pnlReportAdmin, ca);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ShowReportService();
            toolStripButton1.Checked = false; toolStripButton2.Checked = false;
            toolStripButton3.Checked = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowReportCondo();
            toolStripButton3.Checked = false; toolStripButton2.Checked = false;
            toolStripButton1.Checked = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ShowReportMoney();
            toolStripButton1.Checked = false; toolStripButton3.Checked = false;
            toolStripButton2.Checked = true;
        }
    }
    
}
