using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class Admin : DevExpress.XtraEditors.XtraForm
    {
        private ChildFormManager formManager = new ChildFormManager();
        private string username;
        public Admin(string username)
        {
            InitializeComponent();
            showHomepageForm();
            this.username = username;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
        
        private void ShowContractForm()
        {
            if (formManager.CurrentChildForm is Contract)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Contract contractForm = new Contract();
            formManager.ShowChildForm(pnlAdmin, contractForm);
        }


        private void ShowVehicleCard()
        {

            if (formManager.CurrentChildForm is VehicleCard)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            VehicleCard vehicleForm = new VehicleCard();
            formManager.ShowChildForm(pnlAdmin, vehicleForm);
        }

        private void ShowCondoAdmin()
        {
            if (formManager.CurrentChildForm is CondoAdmin)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            CondoAdmin condoAdminForm = new CondoAdmin();
            formManager.ShowChildForm(pnlAdmin, condoAdminForm);
        }
        private void ShowPriceForm()
        {
            if (formManager.CurrentChildForm is PriceAdmin)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            PriceAdmin pa = new PriceAdmin();
            formManager.ShowChildForm(pnlAdmin, pa);
        }
        private void ShowReportForm()
        {
            if (formManager.CurrentChildForm is ReportAdminForm)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportAdminForm ra = new ReportAdminForm();
            formManager.ShowChildForm(pnlAdmin, ra);
        }
        private void ShowExportForm()
        {
            if (formManager.CurrentChildForm is ExportAdmin)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ExportAdmin ea = new ExportAdmin();
            formManager.ShowChildForm(pnlAdmin, ea);
        }
        private void showHomepageForm()
        {
            if (formManager.CurrentChildForm is Homepage)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Homepage homepageForm = new Homepage();
            formManager.ShowChildForm(pnlAdmin, homepageForm);
        }
        private void ShowResidentCard()
        {

            if (formManager.CurrentChildForm is Resident_Card)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Resident_Card resident_Card = new Resident_Card();
            formManager.ShowChildForm(pnlAdmin, resident_Card);
        }

        private void ShowEmployee()
        {
            if (formManager.CurrentChildForm is Employee)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Employee employee = new Employee();
            formManager.ShowChildForm(pnlAdmin, employee);
        }
        private void ShowProfileAdmin()
        {
            if (formManager.CurrentChildForm is ProfileAdmin)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ProfileAdmin profileAdmin = new ProfileAdmin();
            formManager.ShowChildForm(pnlAdmin, profileAdmin);
        }
        private void btnCondo_Click(object sender, EventArgs e)
        {
            ShowCondoAdmin();
        }

        private void btnVehicleCard_Click(object sender, EventArgs e)
        {
            ShowVehicleCard();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            showHomepageForm();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            ShowContractForm();
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowProfileAdmin();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        private void btnResidentCard_Click(object sender, EventArgs e)
        {
            ShowResidentCard();
        }
    }
    
}
