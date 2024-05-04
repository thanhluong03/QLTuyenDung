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

namespace BTL_HSK_QLBanSach
{
    public partial class ChiTietNhapHang : Form
    {
        Main hamChung = new Main();
        public ChiTietNhapHang(string soHS, string NgayNhap, string TenNhanVienLap, string NhaXuatBan)
        {
           InitializeComponent();
            txtSNH.Text = soHS;
            txtNgayLap.Text = NgayNhap;
            txtNguoiLap.Text = TenNhanVienLap;
            txtNXB.Text = NhaXuatBan;
        }

        private void ChiTietNhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc đóng Chi Tiết Nhập Hàng lại không?", "FormClosing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void hienDonNhapCT()
        {
            string sql = @"Select * from V_DNCT where[Số đơn nhập] =" + txtSNH.Text;
            hamChung.hienDLDGV(sql, dgvCTNhapHang);
        }

        private void ChiTietNhapHang_Load(object sender, EventArgs e)
        {
            hienDonNhapCT();
            hamChung.hienDLCCB("tblSach", "sMaSach", "sTenSach", ccbSachNhap);
            if ((DateTime.Today.DayOfYear - DateTime.Parse(txtNgayLap.Text).DayOfYear) <= 3)
            {
                btnThemCTDN.Enabled = true;
            }
        }

        private void dgvCTNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ccbSachNhap.Text = dgvCTNhapHang.CurrentRow.Cells["Tên sách"].Value.ToString();
            tbSLNhap.Text = dgvCTNhapHang.CurrentRow.Cells["Số lượng"].Value.ToString();
            tbGiaNhap.Text = dgvCTNhapHang.CurrentRow.Cells["Giá nhập"].Value.ToString();
            if ((DateTime.Today.DayOfYear - DateTime.Parse(txtNgayLap.Text).DayOfYear) <= 3)
            {
                btnSuaCTDN.Enabled = true;
                btnXoaCTDN.Enabled = true;
            }

        }

        private void btnThemCTDN_Click(object sender, EventArgs e)
        {
            if (hamChung.KetnoiCSDL() == true)
            {
                try
                {
                    using (SqlDataAdapter adt = new SqlDataAdapter())
                    {
                        adt.SelectCommand = new SqlCommand(@"Select * from V_DNCT where[Số đơn nhập] = " + txtSNH.Text, hamChung.cnn);
                        DataTable dt = new DataTable("DonNhap");
                        adt.Fill(dt);
                        DataRow newR = dt.NewRow();
                        newR["Số đơn nhập"] = txtSNH.Text.ToString();
                        newR["Tên sách"] = ccbSachNhap.Text;
                        newR["Số lượng"] = tbSLNhap.Text.ToString();
                        newR["Giá nhập"] = tbGiaNhap.Text.ToString();
                        dt.Rows.Add(newR);
                        SqlCommand cmd = new SqlCommand(@"exec sp_ThemDonNhapCT @iSoDN, @sTenSach, @fSoLuongNhap, @fGiaNhap", hamChung.cnn);
                        cmd.Parameters.Add("@iSoDN", SqlDbType.Int, 4, "Số đơn nhập");
                        cmd.Parameters.Add("@sTenSach", SqlDbType.NVarChar, 50, "Tên sách");
                        cmd.Parameters.Add("@fSoLuongNhap", SqlDbType.Float, 10, "Số lượng");
                        cmd.Parameters.Add("@fGiaNhap", SqlDbType.Float, 10, "Giá nhập");

                        //cmd.ExecuteNonQuery();
                        adt.InsertCommand = cmd;
                        adt.Update(dt);
                        MessageBox.Show("Thêm thành công một đơn nhập chi tiết", "Thông báo");
                        hienDonNhapCT();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm đơn nhập chi tiết." + ex, "Thông báo");
                }
            }
        }

        private void btnXoaCTDN_Click(object sender, EventArgs e)
        {
            int maXoa = Convert.ToInt32(txtSNH.Text);
            string sachXoa = ccbSachNhap.Text;
            if (hamChung.KetnoiCSDL() == true)
            {
                using (SqlCommand cmd = new SqlCommand(@"exec sp_XoaDonNhapCT " + maXoa + ", N'" + sachXoa + "' ", hamChung.cnn))
                {
                    cmd.CommandText = @"exec sp_XoaDonNhapCT " + maXoa + ", N'" + sachXoa + "' ";
                    cmd.CommandType = CommandType.Text;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Xoá dữ liệu thanh công", "Thông báo");
                        hienDonNhapCT();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi xoá dữ liệu.", "Thông báo");
                    }
                }
            }
        }

        private void btnSuaCTDN_Click(object sender, EventArgs e)
        {
            if (hamChung.KetnoiCSDL() == true)
            {
                try
                {
                    int soDN = Convert.ToInt32(txtSNH.Text);
                    string tenSach = ccbSachNhap.Text;
                    double soLuong = Convert.ToDouble(tbSLNhap.Text);
                    double giaNhap = Convert.ToDouble(tbGiaNhap.Text);
                    string upd = @"exec sp_SuaDNCT " + soDN + ", N'" + tenSach + "', " + soLuong + ", " + giaNhap + " ";
                    SqlCommand cmd = new SqlCommand(upd, hamChung.cnn);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa sách thành công", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    hienDonNhapCT();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công" + ex, "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTimCTDN_Click(object sender, EventArgs e)
        {
            if (ccbSachNhap.Text != "" && tbSLNhap.Text == "" && tbGiaNhap.Text == "")
            {
                hamChung.hienDLDGV("exec sp_TimCT_Ten " + txtSNH.Text + ", N'" + ccbSachNhap.Text + "'", dgvCTNhapHang);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            hienDonNhapCT();
        }
    }
}
