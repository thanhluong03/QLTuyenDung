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
    public partial class ChiTietMuonSach : Form
    {
        string connectionString = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLThuVien;Integrated Security=True";
        ErrorProvider errorProvider = new ErrorProvider();

        private DataView dt = new DataView();

        public ChiTietMuonSach()
        {
            InitializeComponent();
            LoadDatatoComboBox();
            LoadtoDataGridView();
        }

        private void LoadtoDataGridView(string filter = "")
        {
            try
            {
                string querySelect = "Select_ChiTietMuonSach";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = querySelect;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable QLCTMS = new DataTable();
                            adapter.Fill(QLCTMS);
                            if (QLCTMS.Rows.Count > 0)
                            {
                                dt = QLCTMS.DefaultView;
                                if (filter != null)
                                {
                                    dt.RowFilter = filter;
                                }
                                dgv_chitietmuonsach.AutoGenerateColumns = false;
                                dgv_chitietmuonsach.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No records existence!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDatatoComboBox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadtoDataGridView();
                using (SqlCommand sqlCommand = new SqlCommand("select iMaMuon from tblMuonSach", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_mamuon.ValueMember = "iMaMuon";
                        cb_mamuon.DisplayMember = "iMaMuon";
                        cb_mamuon.DataSource = dt;
                        cb_mamuon.Text = string.Empty;
                    }
                }

                using (SqlCommand sqlCommand = new SqlCommand("select iMaSach, sTenSach from tblSach", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_masach.ValueMember = "iMaSach";
                        cb_masach.DisplayMember = "sTenSach";
                        cb_masach.DataSource = dt;
                        cb_masach.Text = string.Empty;
                    }
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {

                    string iMaMuon = cb_mamuon.SelectedValue.ToString();

                    {
                        sqlCommand.CommandText = "Select_MaMuon";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@iMaMuon", iMaMuon);
                        sqlConnection.Open();
                        var tmp = sqlCommand.ExecuteScalar();
                        sqlConnection.Close();

                        if (tmp != null)
                        {
                            sqlCommand.Parameters.Clear();
                            sqlCommand.CommandText = "Insert_ChiTietMuonSach";
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            sqlCommand.Parameters.AddWithValue("@iMaMuon", cb_mamuon.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@iMaSach", cb_masach.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@fSoLuongMuon", tb_soluongmuon.Text);
                            sqlCommand.Parameters.AddWithValue("@dNgayTra", dtp_ngaytra.Text);
                            sqlCommand.Parameters.AddWithValue("@sTrangThai", cb_trangthai.Text);
                            sqlCommand.Parameters.AddWithValue("@fGiaMuon", tb_giamuon.Text);
                            sqlConnection.Open();
                            int row_af = sqlCommand.ExecuteNonQuery();
                            if (row_af > 0)
                            {
                                MessageBox.Show("Thêm thành công!");
                                LoadDatatoComboBox();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã mượn " + iMaMuon + " không tồn tại!");
                        }
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cb_mamuon.Text = "";
            cb_masach.Text = "";
            cb_mamuon.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("Update_ChiTietMuonSach", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@iMaMuon", cb_mamuon.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@iMaSach", cb_masach.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@fSoLuongMuon", tb_soluongmuon.Text);
                    sqlCommand.Parameters.AddWithValue("@dNgayTra", dtp_ngaytra.Text);
                    sqlCommand.Parameters.AddWithValue("@sTrangThai", cb_trangthai.Text);
                    sqlCommand.Parameters.AddWithValue("@fGiaMuon", tb_giamuon.Text);

                    int row = sqlCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        cb_mamuon.Text = "";
                        cb_masach.Text = "";
                        tb_soluongmuon.Text = "";
                        dtp_ngaytra.Text = "";
                        cb_trangthai.Text = "";
                        tb_giamuon.Text = "";
                        LoadtoDataGridView();
                        this.Focus();
                    }
                }
                sqlConnection.Close();
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa chứ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(
                        "Delete from tblChiTietMuonSach where iMaMuon = @iMaMuon"
                        , con))
                    {

                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@iMaMuon", cb_mamuon.SelectedValue);

                        con.Open();
                        int row_af = command.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                        }
                    }

                }
                LoadtoDataGridView();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string filter = "iMaMuon IS NOT NULL";
            if (!string.IsNullOrEmpty(cb_mamuon.Text))
            {
                int mamuon = Convert.ToInt32(cb_mamuon.Text);
                filter += string.Format(" AND iMaMuon = {0}", mamuon);
            }
            else if (!string.IsNullOrEmpty(cb_masach.Text))
            {
                filter += string.Format(" AND sTenSach LIKE '%{0}%'", cb_masach.Text);
            }
            else if (!string.IsNullOrEmpty(tb_soluongmuon.Text))
            {
                int soluongmuon = Convert.ToInt32(tb_soluongmuon.Text);
                filter += string.Format(" AND fSoLuongMuon = {0}", soluongmuon);
            }
            else if (!string.IsNullOrEmpty(dtp_ngaytra.Text))
            {
                DateTime ngayTra = dtp_ngaytra.Value.Date; // Lấy giá trị ngày của DateTimePicker
                filter += string.Format(" AND dNgayTra = '{0}'", ngayTra.ToString("yyyy-MM-dd")); // Format ngày thành chuỗi yyyy-MM-dd

            }
            else if (!string.IsNullOrEmpty(cb_trangthai.Text))
            {
                string trangThai = cb_trangthai.SelectedItem.ToString(); // Lấy giá trị đã chọn từ ComboBox
                filter += string.Format(" AND sTrangThai = '{0}'", trangThai);

            }
            else if (!string.IsNullOrEmpty(tb_giamuon.Text))
            {
                float giamuon = Convert.ToInt32(tb_giamuon.Text);
                filter += string.Format(" AND fGiaMuon = {0}", giamuon);
            }
            else
            {
                MessageBox.Show("Không tìm thấy !");
            }
            MessageBox.Show("Đã tìm thấy <3");
            LoadtoDataGridView(filter);
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            cb_mamuon.Text = "";
            cb_masach.Text = "";
            tb_soluongmuon.Text = "";
            cb_trangthai.Text = "";
            tb_giamuon.Text = "";

            this.Focus();
            LoadtoDataGridView();
        }

        private void btn_inbc_Click(object sender, EventArgs e)
        {
            InBaoCaoMuonSach inBaoCao = new InBaoCaoMuonSach();
            inBaoCao.Show();
            inBaoCao.ShowBaoCao2("Select_BaoCaoChiTietMuonSach", "QLCTMS");
        }

        private void CheckButton()
        {
            if (string.IsNullOrEmpty(cb_mamuon.Text) || string.IsNullOrEmpty(cb_masach.Text) || string.IsNullOrEmpty(tb_soluongmuon.Text))
            {
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
            }
            else
            {
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
            }
        }

        private void dgv_chitietmuonsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_chitietmuonsach.CurrentRow.Index;
            cb_mamuon.Text = dgv_chitietmuonsach.Rows[index].Cells["iMaMuon"].Value.ToString();
            cb_masach.Text = dgv_chitietmuonsach.Rows[index].Cells["sTenSach"].Value.ToString();
            tb_soluongmuon.Text = dgv_chitietmuonsach.Rows[index].Cells["fSoLuongMuon"].Value.ToString();
            dtp_ngaytra.Text = dgv_chitietmuonsach.Rows[index].Cells["dNgayTra"].Value.ToString();
            cb_trangthai.Text = dgv_chitietmuonsach.Rows[index].Cells["sTrangThai"].Value.ToString();
            tb_giamuon.Text = dgv_chitietmuonsach.Rows[index].Cells["fGiaMuon"].Value.ToString();
        }

        private void cb_mamuon_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void cb_masach_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void tb_soluongmuon_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void cb_mamuon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_mamuon.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cb_mamuon, "Mã mượn chưa được nhập");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_mamuon, null);
            }
        }

        private void cb_masach_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_masach.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cb_masach, "Mã sách chưa được nhập");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_masach, null);
            }
        }

        private void tb_soluongmuon_Validating(object sender, CancelEventArgs e)
        {
            string sl = tb_soluongmuon.Text;
            if (string.IsNullOrEmpty(sl))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_soluongmuon, "Hãy nhập số lượng sách mượn");
            }
            else
            {
                int num;
                bool isNum = int.TryParse(sl, out num);
                if (!isNum)
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_soluongmuon, "Số lượng nhập sai");
                }
                else if (num < 0) // Kiểm tra giá trị âm
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_soluongmuon, "Số lượng mượn không được âm");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(tb_soluongmuon, null);
                }
            }
        }

        private void tb_giamuon_Validating(object sender, CancelEventArgs e)
        {
            string giamuon = tb_giamuon.Text;
            if (string.IsNullOrEmpty(giamuon))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_giamuon, "Hãy nhập giá mượn sách");
            }
            else
            {
                int num;
                bool isNum = int.TryParse(giamuon, out num);
                if (!isNum)
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_giamuon, "Gía mượn nhập sai");
                }
                else if (num < 0) // Kiểm tra giá trị âm
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_giamuon, "Giá mượn không được âm");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(tb_giamuon, null);
                }
            }
        }
    }
}
