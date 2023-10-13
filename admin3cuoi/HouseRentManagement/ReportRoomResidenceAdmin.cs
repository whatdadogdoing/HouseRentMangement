using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.DataAccess.DataFederation;
using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.DataAccess.Sql;
using HouseRentManagement.QLCHCC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure.Design;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class ReportRoomResidenceAdmin : Form
    {
        public ReportRoomResidenceAdmin()
        {
            InitializeComponent();

        }
        private void ReportRoomResidenceAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                dbQLCHCC context = new dbQLCHCC();

                List<TANG> t = context.TANGs.ToList();
                List<CANHO> c = context.CANHOes.ToList();
                List<LOAICANHO> l = context.LOAICANHOes.ToList();
                List<NGUOITHUE> n = context.NGUOITHUEs.ToList();
                List<CHUSOHUU> ch = context.CHUSOHUUs.ToList();
                List<HOPDONGTHUE> h = context.HOPDONGTHUEs.ToList();
                binddata(t, c, l, n, ch,h);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void binddata(List<TANG>t,List<CANHO>c,List<LOAICANHO>l,List<NGUOITHUE>n,List<CHUSOHUU>ch,List<HOPDONGTHUE>h)
        {
            dgvDB.Rows.Clear();
            
            using (var context = new dbQLCHCC())
            {
                foreach (var item in c)
                {
                    int index = dgvDB.Rows.Add();
                    dgvDB.Rows[index].Cells[0].Value = item.MaCanHo;
                    var tang = t.Where(x => x.MaTang == item.MaTang).FirstOrDefault();
                    dgvDB.Rows[index].Cells[1].Value = tang.Tang1;
                    dgvDB.Rows[index].Cells[2].Value = item.TinhTrang;
                    var canho = h.Where(x => x.MaCanHo == item.MaCanHo).FirstOrDefault();
                    var nguoithue = n.Where(x => x.MaNguoiThue == canho.MaNguoiThue).FirstOrDefault();
                    dgvDB.Rows[index].Cells[3].Value = nguoithue.TenNguoiThue;
                    var chu = ch.Where(x=>x.MaChuSoHuu==canho.MaChuSoHuu).FirstOrDefault();
                    dgvDB.Rows[index].Cells[4].Value = chu.TenChuSoHuu;
                    var loai = l.Where(x=>x.MaLoai == item.MaLoai).FirstOrDefault();
                    dgvDB.Rows[index].Cells[5].Value = loai.TenLoai;
                }
            }
        }
    }
}
