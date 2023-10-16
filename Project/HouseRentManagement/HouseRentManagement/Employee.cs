using DevExpress.XtraEditors;
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
    public partial class Employee : DevExpress.XtraEditors.XtraForm
    {
        Model_QLCHCC context = new Model_QLCHCC();
        public Employee()
        {
            InitializeComponent();
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
        private void BindGrid(List<BANQUANLY> lsBanQuanLy)
        {
            dgvDSEMPLOYEE.Rows.Clear();
            foreach (var item in lsBanQuanLy)
            {
                int index = dgvDSEMPLOYEE.Rows.Add();
                dgvDSEMPLOYEE.Rows[index].Cells[0].Value = item.MaQL;
                dgvDSEMPLOYEE.Rows[index].Cells[1].Value = item.TenQuanLy;
                dgvDSEMPLOYEE.Rows[index].Cells[2].Value = item.CHUCVU.TenChucVu;
                dgvDSEMPLOYEE.Rows[index].Cells[3].Value = item.CCCD;
                dgvDSEMPLOYEE.Rows[index].Cells[4].Value = item.NgaySinh;
                string gender = GetGender(item.GioiTinh);
                dgvDSEMPLOYEE.Rows[index].Cells[5].Value = gender;
                dgvDSEMPLOYEE.Rows[index].Cells[6].Value = item.SDT;
                dgvDSEMPLOYEE.Rows[index].Cells[7].Value = item.Email;
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            List<BANQUANLY> lsBanQuanLy = context.BANQUANLies.ToList();
            BindGrid(lsBanQuanLy);
            FillChuVuCombobox(lsBanQuanLy);
        }
        private void FillChuVuCombobox(List<BANQUANLY> lsBanQuanLy)
        {
            List<CHUCVU> chucVuList = context.CHUCVUs.ToList();
            var chucVuData = (from bq in lsBanQuanLy
                              join cv in chucVuList on bq.MaCV equals cv.MaCV
                              select new CHUCVU
                              {
                                  MaCV = bq.MaCV,
                                  TenChucVu = cv.TenChucVu
                              }).ToList();

            this.cbbRole.DataSource = chucVuData;
            this.cbbRole.DisplayMember = "TenChucVu";
            this.cbbRole.ValueMember = "MaCV";
        }
        private void cbbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                if (CheckEmployee(txtTenantID.Text) == -1)
                {
                    BANQUANLY newBanQuanLy = new BANQUANLY();
                    newBanQuanLy.MaQL = txtTenantID.Text;
                    newBanQuanLy.TenQuanLy = txtTenantName.Text;
                    CHUCVU selectedChucVu = (CHUCVU)cbbRole.SelectedItem;
                    newBanQuanLy.MaCV = selectedChucVu.MaCV;
                    newBanQuanLy.CCCD = txtProofID.ToString();
                    newBanQuanLy.NgaySinh = DateTime.Now;
                    newBanQuanLy.GioiTinh = GetGenderFromRadioButton();
                    newBanQuanLy.SDT = txtPhoneNumber.Text;
                    newBanQuanLy.Email = txtEmail.Text;
                    context.BANQUANLies.AddOrUpdate(newBanQuanLy);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Thêm ban quản lý {newBanQuanLy.MaQL} vào danh sách thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Ban quản lý có mã số {txtTenantID.Text} đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private int CheckEmployee(string TenantID)
        {
            int length = dgvDSEMPLOYEE.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvDSEMPLOYEE.Rows[i].Cells[0].Value != null)
                    if (dgvDSEMPLOYEE.Rows[i].Cells[0].Value.ToString() == TenantID)
                        return i;
            }
            return -1;
        }

        private void LoaddgvDSSV()
        {
            List<BANQUANLY> newBanQuanLy = context.BANQUANLies.ToList();
            BindGrid(newBanQuanLy);
        }

        private void LoadForm()
        {
            txtTenantID.Clear();
            txtTenantName.Clear();
            txtProofID.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
        }
        private bool CheckNull()
        {
            if (txtTenantID.Text == "" || txtTenantName.Text == "" || txtProofID.Text == ""
                || txtPhoneNumber.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin người thuê!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtTenantID.TextLength < 4)
            {
                MessageBox.Show("Mã người thuê phải 4 ký tự số trở lên!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (ContainsNumber(txtTenantName.Text))
            {
                MessageBox.Show("Tên người thuê không được chứa số!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
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
            BANQUANLY EmployeeDelete = context.BANQUANLies.FirstOrDefault(p => p.MaQL == txtTenantID.Text);
            if (EmployeeDelete != null)
            {
                DialogResult dg = MessageBox.Show($"Bạn có thực sự muốn xoá mã người thuê không? {EmployeeDelete.MaQL}",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    context.BANQUANLies.Remove(EmployeeDelete);
                    context.SaveChanges();

                    // reset lại thông tin sau khi xoá
                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Xoá mã người thuê {EmployeeDelete.MaQL} thành công!",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                // lấy phần tử đầu tiên thoả điều kiện
                string newTenantID = txtTenantID.Text;
                BANQUANLY updateEmployee = context.BANQUANLies.FirstOrDefault(p => p.MaQL == newTenantID);
                CHUCVU selectedChucVu = (CHUCVU)cbbRole.SelectedItem;

                if (updateEmployee != null)
                {
                    updateEmployee.MaQL = txtTenantID.Text;
                    updateEmployee.TenQuanLy = txtTenantName.Text;
                    updateEmployee.MaCV = selectedChucVu.MaCV;
                    updateEmployee.CCCD = txtProofID.Text;
                    updateEmployee.NgaySinh = dtpDoB.Value;
                    updateEmployee.GioiTinh = GetGenderFromRadioButton();
                    updateEmployee.SDT = txtPhoneNumber.Text;
                    updateEmployee.Email = txtEmail.Text;

                    // Đưa dữ liệu khi thay đổi vào DB
                    context.BANQUANLies.AddOrUpdate(updateEmployee);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Chỉnh sửa dữ liệu thẻ cư dân {updateEmployee.MaQL} thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thẻ cư dân cần sửa!",
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
        private void dgvDSEMPLOYEE_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSEMPLOYEE.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDSEMPLOYEE.SelectedRows[0];
                string maQL = selectedRow.Cells[0].Value.ToString();

                // Tìm BANQUANLY tương ứng trong context
                BANQUANLY selectedBanQuanLy = context.BANQUANLies.FirstOrDefault(bq => bq.MaQL == maQL);

                if (selectedBanQuanLy != null)
                {
                    txtTenantID.Text = selectedBanQuanLy.MaQL;
                    txtTenantName.Text = selectedBanQuanLy.TenQuanLy;
                    txtProofID.Text = selectedBanQuanLy.CCCD;
                    dtpDoB.Value = selectedBanQuanLy.NgaySinh.Value;
                    txtPhoneNumber.Text = selectedBanQuanLy.SDT;
                    txtEmail.Text = selectedBanQuanLy.Email;
                    SetGenderToRadioButton(selectedBanQuanLy.GioiTinh);

                    // Chọn chức vụ tương ứng trong combobox
                    CHUCVU selectedChucVu = context.CHUCVUs.FirstOrDefault(cv => cv.MaCV == selectedBanQuanLy.MaCV);
                    if (selectedChucVu != null)
                    {
                        cbbRole.SelectedValue = selectedChucVu.MaCV;
                    }

                    // Chọn giới tính tương ứng trong radiobutton
                }
            }
        }
    }
}