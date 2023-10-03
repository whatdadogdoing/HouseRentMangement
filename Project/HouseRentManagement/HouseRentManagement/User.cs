using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Profile;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class User : DevExpress.XtraEditors.XtraForm
    {
        
        public User()
        {
            InitializeComponent();
            ShowHomepageForm();
        }

        private Dictionary<string, Form> childForms;
        private ChildFormManager formManager = new ChildFormManager();
        private void ShowProfileForm()
        {
            if (formManager.CurrentChildForm is ProfileUser)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Form profileForm = new ProfileUser();
            formManager.ShowChildForm(pnlUser, profileForm);
        }
        private void ShowHomepageForm()
        {
            if (formManager.CurrentChildForm is Homepage)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Form homepageForm = new Homepage();
            formManager.ShowChildForm(pnlUser, homepageForm);
        }
        private void ShowPaymentForm()
        {
            if (formManager.CurrentChildForm is Payment)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Form paymentForm = new Payment();
            formManager.ShowChildForm(pnlUser, paymentForm);
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (!(formManager.CurrentChildForm is ProfileUser))
            {
                ShowProfileForm();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void btnCondoServices_Click(object sender, EventArgs e)
        {

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {

        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            if (!(formManager.CurrentChildForm is Homepage))
            {
                ShowHomepageForm();
            }
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            if (!(formManager.CurrentChildForm is Payment))
            {
                ShowPaymentForm();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}