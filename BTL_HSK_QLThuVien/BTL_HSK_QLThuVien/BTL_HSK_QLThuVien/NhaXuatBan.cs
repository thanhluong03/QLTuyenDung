using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_HSK_QLThuVien
{
    public partial class NhaXuatBan : Form
    {
        Main dch = new Main();
        public NhaXuatBan()
        {
            InitializeComponent();
        }

        private void NhaXuatBan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load ()
        {
            string danhsachNXB = "V_HienNXB";
            dch.HienthiDulieutrenDatagridView(danhsachNXB, dgrNXB);
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            int manxb = int.Parse(txtmanxb.Text);
            if (dch.ktraKhoa("tblNhaXuatBan", "iMaNXB", manxb) == true)
            {
                MessageBox.Show(String.Format("Đã tồn tại mã nhà xuất bản: {0} !! \n Không thể thêm", txtmanxb.Text),
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dch.KetnoiCSDL() == false)
                    return;

                string tennxb = txttennxb.Text;
                string diachi = txtdiachi.Text;
                string sdt = txtsodt.Text;
                SqlCommand cmd = new SqlCommand("pr_ThemNXB", dch.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manxb", manxb);
                cmd.Parameters.AddWithValue("@tennxb", tennxb);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@sodt", sdt);
                cmd.ExecuteNonQuery();

                load();
                MessageBox.Show(String.Format("Thêm thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgrNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanxb.Text = dgrNXB.CurrentRow.Cells["Mã Nhà Xuất Bản"].Value.ToString();
            txttennxb.Text = dgrNXB.CurrentRow.Cells["Tên Nhà Xuất Bản"].Value.ToString();
            txtdiachi.Text = dgrNXB.CurrentRow.Cells["Địa Chỉ"].Value.ToString();
            txtsodt.Text = dgrNXB.CurrentRow.Cells["Số Điện Thoại"].Value.ToString();
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            int manxb = int.Parse(txtmanxb.Text);
            if (dch.ktraKhoa("tblNhaXuatBan", "iMaNXB", manxb) == true)
            {
                if (dch.KetnoiCSDL() == false)
                    return;

                string tennxb = txttennxb.Text;
                string diachi = txtdiachi.Text;
                string sdt = txtsodt.Text;
                SqlCommand cmd = new SqlCommand("pr_UpdateNXB", dch.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manxb", manxb);
                cmd.Parameters.AddWithValue("@tennxb", tennxb);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@sodt", sdt);
                cmd.ExecuteNonQuery();

                load();
                MessageBox.Show(String.Format("Update thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(String.Format("Không tồn tại mã nhà xuất bản: {0} !! \n Không thể sửa", txtmanxb.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtmanxb.Text);
            if (dch.ktraKhoa("tblNhaXuatBan", "iMaNXB", ma) == false )
            {
                MessageBox.Show(String.Format("Không tồn tại mã nhà xuất bản: {0} !! \n Không thể xóa", txtmanxb.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string manxb = txtmanxb.Text;
                if (dch.KetnoiCSDL() == false)
                        return;
                if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa không!!"),
                                   "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
                try
                {
                    SqlCommand cmd = new SqlCommand("pr_DeleteNXB", dch.cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@manxb", manxb);
                    cmd.ExecuteNonQuery();
                    load();
                    MessageBox.Show(string.Format("Xóa thành công !!"),
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(String.Format("Tồn tại sách của nhà xuất bản: {0} !! \n Không thể xóa",txttennxb.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
             
        }

        private void btnTimKiemNXB_Click(object sender, EventArgs e)
        {
            string manxb = txtmanxb.Text;
            string tennxb = txttennxb.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsodt.Text;
            string timmanxb = "pr_TimKiemMaNXB";
            string timtennxb = "pr_TimKiemTenNXB";
            string timdiachinxb = "pr_TimKiemDiaChiNXB";
            string timsdtnxb = "pr_TimKiemSDTNXB";
            string timtenvadiachi = "pr_TimKiemTenvaDiaChi";

              if (txtmanxb.Text != "" && txttennxb.Text == "" && txtdiachi.Text == "" && txtsodt.Text == "")
               {
                   dch.Timkiemdl(timmanxb, "@manxb", manxb, dgrNXB);
                //   txtmanxb.Clear();
               }
               if (txtmanxb.Text == "" && txttennxb.Text != "" && txtdiachi.Text == "" && txtsodt.Text == "")
               {
                   dch.Timkiemdl(timtennxb, "@tennxb", tennxb, dgrNXB);
                   //txttennxb.Clear();
               }
               if (txtmanxb.Text == "" && txttennxb.Text == "" && txtdiachi.Text != "" && txtsodt.Text == "")
               {
                   dch.Timkiemdl(timdiachinxb, "@diachi", diachi, dgrNXB);
                  // txtdiachi.Clear();
               }
               if (txtmanxb.Text == "" && txttennxb.Text == "" && txtdiachi.Text == "" && txtsodt.Text != "")
               {
                   dch.Timkiemdl(timsdtnxb, "@sodt", sdt, dgrNXB);
                 //  txtsodt.Clear();
               }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load();
            txtmanxb.Clear();
            txttennxb.Clear();
            txtdiachi.Clear();
            txtsodt.Clear();
        }

        private void txtmanxb_Validating(object sender, CancelEventArgs e)
        {
            if (txtmanxb.Text == "")
            {
                errorProvider1.SetError(txtmanxb, "Không được để trống");
                txtmanxb.Focus();
            }
            else
            {
                try
                {
                    int manxb = int.Parse(txtmanxb.Text);
                    errorProvider1.SetError(txtmanxb, "");
                }
                catch
                {
                    errorProvider1.SetError(txtmanxb, "Mã phải là số");
                    txtmanxb.Focus();
                }
            }
        }

        private void txttennxb_Validating(object sender, CancelEventArgs e)
        {
           if(txttennxb.Text == dgrNXB.CurrentRow.Cells["Tên Nhà Xuất Bản"].Value.ToString())
            {
                errorProvider1.SetError(txttennxb, "Trùng tên nhà xuất bản");
                txttennxb.Focus();
            }
           else
            {
                errorProvider1.SetError(txttennxb, "");
            }
                
        }

        private void txtsodt_Validating(object sender, CancelEventArgs e)
        {
            if (txtsodt.Text == dgrNXB.CurrentRow.Cells["Số Điện Thoại"].Value.ToString())
            {
                errorProvider1.SetError(txtsodt, "Trùng số điện thoại");
                txtsodt.Focus();
            }
            else
            {
                errorProvider1.SetError(txtsodt, "");
            }
        }
    }
}
