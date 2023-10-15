using DevExpress.Utils.Filtering.Internal;
using DevExpress.Utils.Html.Internal;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class VehicleCard : DevExpress.XtraEditors.XtraForm
    {
        public VehicleCard()
        {
            InitializeComponent();
            FillComboBox();
            bindData();
        }
        private string connString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;
        private void bindData()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = @"SELECT XE.BienSo, NGUOITHUE.TenNguoiThue, THECUDAN.MaTheCuDan, XE.TenXe, XE.LoaiCoGioi, THEXE.NgayLap, THEXE.HSD
                 FROM THEXE
                 INNER JOIN THECUDAN ON THEXE.MaTheCuDan = THECUDAN.MaTheCuDan
                 INNER JOIN NGUOITHUE ON NGUOITHUE.MaNguoiThue = THECUDAN.MaNguoiThue
                 INNER JOIN XE ON THEXE.MaTheXe = XE.MaTheXe";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvVehicle.Rows.Clear();

                        while (reader.Read())
                        {
                            int index = dgvVehicle.Rows.Add();

                            dgvVehicle.Rows[index].Cells[0].Value = reader["BienSo"];
                            dgvVehicle.Rows[index].Cells[1].Value = reader["TenNguoiThue"];
                            dgvVehicle.Rows[index].Cells[2].Value = reader["MaTheCuDan"];
                            dgvVehicle.Rows[index].Cells[3].Value = reader["TenXe"];
                            dgvVehicle.Rows[index].Cells[4].Value = reader["LoaiCoGioi"];
                            dgvVehicle.Rows[index].Cells[5].Value = reader["NgayLap"];
                            dgvVehicle.Rows[index].Cells[6].Value = reader["HSD"];
                        }
                    }
                }
            }
        }
        private void FillComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "SELECT DISTINCT LoaiCoGioi FROM XE";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string loaiCoGioi = reader["LoaiCoGioi"].ToString();
                        cbbLoaiCoGioi.Items.Add(loaiCoGioi);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVehicle_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehicle.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvVehicle.SelectedRows[0];

                txtBienSoXe.Text = selectedRow.Cells[0].Value.ToString();
                txtTenChuXe.Text = selectedRow.Cells[1].Value.ToString();
                txtMaTheCuDan.Text = selectedRow.Cells[2].Value.ToString();
                txtTenXe.Text = selectedRow.Cells[3].Value.ToString();
                cbbLoaiCoGioi.Text = selectedRow.Cells[4].Value.ToString();
                dtpNgayLap.Value = Convert.ToDateTime(selectedRow.Cells[5].Value);
                txtHSD.Text = selectedRow.Cells[6].Value.ToString();
            }
        }

        private void txtBoxSearch_TextChange(object sender, EventArgs e)
        {
            string searchTerm = txtBoxSearch.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = @"SELECT XE.BienSo, NGUOITHUE.TenNguoiThue, THECUDAN.MaTheCuDan, XE.TenXe, XE.LoaiCoGioi, THEXE.NgayLap, THEXE.HSD
         FROM THEXE
         INNER JOIN THECUDAN ON THEXE.MaTheCuDan = THECUDAN.MaTheCuDan
         INNER JOIN NGUOITHUE ON NGUOITHUE.MaNguoiThue = THECUDAN.MaNguoiThue
         INNER JOIN XE ON THEXE.MaTheXe = XE.MaTheXe
         WHERE XE.BienSo LIKE @searchTerm OR NGUOITHUE.TenNguoiThue LIKE @searchTerm OR THECUDAN.MaTheCuDan LIKE @searchTerm
         OR THEXE.HSD = @searchHSD";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    int searchHSD;
                    if (int.TryParse(searchTerm, out searchHSD))
                    {
                        command.Parameters.AddWithValue("@searchHSD", searchHSD);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@searchHSD", -1);
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvVehicle.Rows.Clear();

                        while (reader.Read())
                        {
                            int index = dgvVehicle.Rows.Add();

                            dgvVehicle.Rows[index].Cells[0].Value = reader["BienSo"];
                            dgvVehicle.Rows[index].Cells[1].Value = reader["TenNguoiThue"];
                            dgvVehicle.Rows[index].Cells[2].Value = reader["MaTheCuDan"];
                            dgvVehicle.Rows[index].Cells[3].Value = reader["TenXe"];
                            dgvVehicle.Rows[index].Cells[4].Value = reader["LoaiCoGioi"];
                            dgvVehicle.Rows[index].Cells[5].Value = reader["NgayLap"];
                            dgvVehicle.Rows[index].Cells[6].Value = reader["HSD"];
                        }
                    }
                }
            }
        }

        private void InsertData(string maTheCuDan, string bienSoXe, string tenXe, string loaiCoGioi)
        {
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Kiểm tra sự tồn tại của MaTheCuDan trong bảng THECUDAN
                string checkQuery = "SELECT COUNT(*) FROM THECUDAN WHERE MaTheCuDan = @maTheCuDan";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@maTheCuDan", maTheCuDan);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Lấy MaTheXe từ bảng THEXE
                        string selectQuery = "SELECT MaTheXe FROM THEXE WHERE MaNguoiThue = (SELECT MaNguoiThue FROM THECUDAN WHERE MaTheCuDan = @maTheCuDan)";
                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@maTheCuDan", maTheCuDan);
                            int maTheXe = (int)selectCommand.ExecuteScalar();

                            // Sử dụng giá trị maTheXe trong truy vấn INSERT
                            string insertQuery = @"INSERT INTO XE (MaTheXe, BienSo, TenXe, LoaiCoGioi)
                        VALUES (@maTheXe, @bienSoXe, @tenXe, @loaiCoGioi);";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@maTheXe", maTheXe);
                                insertCommand.Parameters.AddWithValue("@bienSoXe", bienSoXe);
                                insertCommand.Parameters.AddWithValue("@tenXe", tenXe);
                                insertCommand.Parameters.AddWithValue("@loaiCoGioi", loaiCoGioi);

                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        // MaTheCuDan mới, ném ra một ngoại lệ
                        throw new Exception("Không tìm thấy MaTheCuDan trong cơ sở dữ liệu. Vui lòng kiểm tra lại.");
                    }
                }
            }
        }

        private void bnfInsert_Click(object sender, EventArgs e)
        {
            string maTheCuDan = txtMaTheCuDan.Text;
            string bienSoXe = txtBienSoXe.Text;
            string tenChuXe = txtTenChuXe.Text;
            string tenXe = txtTenXe.Text;
            string loaiCoGioi = cbbLoaiCoGioi.SelectedItem.ToString();
            DateTime ngayLap = dtpNgayLap.Value;
            string hsd = txtHSD.Text;

            try
            {
                InsertData(maTheCuDan, bienSoXe, tenXe, loaiCoGioi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Thêm dữ liệu vào các bảng khác (NGUOITHUE, THEXE) ở đây

            MessageBox.Show("Thêm/Sửa thành công!");
            bindData();
        }
    }

}