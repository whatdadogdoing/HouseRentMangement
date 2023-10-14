using DevExpress.XtraEditors;
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
    public partial class Payment : DevExpress.XtraEditors.XtraForm
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlAddPayment.Visible = !pnlAddPayment.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddPayment.Visible = false;
        }

<<<<<<< HEAD
        private void pnlPayment_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 42b9e71cf20aaf26e54db22f78b2643de5ef1b1d
    }
}