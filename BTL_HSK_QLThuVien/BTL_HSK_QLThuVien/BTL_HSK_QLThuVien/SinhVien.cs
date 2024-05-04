using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_QLThuVien
{
    public partial class SinhVien : Form
    {
        Main a = new Main();
        public SinhVien()
        {
            InitializeComponent();
        }
        private void load()
        {
            string danhsachSV = "V_HienSV";
            a.HienthiDulieutrenDatagridView(danhsachSV, drgSV);
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            int maSV = int.Parse(txtmaSV.Text);
            if (a.ktraKhoa("tblSinhVien", "iMaSV", maSV) == true)
            {
                MessageBox.Show(String.Format("Mã nhân viên bị trùng!! \n Không thể thêm"),
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (a.KetnoiCSDL() == false)
                    return;
                string tenSV = txtTenSV.Text;
                DateTime ngaysinh = Convert.ToDateTime(NgaySinh.Text);
                string sdt = SDT.Text;
                string cccd = txtCCCD.Text;
                SqlCommand cmd = new SqlCommand("pr_ThemSV", a.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@TenSV", tenSV);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@sodt", sdt);
                cmd.Parameters.AddWithValue("@cccd", cccd);
                cmd.ExecuteNonQuery();
                load();
                MessageBox.Show(String.Format("Thêm thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int maSV = int.Parse(txtmaSV.Text);
            if (a.ktraKhoa("tblSinhVien", "iMaSV", maSV) == true)
            {
                if (a.KetnoiCSDL() == false)
                    return;

                string tenSV = txtTenSV.Text;
                DateTime ngaysinh = Convert.ToDateTime(NgaySinh.Text);
                string sdt = SDT.Text;
                string cccd = txtCCCD.Text;
                SqlCommand cmd = new SqlCommand("pr_SuaSV", a.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@TenSV", tenSV);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@sodt", sdt);
                cmd.Parameters.AddWithValue("@cccd", cccd);
                cmd.ExecuteNonQuery();

                load();
                MessageBox.Show(String.Format("Update thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(String.Format("Không có mã sinh Viên !! \n Không thể sửa"),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            int MaSV = int.Parse(txtmaSV.Text);
            if (a.ktraKhoa("tblSinhVien", "iMaSV", MaSV) == false)
            {
                MessageBox.Show(String.Format(" Không thể xóa", txtmaSV.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (a.KetnoiCSDL() == false)
                    return;
                if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa không!!"),
                                   "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
                try
                {
                    SqlCommand cmd = new SqlCommand("pr_DeleteSV", a.cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSV", MaSV);
                    cmd.ExecuteNonQuery();
                    load();
                    MessageBox.Show(string.Format("Xóa thành công !!"),
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(String.Format("Sinh viên đang mượn sách. Không thể xóa!!", txtmaSV.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            string ma = txtmaSV.Text;
            string ten = txtTenSV.Text;
            string sdt = SDT.Text;
            string cccd = txtCCCD.Text;
            string timma = "pr_TimKiemMaSV";
            string timten = "pr_TimKiemTenSV";
            string timSDT = "pr_TimKiemSVTheoSDT";
            string timCCCD = "pr_TimKiemSVTheoCCCD";

            if (txtmaSV.Text != "" && txtTenSV.Text == "" && SDT.Text == "" && txtCCCD.Text == "")
            {
                a.Timkiemdl(timma, "@ma", ma, drgSV);
                //   txtmaSV.Clear();
            }
            if (txtmaSV.Text == "" && txtTenSV.Text != "" && SDT.Text == "" && txtCCCD.Text == "")
            {
                a.Timkiemdl(timten, "@ten", ten, drgSV);
                //   txtmaSV.Clear();
            }
            if (txtmaSV.Text == "" && txtTenSV.Text == "" && SDT.Text != "" && txtCCCD.Text == "")
            {
                a.Timkiemdl(timSDT, "@SDT", sdt, drgSV);
                //   txtmaSV.Clear();
            }
            if (txtmaSV.Text == "" && txtTenSV.Text == "" && SDT.Text == "" && txtCCCD.Text != "")
            {
                a.Timkiemdl(timCCCD, "@CCCD", cccd, drgSV);
                //   txtmaSV.Clear();
            }


        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void drgSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaSV.Text = drgSV.CurrentRow.Cells["Mã sinh viên "].Value.ToString();
            txtTenSV.Text = drgSV.CurrentRow.Cells["Tên sinh viên "].Value.ToString();
            NgaySinh.Text = drgSV.CurrentRow.Cells["Ngày sinh "].Value.ToString();
            txtCCCD.Text = drgSV.CurrentRow.Cells["cccd"].Value.ToString();
            SDT.Text = drgSV.CurrentRow.Cells["số điện thoại"].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
