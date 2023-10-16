using DevExpress.XtraEditors;
using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace HouseRentManagement
{
    public partial class Tenant : DevExpress.XtraEditors.XtraForm
    {
        Model_QLCHCC context = new Model_QLCHCC();
        public Tenant()
        {
            InitializeComponent();
        }
        private ChildFormManager formManager = new ChildFormManager();

        private void BindGrid(List<NGUOITHUE> lsNguoiThue)
        {
            dgvDSReCard.Rows.Clear();
            foreach (var item in lsNguoiThue)
            {
                int index = dgvDSReCard.Rows.Add();
                dgvDSReCard.Rows[index].Cells[0].Value = item.MaNguoiThue;
                dgvDSReCard.Rows[index].Cells[1].Value = item.TenNguoiThue;
                dgvDSReCard.Rows[index].Cells[2].Value = item.CCCD;
                dgvDSReCard.Rows[index].Cells[3].Value = item.NgaySinh;
                string gender = GetGender(item.GioiTinh);
                dgvDSReCard.Rows[index].Cells[4].Value = gender;
                dgvDSReCard.Rows[index].Cells[5].Value = item.SDT;
                dgvDSReCard.Rows[index].Cells[6].Value = item.Email;
            }
        }

        private string GetGender(bool? isMale)
        {
            if (isMale.HasValue)
            {
                return isMale.Value ? "Nam" : "Nữ";
            }
            else
            {
                return "Unknown";
            }
        }

        private void Resident_Card_Load(object sender, EventArgs e)
        {
            List<NGUOITHUE> lsNguoiThue = context.NGUOITHUEs.ToList();
            BindGrid(lsNguoiThue);
        }
        private bool? GetGenderFromRadioButton()
        {
            if (rbMale.Checked)
            {
                return true;
            }
            else if (rbFemale.Checked)
            {
                return false;
            }
            else
            {
                return null;
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckTenantIdentify(txtTenantIdentify.Text) == -1) // -1 để là sinh viên mới
                {
                    NGUOITHUE newNguoiThue = new NGUOITHUE();

                    newNguoiThue.MaNguoiThue = txtTenantID.Text;
                    newNguoiThue.TenNguoiThue = txtTenantName.Text;
                    newNguoiThue.CCCD = txtTenantIdentify.Text;
                    newNguoiThue.NgaySinh = dtpTenant.Value;
                    newNguoiThue.GioiTinh = GetGenderFromRadioButton(); // Lấy giới tính từ RadioButton
                    newNguoiThue.SDT = txtTenantContact.Text;
                    newNguoiThue.Email = txtTenantEmail.Text;
                    // Thêm newNguoiThue vào cơ sở dữ liệu
                    context.NGUOITHUEs.Add(newNguoiThue);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Thêm khách thuê {newNguoiThue.MaNguoiThue} vào danh sách thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"Thẻ khách thuê có mã số cccd {txtTenantIdentify.Text} đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private int CheckTenantIdentify(string TenantID)
        {
            int length = dgvDSReCard.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvDSReCard.Rows[i].Cells[0].Value != null)
                    if (dgvDSReCard.Rows[i].Cells[0].Value.ToString() == TenantID)
                        return i;
            }
            return -1;
        }

        private void LoaddgvDSSV()
        {
            List<NGUOITHUE> newNguoiThue = context.NGUOITHUEs.ToList();
            BindGrid(newNguoiThue);
        }

        private void LoadForm()
        {
            txtTenantName.Clear();
            txtTenantContact.Clear();
            txtTenantEmail.Clear();
            txtTenantIdentify.Clear();
        }
        private bool CheckNull()
        {
            if (txtTenantContact.Text == "" || txtTenantEmail.Text == "" || txtTenantIdentify.Text == "" || txtTenantName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách thuê!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            NGUOITHUE ReCardDelete = context.NGUOITHUEs.FirstOrDefault(p => p.MaNguoiThue == txtTenantID.Text);
            if (ReCardDelete != null)
            {
                DialogResult dg = MessageBox.Show($"Bạn có thực sự muốn xoá người thuê này {ReCardDelete.MaNguoiThue}",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    context.NGUOITHUEs.Remove(ReCardDelete);
                    context.SaveChanges();

                    // reset lại thông tin sau khi xoá
                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Xoá mã người thuê {ReCardDelete.MaNguoiThue} thành công!",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                string tenantID = txtTenantID.Text;
                NGUOITHUE updatedNguoiThue = context.NGUOITHUEs.FirstOrDefault(nt => nt.MaNguoiThue == tenantID);

                if (updatedNguoiThue != null)
                {
                    updatedNguoiThue.TenNguoiThue = txtTenantName.Text;
                    updatedNguoiThue.CCCD = txtTenantIdentify.Text;
                    updatedNguoiThue.NgaySinh = dtpTenant.Value;
                    updatedNguoiThue.GioiTinh = GetGenderFromRadioButton(); // Lấy giới tính từ RadioButton
                    updatedNguoiThue.SDT = txtTenantContact.Text;
                    updatedNguoiThue.Email = txtTenantEmail.Text;

                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Cập nhật thông tin người thuê với mã {updatedNguoiThue.MaNguoiThue} thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy người thuê với mã {tenantID}!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void SetGenderToRadioButton(bool? gender)
        {
            if (gender.HasValue)
            {
                if (gender.Value)
                {
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                }
                else
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = true;
                }
            }
            else
            {
                rbMale.Checked = false;
                rbFemale.Checked = false;
            }
        }
        private void dgvDSReCard_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSReCard.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDSReCard.SelectedRows[0];
                string tenantID = selectedRow.Cells[0].Value.ToString();

                // Hiển thị thông tin người thuê lên các điều khiển
                NGUOITHUE nguoiThue = context.NGUOITHUEs.FirstOrDefault(nt => nt.MaNguoiThue == tenantID);
                if (nguoiThue != null)
                {
                    txtTenantID.Text = nguoiThue.MaNguoiThue;
                    txtTenantName.Text = nguoiThue.TenNguoiThue;
                    txtTenantIdentify.Text = nguoiThue.CCCD;
                    dtpTenant.Value = nguoiThue.NgaySinh.HasValue ? nguoiThue.NgaySinh.Value : DateTime.MinValue;
                    SetGenderToRadioButton(nguoiThue.GioiTinh); // Đặt giới tính cho RadioButton
                    txtTenantContact.Text = nguoiThue.SDT;
                    txtTenantEmail.Text = nguoiThue.Email;

                }
            }
        }
        private void ShowResidentCard()
        {
            if (formManager.CurrentChildForm is ResidentCard)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ResidentCard rc = new ResidentCard();
            formManager.ShowChildForm(pnlContainer, rc);
        }
        private void tsbResidentCard_Click(object sender, EventArgs e)
        {
            ShowResidentCard();
            pnlTenant.Hide();
        }
    }
}