using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public class ChildFormManager
    {
        private Form currentChildForm;

        public Form CurrentChildForm
        {
            get { return currentChildForm; }
        }

        public void ShowChildForm(Control parent, Form childForm)
        {
            CloseCurrentChildForm();

            currentChildForm = childForm;

            childForm.TopLevel = false;
            parent.Controls.Add(childForm);
            childForm.Show();
        }

        public void CloseCurrentChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

    }
}
