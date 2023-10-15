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
    public partial class Resident_Card : Form
    {
        HRMContextDB context = new HRMContextDB();
        public Resident_Card()
        {
            InitializeComponent();
        }

        private void BindGrid(List<THECUDAN> lsTheCuDan)
        {
            dgvDSReCard.Rows.Clear();
            foreach (var item in lsTheCuDan)
            {
                int index = dgvDSReCard.Rows.Add();
                dgvDSReCard.Rows[index].Cells[0].Value = item.MaTheCuDan;
                dgvDSReCard.Rows[index].Cells[1].Value = item.NgayLap;
                dgvDSReCard.Rows[index].Cells[2].Value = item.HSD;
                dgvDSReCard.Rows[index].Cells[3].Value = item.MaNguoiThue;

            }
        }

        private void Resident_Card_Load(object sender, EventArgs e)
        {
            List<NGUOITHUE> lsNguoiThue = context.NGUOITHUEs.ToList();
            List<THECUDAN> lsTheCuDan = context.THECUDANs.ToList();
            BindGrid(lsTheCuDan);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckTenantIDCard(txtTenantIDCard.Text) == -1) // -1 để là sinh viên mới
                {
                    THECUDAN newthecudan = new THECUDAN();
                    newthecudan.MaTheCuDan = txtTenantIDCard.Text;
                    newthecudan.NgayLap = DateTime.Now;
                    newthecudan.HSD = int.Parse(txtExDate.Text);
                    newthecudan.MaNguoiThue = txttenantID.Text;

                    context.THECUDANs.AddOrUpdate(newthecudan);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Thêm thẻ cư dân {newthecudan.MaTheCuDan} vào danh sách thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"Thẻ cư dân có mã số {txtTenantIDCard.Text} đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private int CheckTenantIDCard(string TenantIDCard)
        {
            int length = dgvDSReCard.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvDSReCard.Rows[i].Cells[0].Value != null)
                    if (dgvDSReCard.Rows[i].Cells[0].Value.ToString() == TenantIDCard)
                        return i;
            }
            return -1;
        }

        private void LoaddgvDSSV()
        {
            List<THECUDAN> newthecudan = context.THECUDANs.ToList();
            BindGrid(newthecudan);
        }

        private void LoadForm()
        {
            txtTenantIDCard.Clear();
            txtExDate.Clear();
            txttenantID.Clear();
        }
        private bool CheckNull()
        {
            if (txtTenantIDCard.Text == "" || txtExDate.Text == "" || txttenantID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thẻ cư dân!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtTenantIDCard.TextLength < 4)
            {
                MessageBox.Show("Mã số thẻ cư dân phải 10 ký tự số trở lên!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
           /* if(txtTenantIDCard != null)
            {
                DialogResult dg = MessageBox.Show("mã người thuê đã tồn tại {txtTenantID.MaNguoiThue})",
                    "Thông Báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }  */  

            return true;
        }
        private bool ContainsNumber(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            THECUDAN ReCardDelete = context.THECUDANs.FirstOrDefault(p => p.MaTheCuDan == txtTenantIDCard.Text);
            if (ReCardDelete != null)
            {
                DialogResult dg = MessageBox.Show($"Bạn có thực sự muốn xoá mã thẻ cư dân {ReCardDelete.MaTheCuDan}",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    context.THECUDANs.Remove(ReCardDelete);
                    context.SaveChanges();

                    // reset lại thông tin sau khi xoá
                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Xoá mã thẻ cư dân {ReCardDelete.MaTheCuDan} thành công!",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                // lấy phần tử đầu tiên thoả điều kiện
                string newTenantIDCard = txtTenantIDCard.Text;
                THECUDAN UpdateTenantIDCard = context.THECUDANs.FirstOrDefault(p => p.MaTheCuDan == newTenantIDCard);
                if (UpdateTenantIDCard != null)
                {
                    UpdateTenantIDCard.HSD = int.Parse(txtExDate.Text);

                    UpdateTenantIDCard.MaNguoiThue = txttenantID.Text;
                    // Đưa dữ liệu khi thay đổi vào DB
                    context.THECUDANs.AddOrUpdate(UpdateTenantIDCard);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Chỉnh sửa dữ liệu thẻ cư dân {UpdateTenantIDCard.MaTheCuDan} thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thẻ cư dân cần sửa!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
    


