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
    public partial class MuonSach : Form
    {
        string connectionString = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLThuVien;Integrated Security=True";
        ErrorProvider errorProvider = new ErrorProvider();

        private DataView dt = new DataView();

        public MuonSach()
        {
            InitializeComponent();
            LoadtoDataGridView();
            LoadDatatoComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_mamuon.Focus();
            cb_manv.Text = "";
            cb_masv.Text = "";
        }
        private void CheckButton()
        {
            if (string.IsNullOrEmpty(tb_mamuon.Text) || string.IsNullOrEmpty(cb_masv.Text) || string.IsNullOrEmpty(cb_manv.Text))
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


        private void LoadtoDataGridView(string filter = "")
        {
            try
            {
                string querySelect = "Select_tblMuonSach";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = querySelect;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable QLMS = new DataTable();
                            adapter.Fill(QLMS);
                            if (QLMS.Rows.Count > 0)
                            {
                                dt = QLMS.DefaultView;
                                if (filter != null)
                                {
                                    dt.RowFilter = filter;
                                }
                                dgv_muonsach.AutoGenerateColumns = false;
                                dgv_muonsach.DataSource = dt;
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
                using (SqlCommand sqlCommand = new SqlCommand("select iMaNV,sTenNV from tblNhanVien", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_manv.ValueMember = "iMaNV";
                        cb_manv.DisplayMember = "sTenNV";
                        cb_manv.DataSource = dt;
                        cb_manv.Text = string.Empty;
                    }
                }
            }

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadtoDataGridView();
                using (SqlCommand sqlCommand = new SqlCommand("select iMaSV,sTenSV from tblSinhVien", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_masv.ValueMember = "iMaSV";
                        cb_masv.DisplayMember = "sTenSV";
                        cb_masv.DataSource = dt;
                        cb_masv.Text = string.Empty;
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

                    string iMaMuon = tb_mamuon.Text;

                    {
                        sqlCommand.CommandText = "Select_MaMuon";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@iMaMuon", iMaMuon);
                        sqlConnection.Open();
                        var tmp = sqlCommand.ExecuteScalar();
                        sqlConnection.Close();

                        if (tmp == null)
                        {
                            sqlCommand.Parameters.Clear();
                            sqlCommand.CommandText = "Insert_MuonSach";
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            sqlCommand.Parameters.AddWithValue("@iMaMuon", tb_mamuon.Text);
                            sqlCommand.Parameters.AddWithValue("@iMaNV", cb_manv.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@iMaSV", cb_masv.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@dNgayMuon", dtp_ngaymuon.Text);
                            sqlCommand.Parameters.AddWithValue("@sTrangThai", cb_trangthai.Text);
                            sqlCommand.Parameters.AddWithValue("@fTongTienMuon", tb_tongtienmuon.Text);
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
                            MessageBox.Show("Mã mượn " + iMaMuon + " đã tồn tại!");
                        }
                    }
                }
            }
        }


        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tb_mamuon.Text == null)
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Update_MuonSach", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@iMaMuon", tb_mamuon.Text);
                        sqlCommand.Parameters.AddWithValue("@iMaNV", cb_manv.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@iMaSV", cb_masv.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@dNgayMuon", dtp_ngaymuon.Text);
                        sqlCommand.Parameters.AddWithValue("@sTrangThai", cb_trangthai.Text);
                        sqlCommand.Parameters.AddWithValue("@fTongTienMuon", tb_tongtienmuon.Text);

                        int row = sqlCommand.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            tb_mamuon.Text = "";
                            cb_manv.Text = "";
                            cb_masv.Text = "";
                            dtp_ngaymuon.Text = "";
                            cb_trangthai.Text = "";
                            tb_tongtienmuon.Text = "";
                            LoadtoDataGridView();
                        }
                    }
                    sqlConnection.Close();
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn xóa chứ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Xóa bản ghi trong bảng tblChiTietMuonSach
                            using (SqlCommand commandChiTiet = new SqlCommand(
                                "DELETE FROM tblChiTietMuonSach WHERE iMaMuon = @iMaMuon", con, transaction))
                            {
                                commandChiTiet.CommandType = CommandType.Text;
                                commandChiTiet.Parameters.AddWithValue("@iMaMuon", tb_mamuon.Text);

                                int rowsAffectedChiTiet = commandChiTiet.ExecuteNonQuery();
                                // Kiểm tra số bản ghi bị ảnh hưởng bởi câu lệnh xóa
                                if (rowsAffectedChiTiet > 0)
                                {
                                    MessageBox.Show("Xóa bản ghi trong bảng chi tiết mượn sách thành công!");
                                }
                            }

                            // Xóa bản ghi trong bảng tblMuonSach
                            using (SqlCommand commandMuonSach = new SqlCommand(
                                "DELETE FROM tblMuonSach WHERE iMaMuon = @iMaMuon", con, transaction))
                            {
                                commandMuonSach.CommandType = CommandType.Text;
                                commandMuonSach.Parameters.AddWithValue("@iMaMuon", tb_mamuon.Text);

                                int rowsAffectedMuonSach = commandMuonSach.ExecuteNonQuery();
                                // Kiểm tra số bản ghi bị ảnh hưởng bởi câu lệnh xóa
                                if (rowsAffectedMuonSach > 0)
                                {
                                    MessageBox.Show("Xóa bản ghi trong bảng mượn sách thành công!");
                                }
                            }

                            // Hoàn thành transaction nếu không có lỗi
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Xảy ra lỗi, rollback transaction và xử lý lỗi
                            transaction.Rollback();
                            MessageBox.Show("Lỗi xóa bản ghi: " + ex.Message);
                        }
                    }
                }

                LoadtoDataGridView();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string filter = "iMaMuon IS NOT NULL";
            if (!string.IsNullOrEmpty(tb_mamuon.Text))
            {
                int mamuon = Convert.ToInt32(tb_mamuon.Text);
                filter += string.Format(" AND iMaMuon = {0}", mamuon);
            }
            else if (!string.IsNullOrEmpty(cb_masv.Text))
            {
                filter += string.Format(" AND sTenSV LIKE '%{0}%'", cb_manv.Text);
            }
            else if (!string.IsNullOrEmpty(cb_manv.Text))
            {
                filter += string.Format(" AND sTenNV LIKE '%{0}%'", cb_manv.Text);
            }
            else if (!string.IsNullOrEmpty(dtp_ngaymuon.Text))
            {
                DateTime ngayMuon = dtp_ngaymuon.Value.Date; // Lấy giá trị ngày của DateTimePicker
                filter += string.Format(" AND dNgayMuon = '{0}'", ngayMuon.ToString("yyyy-MM-dd")); // Format ngày thành chuỗi yyyy-MM-dd

            }
            else if (!string.IsNullOrEmpty(cb_trangthai.Text))
            {
                string trangThai = cb_trangthai.SelectedItem.ToString(); // Lấy giá trị đã chọn từ ComboBox
                filter += string.Format(" AND sTrangThai = '{0}'", trangThai);

            }
            else if (!string.IsNullOrEmpty(tb_tongtienmuon.Text))
            {
                float tongtienmuon = Convert.ToInt32(tb_tongtienmuon.Text);
                filter += string.Format(" AND fTongTienMuon = {0}", tongtienmuon);
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
            tb_mamuon.Text = "";
            cb_masv.Text = "";
            cb_manv.Text = "";
            cb_trangthai.Text = "";
            tb_tongtienmuon.Text = "";

            this.Focus();
            LoadtoDataGridView();
        }

        private void btn_inbc_Click(object sender, EventArgs e)
        {
            InBaoCaoMuonSach inBaoCao = new InBaoCaoMuonSach();
            inBaoCao.Show();
            inBaoCao.ShowBaoCao2("Select_BaoCaoMuonSach", "QLMS");

        }

        private void dgv_muonsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_muonsach.CurrentRow.Index;
            tb_mamuon.Text = dgv_muonsach.Rows[index].Cells["iMaMuon"].Value.ToString();
            cb_manv.Text = dgv_muonsach.Rows[index].Cells["sTenNV"].Value.ToString();
            cb_masv.Text = dgv_muonsach.Rows[index].Cells["sTenSV"].Value.ToString();
            dtp_ngaymuon.Text = dgv_muonsach.Rows[index].Cells["dNgayMuon"].Value.ToString();
            cb_trangthai.Text = dgv_muonsach.Rows[index].Cells["sTrangThai"].Value.ToString();
            tb_tongtienmuon.Text = dgv_muonsach.Rows[index].Cells["fTongTienMuon"].Value.ToString();
        }

        private void tb_mamuon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_mamuon.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_mamuon, "Mã mượn chưa được nhập");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_mamuon, null);
            }
        }

        private void tb_mamuon_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
            string value = tb_mamuon.Text;
            string numericValue = new string(value.Where(char.IsDigit).ToArray());
            if (value != numericValue)
            {
                errorProvider.SetError(tb_mamuon, "Vui lòng chỉ nhập số.");
            }
            else
            {
                errorProvider.Clear();
            }
            tb_mamuon.Text = numericValue;
        }

        private void cb_manv_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void tb_masv_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void tb_masv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_masv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cb_masv, "Mã sinh viên chưa được nhập");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_masv, null);
            }
        }

        private void tb_tongtienmuon_Validating(object sender, CancelEventArgs e)
        {
            string tongtien = tb_tongtienmuon.Text;
            if (string.IsNullOrEmpty(tongtien))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_tongtienmuon, "Hãy nhập tổng tiền mượn");
            }
            else
            {
                int num;
                bool isNum = int.TryParse(tongtien, out num);
                if (!isNum)
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_tongtienmuon, "Hãy nhập đúng tổng tiền");
                }
                else if (num < 0) // Kiểm tra giá trị âm
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_tongtienmuon, "Tổng tiền mượn không được âm");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(tb_tongtienmuon, null);
                }
            }
        }

        private void tb_tongtienmuon_TextChanged(object sender, EventArgs e)
        {
            string value = tb_tongtienmuon.Text;
            string numericValue = new string(value.Where(char.IsDigit).ToArray());
            if (value != numericValue)
            {
                errorProvider.SetError(tb_tongtienmuon, "Vui lòng chỉ nhập số.");
            }
            else
            {
                errorProvider.Clear();
            }
            tb_tongtienmuon.Text = numericValue;
        }
    }
}
