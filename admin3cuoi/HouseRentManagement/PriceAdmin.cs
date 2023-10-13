using HouseRentManagement.QLCHCC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HouseRentManagement
{
    
    public partial class PriceAdmin : Form
    {
        private dbQLCHCC context;
        public PriceAdmin()
        {
            
            InitializeComponent();
            context = new dbQLCHCC();
            EnterData();

        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtUnit.Text == "" )
                    throw new Exception("Please enter all the information form");
                int s = getselectedrow(txtID.Text);
                if (s == -1)
                {
                    string a = txtStatus.Text;
                    if (a.Equals("Đang sử dụng") || a.Equals("Ngừng sử dụng") || string.IsNullOrEmpty(a))
                    {
                        txtStatus.Text = a;
                    }
                    else
                    {
                        MessageBox.Show("Only enter 'Đang sử dụng' or 'Ngừng sử dụng' for data 'Status'",
                            "Error", MessageBoxButtons.OK);
                        txtStatus.Text = "";
                    }

                    var bg = new BANGGIA()
                    {
                        MaBangGia = txtID.Text,
                        TenDichVu = txtName.Text,
                        DonViTinh = txtUnit.Text,
                        GiaTien = Convert.ToDecimal(txtCost.Text),
                        TrangThai = string.IsNullOrEmpty(txtStatus.Text)?null:txtStatus.Text,
                    };
                    context.BANGGIAs.Add(bg);
                    context.SaveChanges();
                    s = dgvPrice.Rows.Add();
                    insert(s);
                    MessageBox.Show("Added data successfully", "Notification", MessageBoxButtons.OK);
                }
                else
                {

                    string a = txtStatus.Text;
                    if (a.Equals("Đang sử dụng") || a.Equals("Ngừng sử dụng") || string.IsNullOrEmpty(a))
                    {
                        txtStatus.Text = a;
                    }
                    else
                    {
                        MessageBox.Show("Only enter 'Đang sử dụng' or 'Ngừng sử dụng' for data 'Status'",
                            "Error", MessageBoxButtons.OK);
                        txtStatus.Text = "";
                    }
                    BANGGIA dbUpdate = context.BANGGIAs.FirstOrDefault(p => p.MaBangGia == txtID.Text);
                    if(dbUpdate != null)
                    {
                        dbUpdate.TenDichVu = txtName.Text;
                        dbUpdate.DonViTinh = txtUnit.Text;
                        dbUpdate.GiaTien = Convert.ToDecimal(txtCost.Text);
                        dbUpdate.TrangThai = string.IsNullOrEmpty(txtStatus.Text) ? null : txtStatus.Text;

                        context.SaveChanges();
                    }
                    insert(s);
                    MessageBox.Show("Updated data successfully", "Notification", MessageBoxButtons.OK);
                }
                txtID.Text = txtName.Text = txtUnit.Text = txtStatus.Text = txtCost.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<BANGGIA> bg)
        {
            dgvPrice.Rows.Clear();
            foreach (var item in bg)
            {
                int index = dgvPrice.Rows.Add();
                dgvPrice.Rows[index].Cells[0].Value = item.MaBangGia;
                dgvPrice.Rows[index].Cells[1].Value = item.TenDichVu;
                dgvPrice.Rows[index].Cells[2].Value = item.DonViTinh;
                dgvPrice.Rows[index].Cells[3].Value = (float)item.GiaTien;
                dgvPrice.Rows[index].Cells[4].Value = item.TrangThai;
            }
        }
        private int getselectedrow(string id)
        {
            for (int i = 0; i < dgvPrice.Rows.Count; i++)
            {
                if (dgvPrice.Rows[i].Cells[0].Value.ToString() == id)
                {
                    return i;
                }

            }
            return -1;
        }
        private void insert(int row)
        {
           
            dgvPrice.Rows[row].Cells[0].Value = txtID.Text;
            dgvPrice.Rows[row].Cells[1].Value = txtName.Text;
            dgvPrice.Rows[row].Cells[2].Value = txtUnit.Text;
            dgvPrice.Rows[row].Cells[4].Value = txtStatus.Text;
            float c = float.Parse(txtCost.Text);
            if ( c == 0)
            {
                MessageBox.Show("The amount entered is invalid", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                dgvPrice.Rows[row].Cells["clCost"].Value = c.ToString();
            }
            
        }
        private void EnterData()
        {
            try
            {
                dbQLCHCC context = new dbQLCHCC();

                List<BANGGIA> bg = context.BANGGIAs.ToList();

                BindGrid(bg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            try
            {
                int s = getselectedrow(txtID.Text);
                if (s == -1)
                {
                    throw new Exception("Can't find the ID to be deleted");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete?", "Yes/No", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        string ma = dgvPrice.Rows[s].Cells[0].Value.ToString();
                        var bg = context.BANGGIAs.FirstOrDefault(x => x.MaBangGia == ma);
                        context.BANGGIAs.Remove(bg);
                        context.SaveChanges();
                        dgvPrice.Rows.RemoveAt(s);
                        MessageBox.Show("Deleted successfully", "Notification", MessageBoxButtons.OK);
                        txtID.Text = txtName.Text = txtUnit.Text = txtStatus.Text = txtCost.Text = "";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dgvPrice.Rows[e.RowIndex];
                txtID.Text = r.Cells["clID"].Value.ToString();
                txtName.Text = r.Cells["clName"].Value.ToString();
                if (!object.ReferenceEquals(r.Cells["clStatus"].Value, DBNull.Value))
                {
                    
                }
                object v = r.Cells["clStatus"].Value;
                txtStatus.Text = string.Concat(v);
                txtUnit.Text = r.Cells["clUnit"].Value.ToString();
                txtCost.Text = r.Cells["clCost"].Value.ToString();
            }
            catch (Exception ex)
            {}
        }
        private void sear(string s)
        {
            dgvPrice.ClearSelection();
            foreach (DataGridViewRow row in dgvPrice.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().Contains(s) ||
                    row.Cells[1].Value.ToString().ToLower().Contains(s) ||
                    row.Cells[2].Value.ToString().ToLower().Contains(s) ||
                    row.Cells[3].Value.ToString().ToLower().Contains(s) )
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBoxSearch_TextChange(object sender, EventArgs e)
        {
            string st = txtBoxSearch.Text;
            sear(st);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Please enter the correct data type", "Error", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Please enter the correct data type", "Error", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
    }
}
