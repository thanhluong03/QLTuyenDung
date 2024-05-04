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
    public partial class NhanVien : Form
    {
        Main a = new Main();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            string danhsachNV = "V_HienNV";
            a.HienthiDulieutrenDatagridView(danhsachNV, drgNV);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(txtmaNV.Text);
            if (a.ktraKhoa("tblNhanVien", "iMaNv", maNV) == true)
            {
                MessageBox.Show(String.Format("Mã nhân viên bị trùng!! \n Không thể thêm"),
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (a.KetnoiCSDL() == false)
                    return;
                string tennv = txtTenNV.Text;
                string gioitinh = txtGioiTinh.Text;
                string diachi = txtDiaChi.Text;
                DateTime ngaysinh = Convert.ToDateTime(NgaySinh.Text);
                DateTime ngayvaolam = Convert.ToDateTime(NgayVaoLam.Text);
                string sdt = txtSDT.Text;
                SqlCommand cmd = new SqlCommand("pr_ThemNV", a.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@tenNV", tennv);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
                cmd.Parameters.AddWithValue("@sodt", sdt);
                cmd.ExecuteNonQuery();


                load();
                MessageBox.Show(String.Format("Thêm thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(txtmaNV.Text);
            if (a.ktraKhoa("tblNhanVien", "iMaNV", maNV) == true)
            {
                if (a.KetnoiCSDL() == false)
                    return;

                string tenNV = txtTenNV.Text;
                string gioitinh = txtGioiTinh.Text;
                string diachi = txtDiaChi.Text;
                DateTime ngaysinh = Convert.ToDateTime(NgaySinh.Text);
                DateTime ngayvaolam = Convert.ToDateTime(NgayVaoLam.Text);
                string sdt = txtSDT.Text;
                SqlCommand cmd = new SqlCommand("pr_SuaNV", a.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@tenNV", tenNV);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
                cmd.Parameters.AddWithValue("@sodt", sdt);
                cmd.ExecuteNonQuery();

                load();
                MessageBox.Show(String.Format("Update thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(String.Format("Không có mã nhà xuất bản !! \n Không thể sửa"),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int MaNV = int.Parse(txtmaNV.Text);
            if (a.ktraKhoa("tblNhanVien", "iMaNV", MaNV) == false)
            {
                MessageBox.Show(String.Format(" Không thể xóa", txtmaNV.Text),
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
                    SqlCommand cmd = new SqlCommand("pr_DeleteNV", a.cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNV", MaNV);
                    cmd.ExecuteNonQuery();
                    load();
                    MessageBox.Show(string.Format("Xóa thành công !!"),
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(String.Format("Nhân viên đang cho mượn sách. Không thể xóa!!", txtmaNV.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void drgNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaNV.Text = drgNV.CurrentRow.Cells["Mã Nhân Viên "].Value.ToString();
            txtTenNV.Text = drgNV.CurrentRow.Cells["Tên Nhân Viên "].Value.ToString();
            txtGioiTinh.Text = drgNV.CurrentRow.Cells["Giới tính "].Value.ToString();
            txtDiaChi.Text = drgNV.CurrentRow.Cells["Địa Chỉ "].Value.ToString();
            NgaySinh.Text = drgNV.CurrentRow.Cells["Ngày sinh "].Value.ToString();
            NgayVaoLam.Text = drgNV.CurrentRow.Cells["Ngày Vào Làm"].Value.ToString();
            txtSDT.Text = drgNV.CurrentRow.Cells["SDT"].Value.ToString();
        }

        private void drgNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            string ma = txtmaNV.Text;
            string tenNV = txtTenNV.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string timma = "pr_TimKiemMaNV";
            string timten = "pr_TimKiemTenNV";
            string timSDT = "pr_TimKiemNVTheoSDT";
            string timdiachi = "pr_TimKiemNVTheoDiaChi";


            if (txtmaNV.Text != "" && txtTenNV.Text == "" && txtDiaChi.Text == "" && txtSDT.Text == "")
            {
                a.Timkiemdl(timma, "@ma", ma, drgNV);

            }
            if (txtmaNV.Text == "" && txtTenNV.Text != "" && txtDiaChi.Text == "" && txtSDT.Text == "")
            {
                a.Timkiemdl(timten, "@ten", tenNV, drgNV);

            }
            if (txtmaNV.Text == "" && txtTenNV.Text == "" && txtDiaChi.Text != "" && txtSDT.Text == "")
            {
                a.Timkiemdl(timdiachi, "@DiaChi", diachi, drgNV);
            }
            if (txtmaNV.Text == "" && txtTenNV.Text == "" && txtDiaChi.Text == "" && txtSDT.Text != "")
            {
                a.Timkiemdl(timSDT, "@SDT", sdt, drgNV);
            }

        }
    }
}
