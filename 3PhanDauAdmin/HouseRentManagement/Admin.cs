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
    public partial class pnlAdmin : DevExpress.XtraEditors.XtraForm
    {
  
        private ChildFormManager formManager = new ChildFormManager();
        public pnlAdmin()
        {
            InitializeComponent();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

      

        private void pnlAdmin_Load(object sender, EventArgs e)
        {

        }
    }
    
}
