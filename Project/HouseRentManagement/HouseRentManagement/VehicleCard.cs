using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Filtering.Templates;
using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class VehicleCard : Form
    {
        HRMContextDB dbChungCu = new HRMContextDB();

        public VehicleCard()
        {
            InitializeComponent();
        }

        public void BindGrid(List<XE> listXe, List<THEXE> listTheXe)
        {
            dgvVehicleCard.Rows.Clear();
            for (int i = 0; i < Math.Max(listXe.Count, listTheXe.Count); i++)
            {
                int index = dgvVehicleCard.Rows.Add();

                if (i < listXe.Count)
                {
                    dgvVehicleCard.Rows[index].Cells[0].Value = index + 1;
                    dgvVehicleCard.Rows[index].Cells[1].Value = listXe[i].BienSo;
                    dgvVehicleCard.Rows[index].Cells[2].Value = listXe[i].TenXe;
                    dgvVehicleCard.Rows[index].Cells[3].Value = listXe[i].LoaiCoGioi;
                    dgvVehicleCard.Rows[index].Cells[4].Value = listXe[i].MaTheXe;
                    // Các trường dữ liệu khác từ bảng "XE"
                }

                if (i < listTheXe.Count)
                {
                    dgvVehicleCard.Rows[index].Cells[5].Value = listTheXe[i].NgayLap;
                    dgvVehicleCard.Rows[index].Cells[6].Value = listTheXe[i].HSD;
                    dgvVehicleCard.Rows[index].Cells[7].Value = listTheXe[i].MaTheCuDan;
                    // Các trường dữ liệu khác từ bảng "THEXE"
                }
            }
        }

        private void VehicleCard_Load(object sender, EventArgs e)
        {
            try
            {
                List<XE> listXe = dbChungCu.XEs.ToList();
                List<THEXE> listTheXe = dbChungCu.THEXEs.ToList();
                BindGrid(listXe, listTheXe);
              
                gnlLoaiCoGioi.SelectedIndex = 0;

                // Tải danh sách thẻ dân cư vào ComboBox
                List<THEXE> listTheCuDan = dbChungCu.THEXEs.ToList();
                gnlMaTheDanCu.DataSource = listTheCuDan;
                gnlMaTheDanCu.DisplayMember = "MaTheCuDan"; // Chọn thuộc tính hiển thị trong ComboBox
                gnlMaTheDanCu.ValueMember = "MaTheCuDan"; // Chọn thuộc tính được lưu trữ khi bạn chọn một mục
            }
            catch (Exception)
            {

            }         
        }

        private void LoaddgvXe()
        {
            List<XE> listXe = dbChungCu.XEs.ToList();
            List<THEXE> listTheXe = dbChungCu.THEXEs.ToList();
            BindGrid(listXe, listTheXe);
        }

        private void LoadForm()
        {
            bnfBienSoXe.Clear();
            bnfTenXe.Clear();
            bnfMaTheXe.Clear();
            bnfHSD.Clear();
        }

        private int CheckBienSoXe(string NewBienSoXe)
        {
            int length = dgvVehicleCard.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvVehicleCard.Rows[i].Cells[1].Value != null)
                    if (dgvVehicleCard.Rows[i].Cells[1].Value.ToString() == NewBienSoXe)
                        return i;
            }
            return -1;
        }

        public int getSelectedRow(string BienSoXe)
        {
            // Kiểm tra từ đầu đến cuối danh sách, nếu có thì trả về vị trí
            for (int i = 0; i < dgvVehicleCard.Rows.Count; i++)
            {
                if (dgvVehicleCard.Rows[i].Cells[1].Value.ToString() == BienSoXe)
                {
                    return i;
                }
            }
            return -1; // không có xe trong danh sách
        }

        private bool CheckNull()
        {
            if (bnfBienSoXe.Text == "" || bnfTenXe.Text == "" || bnfMaTheXe.Text == "" || bnfHSD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Xe!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (bnfBienSoXe.TextLength < 5)
            {
                MessageBox.Show("Biển số xe phải có 5 ký tự trở lên!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void bnfInsert_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckBienSoXe(bnfBienSoXe.Text) == -1) // -1 để là biển số xe mới
                {
                    XE newXe = new XE();                   

                    newXe.BienSo = bnfBienSoXe.Text;
                    newXe.TenXe = bnfTenXe.Text;
                    newXe.LoaiCoGioi = gnlLoaiCoGioi.SelectedItem.ToString();                 
                    newXe.MaTheXe = bnfMaTheXe.Text;

                    dbChungCu.XEs.AddOrUpdate(newXe);
                    dbChungCu.SaveChanges();

                    THEXE newTheXe = new THEXE();
                    newTheXe.NgayLap = DateTime.Now;
                    newTheXe.HSD = Convert.ToInt32(bnfHSD.Text);
                    // Lấy giá trị MaTheCuDan từ ComboBox
                    newTheXe.MaTheCuDan = gnlMaTheDanCu.SelectedValue.ToString();

                    dbChungCu.THEXEs.AddOrUpdate(newTheXe);
                    dbChungCu.SaveChanges();
                
                    LoaddgvXe();
                    LoadForm();

                    MessageBox.Show($"Thêm xe {newXe.TenXe} vào danh sách thành công!",
                         "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Xe có biển số {bnfBienSoXe.Text} đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvVehicleCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvVehicleCard.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvVehicleCard.CurrentRow.Selected = true;

                    bnfBienSoXe.Text = dgvVehicleCard.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    bnfTenXe.Text = dgvVehicleCard.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    gnlLoaiCoGioi.SelectedIndex = gnlLoaiCoGioi.FindString(dgvVehicleCard.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                    bnfMaTheXe.Text = dgvVehicleCard.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    gndtpNgayLap.Text = dgvVehicleCard.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    bnfHSD.Text = dgvVehicleCard.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đang chọn sai!", "Lỗi xảy ra",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bnfUpdate_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                string updatedBienSo = bnfBienSoXe.Text;

                // Tìm XE cần cập nhật
                XE updateXe = dbChungCu.XEs.FirstOrDefault(p => p.BienSo == updatedBienSo);

                if (updateXe != null)
                {
                    // Cập nhật thông tin xe
                    updateXe.TenXe = bnfTenXe.Text;
                    updateXe.MaTheXe = bnfMaTheXe.Text;
                    // Cập nhật LoaiCoGioi - Chúng ta giả sử LoaiCoGioi cũng là một thuộc tính của XE
                    updateXe.LoaiCoGioi = gnlLoaiCoGioi.SelectedItem.ToString();
                   

                    // Tìm hoặc tạo thông tin thẻ xe tương ứng
                    THEXE updateTheXe = dbChungCu.THEXEs.FirstOrDefault(p => p.MaTheXe == updateXe.MaTheXe);
                    if (updateTheXe == null)
                    {
                        updateTheXe = new THEXE();
                    }

                    // Cập nhật thông tin thẻ xe
                    updateTheXe.NgayLap = DateTime.Now;
                    updateTheXe.HSD = Convert.ToInt32(bnfHSD.Text);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbChungCu.SaveChanges();

                    // Cập nhật DataGridView và xóa dữ liệu trên các control nhập liệu
                    LoaddgvXe();
                    LoadForm();

                    MessageBox.Show($"Chỉnh sửa dữ liệu xe {updateXe.TenXe} và thẻ xe tương ứng thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy xe có biển số {updatedBienSo} cần sửa!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void bnfDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string deletedBienSoXe = bnfBienSoXe.Text;

                // Tìm xe cần xoá
                XE deleteXe = dbChungCu.XEs.FirstOrDefault(xe => xe.BienSo == deletedBienSoXe);

                if (deleteXe != null)
                {
                    // Tìm thẻ xe tương ứng
                    THEXE deleteTheXe = dbChungCu.THEXEs.FirstOrDefault(t => t.MaTheXe == deleteXe.MaTheXe);

                    // Xoá xe
                    dbChungCu.XEs.Remove(deleteXe);

                    // Nếu tồn tại thẻ xe, thì xoá thẻ xe
                    if (deleteTheXe != null)
                    {
                        dbChungCu.THEXEs.Remove(deleteTheXe);
                    }

                    dbChungCu.SaveChanges();

                    // Cập nhật DataGridView và xóa dữ liệu trên các control nhập liệu
                    LoaddgvXe();
                    LoadForm();

                    MessageBox.Show($"Xoá xe có biển số {deletedBienSoXe} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy xe có biển số {deletedBienSoXe} cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }catch(Exception)
            {

            }

        }

            private void txtBoxSearch_TextChanged(object sender, EventArgs e)
          {
            string searchTerm = txtBoxSearch.Text.ToLower(); // Lấy nội dung từ TextBox và đổi thành chữ thường (lowercase)

            if (string.IsNullOrEmpty(searchTerm))
            {
                // Nếu TextBox trống, hiển thị tất cả dữ liệu
                List<XE> listXe = dbChungCu.XEs.ToList();
                List<THEXE> listTheXe = dbChungCu.THEXEs.ToList();
                BindGrid(listXe, listTheXe);
            }
            else
            {
                // Nếu có nội dung trong TextBox, lọc dữ liệu và hiển thị kết quả tìm kiếm
                List<XE> filteredXe = dbChungCu.XEs
                    .Where(c => c.MaTheXe.ToLower().Contains(searchTerm))
                    .ToList();

                List<THEXE> filteredTheXe = dbChungCu.THEXEs
                    .Where(l => l.MaTheCuDan.ToLower().Contains(searchTerm))
                    .ToList();
                List<THECUDAN> filteredTheCuDan = dbChungCu.THECUDANs
                   .Where(l => l.MaTheCuDan.ToLower().Contains(searchTerm))
                   .ToList();

                BindGrid(filteredXe, filteredTheXe);
            }
        }
    }
 }




