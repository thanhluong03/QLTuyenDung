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
    public partial class Sach : Form
    {
        Main dch = new Main();
        public Sach()
        {
            InitializeComponent();
        }
        private void Sach_Load(object sender, EventArgs e)
        {
            load();
            hienDSTheLoai();
            hienDSNhaXuatBan();
            cbtheloai.Text = null;
            cbnhaxuatban.Text = null;
        }
        private void load()
        {
            string hiensach = "V_HienSach";
            dch.HienthiDulieutrenDatagridView(hiensach, dgrSach);
        }

        private DataTable layDStheloai()
        {
            string constr = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLThuVien;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblTheLoai", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("theloai");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienDSTheLoai()
        {
            DataTable t = layDStheloai();
            DataView v = new DataView(t);
            v.Sort = "sTheLoai";
            cbtheloai.DataSource = v;
            cbtheloai.DisplayMember = "sTheLoai";
            cbtheloai.ValueMember = "iMaLoai";
        }
        private DataTable layDSnhaxuatban()
        {
            string constr = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLThuVien;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblNhaXuatBan", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("nxb");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienDSNhaXuatBan()
        {
            DataTable t = layDSnhaxuatban();
            DataView v = new DataView(t);
            v.Sort = "sTenNXB";
            cbnhaxuatban.DataSource = v;
            cbnhaxuatban.DisplayMember = "sTenNXB";
            cbnhaxuatban.ValueMember = "iMaNXB";
        }

        private void dgrSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasach.Text = dgrSach.CurrentRow.Cells["Mã Sách"].Value.ToString();
            txttensach.Text = dgrSach.CurrentRow.Cells["Tên Sách"].Value.ToString();
            cbtheloai.Text = dgrSach.CurrentRow.Cells["Thể Loại"].Value.ToString();
            cbnhaxuatban.Text = dgrSach.CurrentRow.Cells["Tên Nhà Xuất Bản"].Value.ToString();
            txttacgia.Text = dgrSach.CurrentRow.Cells["Tác Giả"].Value.ToString();
            txtsoluong.Text = dgrSach.CurrentRow.Cells["Số Lượng"].Value.ToString();
            txtgiasach.Text = dgrSach.CurrentRow.Cells["Giá Sách"].Value.ToString();
            txtgiamuon.Text = dgrSach.CurrentRow.Cells["Giá Mượn"].Value.ToString();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            int masach = int.Parse(txtmasach.Text);
            if (dch.ktraKhoa("tblSach", "iMaSach", masach) == true)
            {
                MessageBox.Show(String.Format("Đã tồn tại mã sách: {0} !! \n Không thể thêm", txtmasach.Text),
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dch.KetnoiCSDL() == false)
                    return;

                string tensach = txttensach.Text;
                string theloai = cbtheloai.Text;
                string nhaxuatban = cbnhaxuatban.Text;
                string tacgia = txttacgia.Text;
                string soluong = txtsoluong.Text;
                string giasach = txtgiasach.Text;
                string giamuon = txtgiamuon.Text;
                SqlCommand cmd = new SqlCommand("pr_ThemSach", dch.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masach", masach);
                cmd.Parameters.AddWithValue("@tensach", tensach);
                cmd.Parameters.AddWithValue("@theloai", theloai);
                cmd.Parameters.AddWithValue("@tacgia", tacgia);
                cmd.Parameters.AddWithValue("@tennxb", nhaxuatban);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@giasach", giasach);
                cmd.Parameters.AddWithValue("@giamuon", giamuon);
                cmd.ExecuteNonQuery();

                load();
                MessageBox.Show(String.Format("Thêm thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            int masach = int.Parse(txtmasach.Text);
            if (dch.ktraKhoa("tblSach", "iMaSach", masach) == true)
            {
                if (dch.KetnoiCSDL() == false)
                    return;

                string tensach = txttensach.Text;
                string theloai = cbtheloai.Text;
                string nhaxuatban = cbnhaxuatban.Text;
                string tacgia = txttacgia.Text;
                string soluong = txtsoluong.Text;
                string giasach = txtgiasach.Text;
                string giamuon = txtgiamuon.Text;
                SqlCommand cmd = new SqlCommand("pr_UpdateSach", dch.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masach", masach);
                cmd.Parameters.AddWithValue("@tensach", tensach);
                cmd.Parameters.AddWithValue("@theloai", theloai);
                cmd.Parameters.AddWithValue("@tacgia", tacgia);
                cmd.Parameters.AddWithValue("@tennxb", nhaxuatban);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@giasach", giasach);
                cmd.Parameters.AddWithValue("@giamuon", giamuon);
                cmd.ExecuteNonQuery();

                load();
                MessageBox.Show(String.Format("Update thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(String.Format("Không tồn tại mã sách: {0} !! \n Không thể sửa", txtmasach.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            int masach = int.Parse(txtmasach.Text);
            if (dch.ktraKhoa("tblSach", "iMaSach", masach) == false)
            {
                MessageBox.Show(String.Format("Không tồn tại mã sách: {0} !! \n Không thể xóa", txtmasach.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dch.KetnoiCSDL() == false)
                    return;
                if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa không!!"),
                                   "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
                try
                {
                    SqlCommand cmd = new SqlCommand("pr_DeleteSach", dch.cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@masach", masach);
                    cmd.ExecuteNonQuery();
                    load();
                    MessageBox.Show(string.Format("Xóa thành công !!"),
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(String.Format("Sách: '{0}'-- đang được mượn !! \n Không thể xóa", txttensach.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            string tennxb = cbnhaxuatban.Text;
            string tensach = txttensach.Text;
            string tentheloai = cbtheloai.Text;
            string tacgia = txttacgia.Text;
            string timtensach = "pr_TimKiemTenSach";
            string timtentacgia = "pr_TimKiemTacGia";
            string timtennhaxuatban = "pr_TimKiemNhaXuatBan";
            string timtheloai = "pr_TimKiemTheLoai";
            
            if (txtmasach.Text == "" && txttensach.Text != "" && cbtheloai.Text == "" && cbnhaxuatban.Text == "" && txttacgia.Text == "" && txtsoluong.Text == "" && txtgiasach.Text == "" && txtgiamuon.Text == "" )
            {
                dch.Timkiemdl(timtensach, "@tensach", tensach, dgrSach);
                //   txtmanxb.Clear();
            }
            if (txtmasach.Text == "" && txttensach.Text == "" && cbtheloai.Text != "" && cbnhaxuatban.Text == "" && txttacgia.Text == "" && txtsoluong.Text == "" && txtgiasach.Text == "" && txtgiamuon.Text == "")
            {
                dch.Timkiemdl(timtheloai, "@theloai", tentheloai, dgrSach);
                //txttennxb.Clear();
            }
            if (txtmasach.Text == "" && txttensach.Text == "" && cbtheloai.Text == "" && cbnhaxuatban.Text != "" && txttacgia.Text == "" && txtsoluong.Text == "" && txtgiasach.Text == "" && txtgiamuon.Text == "")
            {
                dch.Timkiemdl(timtennhaxuatban, "@nxb", tennxb, dgrSach);
                // txtdiachi.Clear();
            }
            if (txtmasach.Text == "" && txttensach.Text == "" && cbtheloai.Text == "" && cbnhaxuatban.Text == "" && txttacgia.Text != "" && txtsoluong.Text == "" && txtgiasach.Text == "" && txtgiamuon.Text == "")
            {
                dch.Timkiemdl(timtentacgia, "@tacgia", tacgia, dgrSach);
                //  txtsodt.Clear();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load();
            txtmasach.Clear();
            txttensach.Clear();
            txttacgia.Clear();
            txtsoluong.Clear();
            txtgiasach.Clear();
            txtgiamuon.Clear();
            cbnhaxuatban.Text = null;
            cbtheloai.Text = null;
        }

        private void txttensach_Validating(object sender, CancelEventArgs e)
        {
            if (txttensach.Text == dgrSach.CurrentRow.Cells["Tên Sách"].Value.ToString())
            {
                errorProvider1.SetError(txttensach, "Trùng tên sách!!");
                txttensach.Focus();
            }
            else
            {
                errorProvider1.SetError(txttensach, "");
            }
        }
    }
}
