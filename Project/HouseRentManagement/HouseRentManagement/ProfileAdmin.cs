using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class ProfileAdmin : Form
    {
        HRMContextDB context = new HRMContextDB();
        public ProfileAdmin()
        {
            InitializeComponent();
        }

        private void BindGrid(List<CHUSOHUU> lsChuSoHuu)
        {
            dgvDSPROFILE.Rows.Clear();
            foreach (var item in lsChuSoHuu)
            {
                int index = dgvDSPROFILE.Rows.Add();
                dgvDSPROFILE.Rows[index].Cells[0].Value = item.MaChuSoHuu;
                dgvDSPROFILE.Rows[index].Cells[1].Value = item.TenChuSoHuu;
                dgvDSPROFILE.Rows[index].Cells[2].Value = item.NgaySinh;
                dgvDSPROFILE.Rows[index].Cells[3].Value = item.CCCD;
                dgvDSPROFILE.Rows[index].Cells[4].Value = item.GioiTinh;
                dgvDSPROFILE.Rows[index].Cells[5].Value = item.SDT;
                dgvDSPROFILE.Rows[index].Cells[6].Value = item.Email;
            }
        }
       
        private void ProfileAdmin_Load_1(object sender, EventArgs e)
        {
            List<CHUSOHUU> lsChuSoHuu = context.CHUSOHUUs.ToList();
            BindGrid(lsChuSoHuu);
        }

        
    }
}
