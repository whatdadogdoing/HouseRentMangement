using DevExpress.XtraEditors;
using HouseRentManagement.HRMcontextDB;
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
    public partial class CondoServiceAdmin : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;


        private DataTable dataTable = new DataTable();
        public CondoServiceAdmin()
        {
            InitializeComponent();
            LoadCondoIDs();
        }


        private void BindGrid()
        {
            dgvCondoServicesAdmin.Rows.Clear();

            // Kiểm tra nếu DataTable có dữ liệu
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Duyệt qua từng dòng trong DataTable và thêm chúng vào DataGridView
                foreach (DataRow row in dataTable.Rows)
                {
                    // Thêm một hàng mới vào DataGridView
                    int rowIndex = dgvCondoServicesAdmin.Rows.Add();

                    // Đặt giá trị cho các ô trong hàng mới
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[0].Value = row["CondoID"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[1].Value = row["Service Name"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[2].Value = row["Date"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[3].Value = row["Content"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[4].Value = row["StartDate"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[5].Value = row["EndDate"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[6].Value = row["Fine"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[7].Value = row["MoneySpend"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[8].Value = row["FormStatus"];
                }
            }
        }

        private void LoadCondoIDs()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT MaCanHo FROM CANHO";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string condoID = reader["MaCanHo"].ToString();
                            cbbCondoID.Items.Add(condoID);
                        }
                    }
                }
            }
        }

        // Khi bạn muốn tải và hiển thị dữ liệu, gọi LoadDataFromDatabase và BindGrid
        private void LoadAndDisplayData()
        {
            LoadDataFromDatabase(); // Tải dữ liệu từ cơ sở dữ liệu
            BindGrid(); // Hiển thị dữ liệu trên DataGridView
        }

        private void CondoServiceAdmin_Load(object sender, EventArgs e)
        {
            LoadAndDisplayData();
        }
        private void cbbCondoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            string selectedCondoID = cbbCondoID.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCondoID))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
        SELECT 
            c.MaCanHo AS 'CondoID',
            CASE
                WHEN pp.SoPhieuPhanHoi IS NOT NULL THEN 'Report Form'
                WHEN ps.SoPhieuSuaChua IS NOT NULL THEN 'Repair Form'
                WHEN pp2.SoPhieuPhat IS NOT NULL THEN 'Fine Form'
                WHEN pc.SoPhieuChuyenDo IS NOT NULL THEN 'Transfer Form'
                WHEN pt.SoPhieuThiCong IS NOT NULL THEN 'Construction Form'
                ELSE ''
            END AS 'Service Name',
            CASE
                WHEN pp.SoPhieuPhanHoi IS NOT NULL THEN pp.NgayLap
                WHEN ps.SoPhieuSuaChua IS NOT NULL THEN ps.NgayLap
                WHEN pp2.SoPhieuPhat IS NOT NULL THEN pp2.NgayLap
                WHEN pc.SoPhieuChuyenDo IS NOT NULL THEN pc.NgayLap
                WHEN pt.SoPhieuThiCong IS NOT NULL THEN pt.NgayLap
                ELSE NULL
            END AS 'Date',
            CASE
                WHEN pp.SoPhieuPhanHoi IS NOT NULL THEN pp.NoiDung
                WHEN ps.SoPhieuSuaChua IS NOT NULL THEN ps.NoiDung
                WHEN pp2.SoPhieuPhat IS NOT NULL THEN pp2.NoiDung
                WHEN pc.SoPhieuChuyenDo IS NOT NULL THEN pc.NoiDung
                WHEN pt.SoPhieuThiCong IS NOT NULL THEN pt.NoiDung
                ELSE NULL
            END AS 'Content',
            CASE
                WHEN pt.SoPhieuThiCong IS NOT NULL THEN pt.BDThiCong
                WHEN pc.SoPhieuChuyenDo IS NOT NULL THEN pc.BDChuyen
                ELSE NULL
            END AS 'StartDate',
            CASE
                WHEN pt.SoPhieuThiCong IS NOT NULL THEN pt.KTThiCong
                WHEN pc.SoPhieuChuyenDo IS NOT NULL THEN pc.KTChuyen
                ELSE NULL
            END AS 'EndDate',
            CASE
                WHEN pp2.SoPhieuPhat IS NOT NULL THEN pp2.ThanhTien
                ELSE NULL
            END AS 'Fine',
            CASE
                WHEN ps.SoPhieuSuaChua IS NOT NULL THEN ps.TongTien
                ELSE NULL
            END AS 'MoneySpend',
            CASE
                WHEN pp.SoPhieuPhanHoi IS NOT NULL THEN pp.TinhTrang
                WHEN ps.SoPhieuSuaChua IS NOT NULL THEN ''
                WHEN pp2.SoPhieuPhat IS NOT NULL THEN ''
                WHEN pc.SoPhieuChuyenDo IS NOT NULL THEN pc.TrangThai
                WHEN pt.SoPhieuThiCong IS NOT NULL THEN pt.TinhTrang
                ELSE NULL
            END AS 'FormStatus'
        FROM CANHO c
        LEFT JOIN PHIEUPHANHOI pp ON c.MaCanHo = pp.MaCanHo
        LEFT JOIN PHIEUSUACHUA ps ON c.MaCanHo = ps.MaCanHo
        LEFT JOIN PHIEUPHAT pp2 ON c.MaCanHo = pp2.MaCanHo
        LEFT JOIN PHIEUCHUYENDO pc ON c.MaCanHo = pc.MaCanHo
        LEFT JOIN PHIEUTHICONG pt ON c.MaCanHo = pt.MaCanHo
        WHERE c.MaCanHo = @SelectedCondoID
                    ";



                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SelectedCondoID", selectedCondoID);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dataTable.Clear(); // Xóa dữ liệu cũ
                        adapter.Fill(dataTable);

                        // Gọi lại hàm BindGrid để hiển thị dữ liệu mới
                        BindGrid();
                    }



                }
            }
        }
    }
}