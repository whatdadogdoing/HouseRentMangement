using HouseRentManagement.dbQLCC;
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
        private ChildFormManager formManager = new ChildFormManager();
        public Admin()
        {
            InitializeComponent();
            showHomepageForm();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ShowContractForm()
        {
            if ( formManager.CurrentChildForm is Contract)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Contract contractForm = new Contract();
            formManager.ShowChildForm(pnlAdmin, contractForm);
        }
        private void btnContract_Click(object sender, EventArgs e)
        {
          ShowContractForm();   
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

        private void btnVehicleCard_Click(object sender, EventArgs e)
        {
           ShowVehicleCard();
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

        private void btnCondo_Click(object sender, EventArgs e)
        {
            ShowCondoAdmin();
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

        private void btnHomepage_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}
