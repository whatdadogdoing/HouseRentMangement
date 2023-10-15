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

    namespace HouseRentManagement
    {
        public partial class CondoAdmin : Form
        {
            HRMContextDB dbChungCu = new HRMContextDB();
            public CondoAdmin()
            {
                InitializeComponent();
            }

            public void BindGrid(List<CANHO> listCanHo/*, List<LOAICANHO> listLoaiCanHo*/)
            {
                dgvCondoAdmin.Rows.Clear();

            foreach (var item in listCanHo)
            {
                int index = dgvCondoAdmin.Rows.Add();
                dgvCondoAdmin.Rows[index].Cells[0].Value = index + 1;
                dgvCondoAdmin.Rows[index].Cells[1].Value = item.MaCanHo;
                dgvCondoAdmin.Rows[index].Cells[2].Value = item.MaTang;
                dgvCondoAdmin.Rows[index].Cells[3].Value = item.MaChuSoHuu;
                dgvCondoAdmin.Rows[index].Cells[4].Value = item.MaLoai;
                dgvCondoAdmin.Rows[index].Cells[5].Value = item.TinhTrang;
                dgvCondoAdmin.Rows[index].Cells[6].Value = item.LOAICANHO.TenLoai;
                dgvCondoAdmin.Rows[index].Cells[7].Value = item.LOAICANHO.DienTich;
                dgvCondoAdmin.Rows[index].Cells[8].Value = item.LOAICANHO.SoPhongNgu;
                dgvCondoAdmin.Rows[index].Cells[9].Value = item.LOAICANHO.GiaThueMacDinh;
            }
        }

        private void CondoAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                List<CANHO> listCanHo = dbChungCu.CANHOes.ToList();
                List<LOAICANHO> listLoaiCanHo = dbChungCu.LOAICANHOes.ToList();

                BindGrid(listCanHo/*, listLoaiCanHo*/);

                // Tạo danh sách các tình trạng
                List<string> tinhTrangList = new List<string> { "Đầy", "Trống" };

                // Thiết lập ComboBox
                gnlTinhTrang.DataSource = tinhTrangList;

                // Tạo danh sách mã loại căn hộ từ cả hai bảng
                List<string> maLoaiCanHoList = new List<string>();
                maLoaiCanHoList.AddRange(listCanHo.Select(c => c.MaLoai));
                maLoaiCanHoList.AddRange(listLoaiCanHo.Select(l => l.MaLoai));

                // Loại bỏ các giá trị trùng lặp (nếu có)
                maLoaiCanHoList = maLoaiCanHoList.Distinct().ToList();

                // Thiết lập ComboBox Mã Loại Căn Hộ
                gnlMaLoaiCanHo.DataSource = maLoaiCanHoList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCondoAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvCondoAdmin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCondoAdmin.CurrentRow.Selected = true;

                    bnfMaCanHo.Text = dgvCondoAdmin.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    bnfMaTang.Text = dgvCondoAdmin.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    gnlMaLoaiCanHo.SelectedIndex = gnlMaLoaiCanHo.FindString(dgvCondoAdmin.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                    gnlTinhTrang.SelectedIndex = gnlTinhTrang.FindString(dgvCondoAdmin.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                    bnfDienTich.Text = dgvCondoAdmin.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đang chọn sai!", "Lỗi xảy ra",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bnfInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã căn hộ cần sửa từ trường nhập liệu
                string maCanHo = bnfMaCanHo.Text;

                // Kiểm tra xem mã căn hộ có tồn tại không
                CANHO existingCanHo = dbChungCu.CANHOes.SingleOrDefault(c => c.MaCanHo == maCanHo);

                if (existingCanHo != null)
                {
                    // Lấy dữ liệu mới từ các trường nhập liệu
                    string maTang = bnfMaTang.Text;
                    string maLoai = gnlMaLoaiCanHo.SelectedValue.ToString();
                    string tinhTrang = gnlTinhTrang.SelectedItem.ToString();
                    float dienTich = float.Parse(bnfDienTich.Text);

                    // Cập nhật thông tin của CANHO
                    existingCanHo.MaTang = maTang;
                    existingCanHo.MaLoai = maLoai;
                    existingCanHo.TinhTrang = tinhTrang;
                    // Các trường dữ liệu khác từ bảng "CANHO"

                    // Cập nhật thông tin của LOAICANHO
                    LOAICANHO existingLoaiCanHo = dbChungCu.LOAICANHOes.SingleOrDefault(l => l.MaLoai == maLoai);
                    existingLoaiCanHo.DienTich = dienTich;
                    // Các trường dữ liệu khác từ bảng "LOAICANHO"

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbChungCu.SaveChanges();

                    // Thông báo sửa thành công
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi sửa thành công, cập nhật lại DataGridView
                    List<CANHO> listCanHo = dbChungCu.CANHOes.ToList();
                    List<LOAICANHO> listLoaiCanHo = dbChungCu.LOAICANHOes.ToList();
                    BindGrid(listCanHo);

                    // Xóa trường nhập liệu sau khi sửa
                    bnfMaCanHo.Clear();
                    bnfMaTang.Clear();
                    bnfDienTich.Clear();

                    // Chọn mục "Trống" trong ComboBox Tình Trạng
                    gnlTinhTrang.SelectedItem = "Trống";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy căn hộ cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa căn hộ: " + ex.Message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bnfUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu mới từ các trường nhập liệu
                string maCanHo = bnfMaCanHo.Text;
                string maTang = bnfMaTang.Text;
                string maLoai = gnlMaLoaiCanHo.SelectedValue.ToString(); // Lấy giá trị đã chọn trong ComboBox Mã Loại Căn Hộ
                string tinhTrang = gnlTinhTrang.SelectedItem.ToString();
                float dienTich = float.Parse(bnfDienTich.Text);

                // Sửa CANHO hiện có trong cơ sở dữ liệu
                CANHO existingCanHo = dbChungCu.CANHOes.Single(c => c.MaCanHo == maCanHo);
                existingCanHo.MaTang = maTang;
                existingCanHo.MaLoai = maLoai;
                existingCanHo.TinhTrang = tinhTrang;
                // Các trường dữ liệu khác từ bảng "CANHO"

                // Sửa LOAICANHO hiện có trong cơ sở dữ liệu
                LOAICANHO existingLoaiCanHo = dbChungCu.LOAICANHOes.Single(l => l.MaLoai == maLoai);
                existingLoaiCanHo.DienTich = dienTich;
                // Các trường dữ liệu khác từ bảng "LOAICANHO"

                // Lưu thay đổi vào cơ sở dữ liệu
                dbChungCu.SaveChanges();

                // Thông báo sửa thành công
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi sửa thành công, cập nhật lại DataGridView
                List<CANHO> listCanHo = dbChungCu.CANHOes.ToList();
                List<LOAICANHO> listLoaiCanHo = dbChungCu.LOAICANHOes.ToList();
                BindGrid(listCanHo);

                // Xóa trường nhập liệu sau khi sửa
                bnfMaCanHo.Clear();
                bnfMaTang.Clear();
                bnfDienTich.Clear();

                // Chọn mục "Trống" trong ComboBox Tình Trạng
                gnlTinhTrang.SelectedItem = "Trống";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa căn hộ: " + ex.Message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void bnfDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã căn hộ cần xoá từ trường nhập liệu
                string maCanHo = bnfMaCanHo.Text;

                // Tìm căn hộ cần xoá trong cơ sở dữ liệu
                CANHO existingCanHo = dbChungCu.CANHOes.SingleOrDefault(c => c.MaCanHo == maCanHo);

                if (existingCanHo != null)
                {
                    // Xoá CANHO khỏi cơ sở dữ liệu
                    dbChungCu.CANHOes.Remove(existingCanHo);
                    dbChungCu.SaveChanges();

                    // Thông báo xoá thành công
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi xoá thành công, cập nhật lại DataGridView
                    List<CANHO> listCanHo = dbChungCu.CANHOes.ToList();
                    List<LOAICANHO> listLoaiCanHo = dbChungCu.LOAICANHOes.ToList();
                    BindGrid(listCanHo);

                    // Xóa trường nhập liệu sau khi xoá
                    bnfMaCanHo.Clear();
                    bnfMaTang.Clear();
                    bnfDienTich.Clear();

                    // Chọn mục "Trống" trong ComboBox Tình Trạng
                    gnlTinhTrang.SelectedItem = "Trống";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy căn hộ cần xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xoá căn hộ: " + ex.Message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtBoxSearch.Text.ToLower(); // Lấy nội dung từ TextBox và đổi thành chữ thường (lowercase)

            if (string.IsNullOrEmpty(searchTerm))
            {
                // Nếu TextBox trống, hiển thị tất cả dữ liệu
                List<CANHO> listCanHo = dbChungCu.CANHOes.ToList();
                List<LOAICANHO> listLoaiCanHo = dbChungCu.LOAICANHOes.ToList();
                BindGrid(listCanHo);
            }
            else
            {
                // Nếu có nội dung trong TextBox, lọc dữ liệu và hiển thị kết quả tìm kiếm
                List<CANHO> filteredCanHo = dbChungCu.CANHOes
                    .Where(c => c.MaCanHo.ToLower().Contains(searchTerm))
                    .ToList();

                List<LOAICANHO> filteredLoaiCanHo = dbChungCu.LOAICANHOes
                    .Where(l => l.TenLoai.ToLower().Contains(searchTerm))
                    .ToList();

                BindGrid(filteredCanHo);
            }
        }
    }
}

