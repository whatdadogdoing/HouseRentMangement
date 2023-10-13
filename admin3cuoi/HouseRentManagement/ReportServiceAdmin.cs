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
    public partial class ReportServiceAdmin : Form
    {
        public ReportServiceAdmin()
        {
            InitializeComponent();
        }

        private void ReportServiceAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                dbQLCHCC context = new dbQLCHCC();
                List<CANHO> c = context.CANHOes.ToList();
                List<PHIEUCHUYENDO> d = context.PHIEUCHUYENDOes.ToList();
                List<PHIEUTHICONG> t = context.PHIEUTHICONGs.ToList();
                List<PHIEUSUACHUA> s = context.PHIEUSUACHUAs.ToList();
                List<PHIEUPHAT> p = context.PHIEUPHATs.ToList();
                List<PHIEUPHANHOI> ph = context.PHIEUPHANHOIs.ToList();
                bindData(c, d, t, s, p, ph);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bindData(List<CANHO>c,List<PHIEUCHUYENDO>d,List<PHIEUTHICONG>t,
            List<PHIEUSUACHUA>s,List<PHIEUPHAT>p,List<PHIEUPHANHOI>h)
        {
            dgvDB.Rows.Clear();
            foreach(var item in c)
            {
                int index = dgvDB.Rows.Add();
                dgvDB.Rows[index].Cells[0].Value = item.MaCanHo;
                int cd = d.Where(x=>x.MaCanHo==item.MaCanHo).Count();
                dgvDB.Rows[index].Cells[1].Value = cd.ToString();
                int tc = t.Where(x => x.MaCanHo == item.MaCanHo).Count();
                dgvDB.Rows[index].Cells[2].Value = tc.ToString();
                int sc = s.Where(x=>x.MaCanHo==item.MaCanHo).Count();
                dgvDB.Rows[index].Cells[3].Value = sc.ToString();
                int pp = p.Where(x => x.MaCanHo == item.MaCanHo).Count();
                dgvDB.Rows[index].Cells[4].Value = pp.ToString();
                int ph = h.Where(x => x.MaCanHo == item.MaCanHo).Count();
                dgvDB.Rows[index].Cells[5].Value = ph.ToString();
                decimal tsc = s.Where(x => x.MaCanHo == item.MaCanHo).Sum(f => f.TongTien.Value);
                dgvDB.Rows[index].Cells[6].Value = tsc.ToString();
                decimal tp = p.Where(x => x.MaCanHo == item.MaCanHo).Sum(f => f.ThanhTien.Value);
                dgvDB.Rows[index].Cells[7].Value = tp.ToString();
            }
        }
    }
}
