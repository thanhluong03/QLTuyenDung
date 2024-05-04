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
using System.Configuration;
using System.Globalization;
namespace BTL_HSK_QLBanSach
{
    public partial class NhanVien : Form
    {
        Main dch = new Main();
        string strNhanVien = "vDSNV";
        public NhanVien()
        {
            InitializeComponent();
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            dch.HienthiDulieutrenDatagridView(strNhanVien, dgvNhanVien);
            ttipSdtNV.SetToolTip(txtSdtNV, "Chỉ được nhập ký tự từ 0-9");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DateTime date = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells["Ngày Sinh"].Value);
            DateTime dateVao = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells["Ngày Vào"].Value);
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["Tên Nhân Viên"].Value.ToString();
            txtDiaChiNV.Text = dgvNhanVien.CurrentRow.Cells["Địa Chỉ"].Value.ToString();
            txtNgaySinhNV.Text = date.ToString("dd/MM/yyyy");
            txtSdtNV.Text = dgvNhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            txtNgayVaoLam.Text = dateVao.ToString("dd/MM/yyyy");
        }

        private void btnADD_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtDiaChiNV.Text) || string.IsNullOrEmpty(txtNgaySinhNV.Text) || string.IsNullOrEmpty(txtNgayVaoLam.Text))
            {
                MessageBox.Show("Không được để trống các ô!", "Thông báo");

            }
            else
            {
                String format = "dd/MM/yyyy";
                string maNV;
                string tenNV;
                string diaChi;
                DateTime ngaySinh;
                string sdt;
                DateTime ngayVao;
                tenNV = txtTenNV.Text;
                diaChi = txtDiaChiNV.Text;
                ngaySinh = DateTime.ParseExact(txtNgaySinhNV.Text, format, CultureInfo.InvariantCulture);
                maNV = "MNV1";
                sdt = txtSdtNV.Text;
                ngayVao = DateTime.ParseExact(txtNgayVaoLam.Text, format, CultureInfo.InvariantCulture);
                string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    string query = "select max(sMaNV) from tblNhanVien";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    object result = cmd.ExecuteScalar();


                    if (result != DBNull.Value)
                    {
                        int id = int.Parse(result.ToString().Substring(3)) + 1;
                        maNV = "MNV" + id.ToString();
                    }

                }
                try
                {
                    if (dch.KetnoiCSDL() == false) return;
                    try
                    {

                        using (SqlCommand cmd = new SqlCommand("insert_nv", dch.cnn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maNV", maNV);
                            cmd.Parameters.AddWithValue("@tenNV", tenNV);
                            cmd.Parameters.AddWithValue("@diaChi", diaChi);
                            cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                            cmd.Parameters.AddWithValue("@ngayVao", ngayVao);
                            cmd.Parameters.AddWithValue("@sdt", sdt);
                            cmd.ExecuteNonQuery();
                            dch.HienthiDulieutrenDatagridView(strNhanVien, dgvNhanVien);
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("Đã tồn nhân viên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi thêm dữ liệu", "Thông báo");
                }
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String format = "dd/MM/yyyy";
            string maNV;
            string tenNV;
            string diaChi;
            DateTime ngaySinh;
            string sdt;
            DateTime ngayVao;
            maNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            tenNV = txtTenNV.Text;
            diaChi = txtDiaChiNV.Text;
            ngaySinh = DateTime.ParseExact(txtNgaySinhNV.Text, format, CultureInfo.InvariantCulture);
            ngaySinh = DateTime.Parse(txtNgaySinhNV.Text);
            sdt = txtSdtNV.Text;
            ngayVao = DateTime.ParseExact(txtNgayVaoLam.Text, format, CultureInfo.InvariantCulture);

            try
            {
                if (dch.KetnoiCSDL() == false) return;

                using (SqlCommand cmd = new SqlCommand("update_nv", dch.cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@tenNV", tenNV);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@ngayVao", ngayVao);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.ExecuteNonQuery();
                    dch.HienthiDulieutrenDatagridView(strNhanVien, dgvNhanVien);
                }


            }
            catch
            {
                MessageBox.Show("Lỗi sửa dữ liệu", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            if (dgvNhanVien.Rows.Count <= 0)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dch.Xoadulieu("delete_nv", "@maNV", manv);
                dch.HienthiDulieutrenDatagridView(strNhanVien, dgvNhanVien);
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
            string tennv = txtInputSearch.Text;
            string query = "select * from vDSNV where [Tên Nhân Viên] LIKE '%" + tennv + "%'";
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
                        dgvNhanVien.DataSource = tb;

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
                dch.HienthiDulieutrenDatagridView(strNhanVien, dgvNhanVien);
            }
        }



        private void txtSdtNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                errorProvider.SetError(txtTenNV, "Tên nhân viên không được để trống");
                this.errorProvider.SetIconPadding(this.txtTenNV, -20);
                e.Cancel = true;
                txtTenNV.Focus();
            }
            else
            {
                errorProvider.SetError(txtTenNV, "");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           /* this.Close();
            fBaoCao f = new fBaoCao();
            f.Show();*/
        }
    }
}
