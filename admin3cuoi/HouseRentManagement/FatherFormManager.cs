using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public class FatherFormManager
    {
        private Form currentFatherForm;
        public Form CurrentFatherForm { get { return currentFatherForm; } }
        public void ShowFatherForm(Control parent, Form fform)
        {
            CloseFatherForm();
            currentFatherForm = fform;
            fform.TopLevel = false;
            parent.Controls.Add(fform);
            fform.Show();
        }
        public void CloseFatherForm()
        {
            if(currentFatherForm != null)
            {
                currentFatherForm.Close();
            }
        }
    }
}
