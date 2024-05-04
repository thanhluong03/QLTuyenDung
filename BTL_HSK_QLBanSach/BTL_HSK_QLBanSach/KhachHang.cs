using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_QLBanSach
{
    public partial class KhachHang : Form
    {
        Main dch = new Main();
        string strKhachHang = "vDSKH";
        public KhachHang()
        {
            InitializeComponent();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            dch.HienthiDulieutrenDatagridView(strKhachHang, dgvKhachHang);
            toolTip1.SetToolTip(txtSdtKH, "Chỉ được nhập ký tự từ 0-9");
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DateTime date = Convert.ToDateTime(dgvKhachHang.CurrentRow.Cells["Ngày Sinh"].Value);

            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells["Tên Khách Hàng"].Value.ToString();
            txtDiaChiKH.Text = dgvKhachHang.CurrentRow.Cells["Địa Chỉ"].Value.ToString();
            txtNgaySinhKH.Text = date.ToString("dd/MM/yyyy");
            txtSdtKH.Text = dgvKhachHang.CurrentRow.Cells["SDT"].Value.ToString();

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            String format = "dd/MM/yyyy";
            string maKH;
            string tenKH;
            string diaChi;
            DateTime ngaySinh;
            string sdt;

            maKH = "";
            tenKH = txtTenKH.Text;
            diaChi = txtDiaChiKH.Text;
            ngaySinh = DateTime.ParseExact(txtNgaySinhKH.Text, format, CultureInfo.InvariantCulture);
            ngaySinh = DateTime.Parse(txtNgaySinhKH.Text);
            sdt = txtSdtKH.Text;


            try
            {
                if (dch.KetnoiCSDL() == false) return;
                string query = "select max(sMaKH) from tblKhachHang";
                using (SqlCommand cmd = new SqlCommand(query, dch.cnn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int id = int.Parse(result.ToString().Substring(3)) + 1;
                        maKH = "MKH" + id.ToString();
                    }
                }
                using (SqlCommand cmd = new SqlCommand("insert_kh", dch.cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maKH", maKH);
                    cmd.Parameters.AddWithValue("@tenKH", tenKH);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);

                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.ExecuteNonQuery();
                    dch.HienthiDulieutrenDatagridView(strKhachHang, dgvKhachHang);
                }


            }
            catch
            {
                MessageBox.Show("Lỗi thêm dữ liệu", "Thông báo");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String format = "dd/MM/yyyy";
            string maKH;
            string tenKH;
            string diaChi;
            DateTime ngaySinh;
            string sdt;

            maKH = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            tenKH = txtTenKH.Text;
            diaChi = txtDiaChiKH.Text;
            ngaySinh = DateTime.ParseExact(txtNgaySinhKH.Text, format, CultureInfo.InvariantCulture);

            sdt = txtSdtKH.Text;

            try
            {
                if (dch.KetnoiCSDL() == false) return;

                using (SqlCommand cmd = new SqlCommand("update_kh", dch.cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maKH", maKH);
                    cmd.Parameters.AddWithValue("@tenKH", tenKH);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);

                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.ExecuteNonQuery();
                    dch.HienthiDulieutrenDatagridView(strKhachHang, dgvKhachHang);
                }


            }
            catch
            {
                MessageBox.Show("Lỗi sửa dữ liệu", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maKH = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            try
            {
                if (dch.KetnoiCSDL() == false) return;

                using (SqlCommand cmd = new SqlCommand("prXoaKhachHang", dch.cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maKH", maKH);

                    cmd.ExecuteNonQuery();
                    dch.HienthiDulieutrenDatagridView(strKhachHang, dgvKhachHang);
                }


            }
            catch
            {
                MessageBox.Show("Lỗi sửa dữ liệu", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đóng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tenkh = txtInputSearch.Text;
            string query = "select * from vDSKH where [Tên Khách Hàng] LIKE '%" + tenkh + "%'";
            try
            {
                if (dch.KetnoiCSDL() == false) return;
                using (SqlCommand cmd = new SqlCommand(query, dch.cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvKhachHang.DataSource = tb;

                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void txtInputSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputSearch.Text))
            {
                dch.HienthiDulieutrenDatagridView(strKhachHang, dgvKhachHang);
            }
        }



        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                errorProvider1.SetError(txtTenKH, "Tên khách hàng không được bỏ trống");
                this.errorProvider1.SetIconPadding(this.txtTenKH, -20);
                e.Cancel = true;
                txtTenKH.Focus();
            }
            else
            {
                errorProvider1.SetError(txtTenKH, "");
            }
        }

        private void txtSdtKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
