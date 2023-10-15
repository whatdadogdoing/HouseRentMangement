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
    public partial class Contract : Form
    {
        HRMContextDB dbChungCu = new HRMContextDB();
        public Contract()
        {
            InitializeComponent();
        }

        public void BindGrid(List<HOPDONGTHUE> listHDT)
        {
            dgvContract.Rows.Clear();
            foreach (var item in listHDT)
            {
                int index = dgvContract.Rows.Add();
                // Đổ dữ liệu xuống dòng dgv
                dgvContract.Rows[index].Cells[0].Value = index + 1;
                dgvContract.Rows[index].Cells[1].Value = item.SoHopDong;
                dgvContract.Rows[index].Cells[2].Value = item.NgayLap;
                dgvContract.Rows[index].Cells[3].Value = item.TienCoc;
                dgvContract.Rows[index].Cells[4].Value = item.TienThue;
                dgvContract.Rows[index].Cells[5].Value = item.NoiDung;
                dgvContract.Rows[index].Cells[6].Value = item.NgayBD;
                dgvContract.Rows[index].Cells[7].Value = item.NgayKT;
                dgvContract.Rows[index].Cells[8].Value = item.MaChuSoHuu;
                dgvContract.Rows[index].Cells[9].Value = item.MaNguoiThue;
                dgvContract.Rows[index].Cells[10].Value = item.MaCanHo;
            }
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            try
            {
                List<HOPDONGTHUE> listHDT = dbChungCu.HOPDONGTHUEs.ToList();

                BindGrid(listHDT);

                gnlMaCanHo.DataSource = listHDT;
                gnlMaCanHo.DisplayMember = "MaCanHo"; 
                gnlMaCanHo.ValueMember = "MaCanHo";

                gnlMaChuSoHuu.DataSource = listHDT;
                gnlMaChuSoHuu.DisplayMember = "MaChuSoHuu";
                gnlMaChuSoHuu.ValueMember = "MaChuSoHuu";
            }
            catch (Exception)
            {

            }
        }

        private void dgvContract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvContract.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvContract.CurrentRow.Selected = true;

                    bnfSoHopDong.Text = dgvContract.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    bnfTienCoc.Text = dgvContract.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    bnfTienThue.Text = dgvContract.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    bnfTienCoc.Text = dgvContract.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    gnfNgayBD.Text = dgvContract.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    gnfNgayKT.Text = dgvContract.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    gnlMaChuSoHuu.SelectedIndex = gnlMaChuSoHuu.FindString(dgvContract.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());
                    bnfMaNguoiThue.Text = dgvContract.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                    gnlMaCanHo.SelectedIndex = gnlMaCanHo.FindString(dgvContract.Rows[e.RowIndex].Cells[10].FormattedValue.ToString());

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đang chọn sai!", "Lỗi xảy ra",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckNull()
        {
            if (bnfSoHopDong.Text == "" || bnfTienCoc.Text == "" || bnfTienThue.Text == "" || bnfMaNguoiThue.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Hợp đồng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (bnfTienCoc.TextLength < 6)
            {
                MessageBox.Show("Tiền cọc phải có 5 ký tự trở lên!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private int CheckSoHopDong(string NewBienSoXe)
        {
            int length = dgvContract.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvContract.Rows[i].Cells[1].Value != null)
                    if (dgvContract.Rows[i].Cells[1].Value.ToString() == NewBienSoXe)
                        return i;
            }
            return -1;
        }

        private void LoaddgvHDT()
        {
            List<HOPDONGTHUE> listHDT = dbChungCu.HOPDONGTHUEs.ToList();
            BindGrid(listHDT);
        }

        private void LoadForm()
        {
            bnfSoHopDong.Clear();
            bnfTienCoc.Clear();
            bnfTienThue.Clear();
            bnfMaNguoiThue.Clear();
        }

        private void bnfInsert_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckSoHopDong(bnfSoHopDong.Text) == -1) // -1 để là số hợp đồng mới
                {
                    HOPDONGTHUE newSoHopDongThue = new HOPDONGTHUE();

                    newSoHopDongThue.SoHopDong = bnfSoHopDong.Text;
                    newSoHopDongThue.TienCoc = Convert.ToDecimal(bnfTienCoc.Text);
                    newSoHopDongThue.TienThue = Convert.ToDecimal(bnfTienThue.Text);
                    newSoHopDongThue.NgayLap = DateTime.Now;
                    newSoHopDongThue.NgayBD = DateTime.Today;
                    newSoHopDongThue.NgayKT = DateTime.UtcNow;
                    newSoHopDongThue.MaChuSoHuu = gnlMaChuSoHuu.SelectedItem.ToString();
                    newSoHopDongThue.MaNguoiThue = bnfMaNguoiThue.Text;
                    newSoHopDongThue.MaCanHo = gnlMaCanHo.SelectedItem.ToString();
                    newSoHopDongThue.NoiDung = string.Empty;

                    dbChungCu.HOPDONGTHUEs.AddOrUpdate(newSoHopDongThue);
                    dbChungCu.SaveChanges();
                   
                    LoaddgvHDT();
                    LoadForm();

                    MessageBox.Show($"Thêm hợp đồng mới vào danh sách thành công!",
                         "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Hợp đồng có số {bnfSoHopDong.Text} đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bnfUpdate_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                string updatedSoHopDong = bnfSoHopDong.Text;

                // Tìm hợp đồng cần cập nhật
                HOPDONGTHUE updateHopDong = dbChungCu.HOPDONGTHUEs.FirstOrDefault(hd => hd.SoHopDong == updatedSoHopDong);

                if (updateHopDong != null)
                {
                    // Cập nhật thông tin hợp đồng
                    updateHopDong.TienCoc = Convert.ToDecimal(bnfTienCoc.Text);
                    updateHopDong.TienThue = Convert.ToDecimal(bnfTienThue.Text);
                    // Cập nhật MaChuSoHuu - Chúng ta giả sử MaChuSoHuu cũng là một thuộc tính của HOPDONGTHUE
                    updateHopDong.MaChuSoHuu = gnlMaChuSoHuu.SelectedItem.ToString();
                    updateHopDong.MaNguoiThue = bnfMaNguoiThue.Text;
                    // Cập nhật MaCanHo - Chúng ta giả sử MaCanHo cũng là một thuộc tính của HOPDONGTHUE
                    updateHopDong.MaCanHo = gnlMaCanHo.SelectedItem.ToString();
                    updateHopDong.NoiDung = null;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbChungCu.SaveChanges();

                    // Cập nhật DataGridView và xóa dữ liệu trên các control nhập liệu
                    LoaddgvHDT();
                    LoadForm();

                    MessageBox.Show($"Chỉnh sửa dữ liệu hợp đồng có số {updatedSoHopDong} thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy hợp đồng có số {updatedSoHopDong} cần sửa!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void bnfDelete_Click(object sender, EventArgs e)
        {
            string deletedSoHopDong = bnfSoHopDong.Text;

            // Tìm hợp đồng cần xoá
            HOPDONGTHUE deletedHopDong = dbChungCu.HOPDONGTHUEs.FirstOrDefault(hd => hd.SoHopDong == deletedSoHopDong);

            if (deletedHopDong != null)
            {
                // Xoá hợp đồng khỏi cơ sở dữ liệu
                dbChungCu.HOPDONGTHUEs.Remove(deletedHopDong);
                dbChungCu.SaveChanges();

                // Cập nhật DataGridView và xóa dữ liệu trên các control nhập liệu
                LoaddgvHDT();
                LoadForm();

                MessageBox.Show($"Xoá hợp đồng có số {deletedSoHopDong} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Không tìm thấy hợp đồng có số {deletedSoHopDong} cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   
        }

        private void txtSearchContract_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
