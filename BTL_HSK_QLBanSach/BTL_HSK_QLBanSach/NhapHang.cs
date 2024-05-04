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
//using DateCalculator;

namespace BTL_HSK_QLBanSach
{
    public partial class NhapHang : Form
    {
        Main hamChung = new Main();
        public NhapHang()
        {
            InitializeComponent();
        }

        private void NhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc đóng Nhập Hàng lại không?", "FormClosing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void hienbangNhapHang()
        {
            Main hamChung = new Main();
            string sql = @"select * from V_DonNhap";
            hamChung.hienDLDGV(sql, dgvNhapHang);
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSoDN.Text = dgvNhapHang.CurrentRow.Cells["Số đơn nhập"].Value.ToString();
            tbNgayNhap.Text = dgvNhapHang.CurrentRow.Cells["Ngày nhập"].Value.ToString();
            ccbNhanVien.Text = dgvNhapHang.CurrentRow.Cells["Tên người lập"].Value.ToString();
            ccbNXB.Text = dgvNhapHang.CurrentRow.Cells["Nhà xuất bản"].Value.ToString();
           /* btnSuaDN.Enabled = true;
            btnXoaDN.Enabled = true;
            btnXemCTDN.Enabled = true;*/
        }

        private DataTable dlNhanVien()
        {
            String strSQL = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLSach;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(strSQL))
            {
                sqlCon.Open();
                using (SqlCommand sqlCmd = new SqlCommand("Select * from tblNhanVien", sqlCon))
                {
                    using (SqlDataAdapter adt = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable dt = new DataTable("tblDonNhap");
                        adt.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        private void hienNV()
        {
            DataTable tb = dlNhanVien();
            DataView dv = new DataView(tb);
            dv.Sort = "sTenNV";
            ccbNhanVien.DataSource = dv;
            ccbNhanVien.DisplayMember = "sTenNV";
            ccbNhanVien.ValueMember = "sMaNV";
        }

        private DataTable dlNSX()
        {
            String strSQL = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLSach;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(strSQL))
            {
                sqlCon.Open();
                using (SqlCommand sqlCmd = new SqlCommand("select * from tblNhaXuatBan", sqlCon))
                {
                    using (SqlDataAdapter adt = new SqlDataAdapter(sqlCmd))
                    {
                        DataTable tb = new DataTable("tblNXB");
                        adt.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienNXB()
        {
            DataTable tb = dlNSX();
            DataView dv = new DataView(tb);
            ccbNXB.DataSource = dv;
            ccbNXB.DisplayMember = "sTenNXB";
            ccbNXB.ValueMember = "sMaNXB";
        }

        private void btnXemCTDN_Click(object sender, EventArgs e)
        {
            ChiTietNhapHang ctnh = new ChiTietNhapHang(tbSoDN.Text, tbNgayNhap.Text, ccbNhanVien.Text, ccbNXB.Text);
            ctnh.Dock = DockStyle.Fill;
            ctnh.Show();
        }

        private void btnThemDN_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(tbNgayNhap.Text) > DateTime.Today)
            {
                MessageBox.Show("Kiểm tra lại ngày tháng", "Thông báo");
            }
            else
            {
                if (hamChung.KetnoiCSDL() == true)
                {
                    try
                    {
                        using (SqlDataAdapter adt = new SqlDataAdapter())
                        {
                            adt.SelectCommand = new SqlCommand(@"Select * from V_DonNhap", hamChung.cnn);
                            DataTable dt = new DataTable("DonNhap");
                            adt.Fill(dt);
                            DataRow newR = dt.NewRow();
                            newR["Số đơn nhập"] = tbSoDN.Text.ToString();
                            newR["Ngày nhập"] = tbNgayNhap.Text.ToString();
                            newR["Tên người lập"] = ccbNhanVien.Text;
                            newR["Nhà xuất bản"] = ccbNXB.Text;
                            dt.Rows.Add(newR);
                            SqlCommand cmd = new SqlCommand(@"exec sp_ThemDonNhap @iSoDN, @dNgayNhap, @sTenNV, @sTenNXB", hamChung.cnn);
                            cmd.Parameters.Add("@iSoDN", SqlDbType.Int, 10, "Số đơn nhập");
                            cmd.Parameters.Add("@dNgayNhap", SqlDbType.Date, 12, "Ngày nhập");
                            cmd.Parameters.Add("@sTenNV", SqlDbType.NVarChar, 50, "Tên người lập");
                            cmd.Parameters.Add("@sTenNXB", SqlDbType.NVarChar, 50, "Nhà xuất bản");

                            //cmd.ExecuteNonQuery();
                            adt.InsertCommand = cmd;
                            adt.Update(dt);
                            MessageBox.Show("Thêm thành công một đơn nhập", "Thông báo");
                            hienbangNhapHang();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm đơn nhập." + ex, "Thông báo");
                    }
                }
            }

        }

        private void tbSoDN_Validating(object sender, CancelEventArgs e)
        {
            if (tbSoDN.Text != "")
            {
                int soHd = int.Parse(tbSoDN.Text);
                if (soHd < 0)
                    errLoi.SetError(tbSoDN, "Lỗi nhập số đơn nhập");
                else
                    errLoi.SetError(tbSoDN, "");
            }
        }

        private void tbNgayNhap_Validating(object sender, CancelEventArgs e)
        {
            if (tbNgayNhap.Text != "")
            {
                try
                {
                    DateTime ngay;
                    ngay = DateTime.Parse(tbNgayNhap.Text);
                    if (ngay > DateTime.Today)
                        errLoi.SetError(tbNgayNhap, "Ngày này chưa đến");
                }
                catch { errLoi.SetError(tbNgayNhap, ""); }
            }
        }

        private void btnXoaDN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nếu bạn xoá đơn nhập này thì toàn bộ đơn nhập chi tiết sẽ mất. Bạn có chắc chắn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int maXoa = Convert.ToInt32(tbSoDN.Text);
                if (hamChung.KetnoiCSDL() == true)
                {
                    using (SqlCommand cmd1 = new SqlCommand("Delete from tblChiTiet_HD_NhapSach where iSoDN=" + maXoa, hamChung.cnn))
                    {
                        cmd1.CommandText = "Delete from tblChiTiet_HD_NhapSach where iSoDN=" + maXoa;
                        cmd1.CommandType = CommandType.Text;
                        int i = cmd1.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Lỗi xoá dữ liệu.", "Thông báo");
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("Delete from tblDonNhap where iSoDN=" + maXoa, hamChung.cnn))
                            {
                                cmd.CommandText = "Delete from tblDonNhap where iSoDN=" + maXoa;
                                cmd.CommandType = CommandType.Text;
                                int j = cmd.ExecuteNonQuery();
                                if (j > 0)
                                {
                                    MessageBox.Show("Xoá dữ liệu thanh công", "Thông báo");
                                    hienbangNhapHang();
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi xoá dữ liệu.", "Thông báo");
                                }
                            }
                        }
                    }
                }
            }

        }

        private void btnSuaDN_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(tbNgayNhap.Text) > DateTime.Today || (DateTime.Today.DayOfYear - DateTime.Parse(tbNgayNhap.Text).DayOfYear) > 3)
                MessageBox.Show("Kiểm tra lại ngày nhập hoặc đã quá 3 ngày nên không thể sửa đơn nhập được nữa", "Thông báo");
            else
            {
                if (hamChung.KetnoiCSDL() == true)
                {
                    try
                    {
                        int soDN = Convert.ToInt32(tbSoDN.Text);
                        DateTime ngayNhap = DateTime.Parse(tbNgayNhap.Text);
                        string tenNV = ccbNhanVien.Text;
                        string tenNXB = ccbNXB.Text;
                        string upd = @"exec sp_SuaDonNhap " + soDN + ", '" + ngayNhap.Year + "/" + ngayNhap.Month + "/" + ngayNhap.Day + "', N'" + tenNV + "', N'" + tenNXB + "' ";
                        SqlCommand cmd = new SqlCommand(upd, hamChung.cnn);

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa sách thành công", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        hienbangNhapHang();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa không thành công" + ex, "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnTimDN_Click(object sender, EventArgs e)
        {
            if (tbSoDN.Text != "" && ccbNXB.Text == "" && ccbNhanVien.Text == "")
            {
                hamChung.hienDLDGV("exec sp_TimDN_So " + tbSoDN.Text, dgvNhapHang);
            }
            if (tbSoDN.Text == "" && ccbNXB.Text != "" && ccbNhanVien.Text == "")
            {
                hamChung.hienDLDGV("exec sp_TimDN_NXB N'" + ccbNXB.Text + "'", dgvNhapHang);
            }
            if (tbSoDN.Text == "" && ccbNXB.Text == "" && ccbNhanVien.Text != "")
            {
                hamChung.hienDLDGV("exec sp_TimDN_Nguoi N'" + ccbNhanVien.Text + "'", dgvNhapHang);
            }
            if (tbSoDN.Text == "" && ccbNXB.Text != "" && ccbNhanVien.Text != "")
            {
                hamChung.hienDLDGV("exec sp_TimDN_NguoivaNXB N'" + ccbNhanVien.Text + "', N'" + ccbNXB.Text + "'", dgvNhapHang);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            hienbangNhapHang();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            hienbangNhapHang();
            hienNV();
            hienNXB();
        }
    }
}
