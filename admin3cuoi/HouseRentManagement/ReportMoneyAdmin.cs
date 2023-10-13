using DevExpress.ClipboardSource.SpreadsheetML;
using HouseRentManagement.QLCHCC;
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
    
    public partial class ReportMoneyAdmin : Form
    {
        public DataGridView GetDgv()
        {
            return dgvDB;
        }
        public ReportMoneyAdmin()
        {
            InitializeComponent();
        }

        public void ReportMoneyAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                dbQLCHCC context = new dbQLCHCC();

                List<BANGGIA> b = context.BANGGIAs.ToList();
                List<CTHDTT> c = context.CTHDTTs.ToList();
                List<HOADONTHANHTOAN> h = context.HOADONTHANHTOANs.ToList();
                binddata(b,h,c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void binddata(List<BANGGIA>b,List<HOADONTHANHTOAN>h,List<CTHDTT>c)
        {
            dgvDB.Rows.Clear();
            foreach(var item in c)
            {
                int index = dgvDB.Rows.Add();
                dgvDB.Rows[index].Cells[0].Value = item.SoHoaDon;
                var chitiet = h.Where(x => x.SoHoaDon == item.SoHoaDon).FirstOrDefault();
                dgvDB.Rows[index].Cells[1].Value = chitiet.MaCanHo;
                var bang = b.Where(x=>x.MaBangGia == item.MaBangGia).FirstOrDefault();
                dgvDB.Rows[index].Cells[2].Value = bang.TenDichVu;
                dgvDB.Rows[index].Cells[3].Value = item.TuNgay;
                dgvDB.Rows[index].Cells[4].Value = item.DenNgay;
                dgvDB.Rows[index].Cells[5].Value = chitiet.NgayLap;
                dgvDB.Rows[index].Cells[6].Value = bang.GiaTien;
                dgvDB.Rows[index].Cells[7].Value = item.SoLuong;
                dgvDB.Rows[index].Cells[8].Value = bang.DonViTinh;
                dgvDB.Rows[index].Cells[9].Value = item.ThanhTien;
                if (c.Last(x => x.SoHoaDon == item.SoHoaDon) == item)
                {
                    dgvDB.Rows[index].Cells[10].Value = chitiet.TongTien;
                }
                dgvDB.Rows[index].Cells[11].Value = bang.TrangThai;
                dgvDB.Rows[index].Cells[12].Value = chitiet.GhiChu;
            }
        }
    }
}
