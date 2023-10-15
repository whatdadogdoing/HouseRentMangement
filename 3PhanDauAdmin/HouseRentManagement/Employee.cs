using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.TextEditController.Utils;
using HouseRentManagement.QuanLyCanHoChungCu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class Employee : Form
    {
        DBQuanLyCHCC context = new DBQuanLyCHCC();
        public Employee()
        {
            InitializeComponent();
        }

        private void BindGrid(List<NGUOITHUE> lsNguoiThue)
        {
            dgvDSEMPLOYEE.Rows.Clear();
            foreach (var item in lsNguoiThue)
            {
                int index = dgvDSEMPLOYEE.Rows.Add();
                dgvDSEMPLOYEE.Rows[index].Cells[0].Value = item.MaNguoiThue;
                dgvDSEMPLOYEE.Rows[index].Cells[1].Value = item.TenNguoiThue;
                dgvDSEMPLOYEE.Rows[index].Cells[2].Value = item.CCCD;
                dgvDSEMPLOYEE.Rows[index].Cells[3].Value = item.NgaySinh;
                dgvDSEMPLOYEE.Rows[index].Cells[4].Value = item.GioiTinh;
                dgvDSEMPLOYEE.Rows[index].Cells[5].Value = item.SDT;
                dgvDSEMPLOYEE.Rows[index].Cells[6].Value = item.Email;
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            List<NGUOITHUE> lsNguoiThue = context.NGUOITHUEs.ToList();
            BindGrid(lsNguoiThue);
            FillGenderCombobox(lsNguoiThue);
        }
        private void FillGenderCombobox(List<NGUOITHUE> lsNguoiThue)
        {
            this.cbbGender.DataSource = lsNguoiThue;
            this.cbbGender.DisplayMember = "GioiTinh";
            this.cbbGender.ValueMember = "MaNguoiThue";

        }
        private void cbbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckEmployee(txtTenantID.Text) == -1)
                {
                    NGUOITHUE newnguoithue = new NGUOITHUE();
                    newnguoithue.MaNguoiThue = txtTenantID.Text;
                    newnguoithue.TenNguoiThue = txtTenantName.Text;
                    newnguoithue.CCCD = txtProofID.ToString();
                    newnguoithue.NgaySinh = DateTime.Now;
                    newnguoithue.GioiTinh = (int)cbbGender.SelectedValue == 1 ? true : false;
                    newnguoithue.SDT = txtPhoneNumber.Text;
                    newnguoithue.Email = txtEmail.Text;
                    context.NGUOITHUEs.AddOrUpdate(newnguoithue);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Thêm thẻ cư dân {newnguoithue.MaNguoiThue} vào danh sách thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"Thẻ cư dân có mã số {txtTenantID.Text} đã tồn tại!", "Thông báo",
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
            List<NGUOITHUE> newnguoithue = context.NGUOITHUEs.ToList();
            BindGrid(newnguoithue);
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
                || txtPhoneNumber.Text == "" || txtEmail.Text == "" )
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
            NGUOITHUE EmployeeDelete = context.NGUOITHUEs.FirstOrDefault(p => p.MaNguoiThue == txtTenantID.Text);
            if (EmployeeDelete != null)
            {
                DialogResult dg = MessageBox.Show($"Bạn có thực sự muốn xoá mã người thuê không? {EmployeeDelete.MaNguoiThue}",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    context.NGUOITHUEs.Remove(EmployeeDelete);
                    context.SaveChanges();

                    // reset lại thông tin sau khi xoá
                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Xoá mã người thuê {EmployeeDelete.MaNguoiThue} thành công!",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                // lấy phần tử đầu tiên thoả điều kiện
                string newTenantID= txtTenantID.Text;
                NGUOITHUE UpdateTenant = context.NGUOITHUEs.FirstOrDefault(p => p.MaNguoiThue == newTenantID);
                if (UpdateTenant != null)
                {
                    UpdateTenant.MaNguoiThue = txtTenantID.Text;
                    UpdateTenant.TenNguoiThue = txtTenantName.Text; 
                    UpdateTenant.CCCD = txtProofID.Text;
                    UpdateTenant.SDT = txtPhoneNumber.Text;
                    UpdateTenant.Email = txtEmail.Text;

                  
                    // Đưa dữ liệu khi thay đổi vào DB
                    context.NGUOITHUEs.AddOrUpdate(UpdateTenant);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Chỉnh sửa dữ liệu thẻ cư dân {UpdateTenant.MaNguoiThue} thành công!",
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







