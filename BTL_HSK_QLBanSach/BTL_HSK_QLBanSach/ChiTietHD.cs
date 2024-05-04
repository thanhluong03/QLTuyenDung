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
namespace BTL_HSK_QLBanSach
{
    public partial class ChiTietHD : Form
    {
        Main dch = new Main();
        public ChiTietHD(string sohoadon, string ngaylap, string khachhang)
        {
            InitializeComponent();
            txtsohd.Text = sohoadon;
            txtkhachhang.Text = khachhang;
            mtbngaylap.Text = ngaylap;
            /*string constr = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLSach;Integrated Security=True";
            string sql = "select *from tblCHiTietHD where iSoHD = " + chitiet;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgrchitiethd.DataSource = tb;
                    }
                }
            }*/
            string sql = "pr_timkiemsocthd";
            dch.Timkiemdl(sql, "@sohd", sohoadon, dgrchitiethd);
        }
        private void load( string chitiet)
        {
             txtsohd.Text = chitiet;
            string sql = "pr_timkiemsocthd";
            dch.Timkiemdl(sql, "@sohd", chitiet, dgrchitiethd);
        }
        private DataTable layDSsach()
        {
            string constr = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLSach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblSach", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("sach");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }

        }
        private void hienDSsach()
        {
            DataTable t = layDSsach();
            DataView v = new DataView(t);
            v.Sort = "sTenSach";
            cbtensach.DataSource = v;
            cbtensach.DisplayMember = "sTenSach";
            cbtensach.ValueMember = "sMaSach";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime date = Convert.ToDateTime(mtbngaylap.Text);
            TimeSpan t = dt - date;
            double d = t.TotalDays;
            if (d >= 3)
            {
                MessageBox.Show(String.Format("Hóa đơn thanh toán đã quá 3 ngày!! \n Không thể thêm"),
                                 "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (dch.KetnoiCSDL() == false)
                        return;
                    string chitiet = txtsohd.Text;
                    string sql = "V_laychitiethd";
                    int sohd = int.Parse(txtsohd.Text);
                    string tensach = cbtensach.Text;
                    int soluong = Convert.ToInt32(txtsoluong.Text);
                    double dongia = Convert.ToDouble(txtdongia.Text);
                    SqlCommand cmd = new SqlCommand("pr_themchitiethd", dch.cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sohd", sohd);
                    cmd.Parameters.AddWithValue("@tensach", tensach);
                    cmd.Parameters.AddWithValue("@soluong", soluong);
                    cmd.Parameters.AddWithValue("@dongia", dongia);
                    cmd.ExecuteNonQuery();
                    load(chitiet);
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Lỗi thêm dữ liệu", "Thông báo");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime date = Convert.ToDateTime(mtbngaylap.Text);
            TimeSpan t = dt - date;
            double d = t.TotalDays;
            if (d >= 3)
            {
                MessageBox.Show(String.Format("Hóa đơn thanh toán đã quá 3 ngày!! \n Không thể sửa"),
                                 "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (dch.KetnoiCSDL() == false)
                        return;
                    string chitiet = txtsohd.Text;
                    int sohd = int.Parse(txtsohd.Text);
                    string tensach = cbtensach.Text;
                    int soluong = Convert.ToInt32(txtsoluong.Text);
                    double dongia = Convert.ToDouble(txtdongia.Text);
                    SqlCommand cmd = new SqlCommand("pr_suachitiethd", dch.cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sohd", sohd);
                    cmd.Parameters.AddWithValue("@tensach", tensach);
                    cmd.Parameters.AddWithValue("@soluong", soluong);
                    cmd.Parameters.AddWithValue("@dongia", dongia);
                    cmd.ExecuteNonQuery();
                    load(chitiet);
                    MessageBox.Show("Sửa hóa đơn thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Lỗi sửa dữ liệu", "Thông báo");
                }
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime date = Convert.ToDateTime(mtbngaylap.Text);
            TimeSpan t = dt - date;
            double d = t.TotalDays;
            if (d >= 3)
            {
                MessageBox.Show(String.Format("Hóa đơn thanh toán đã quá 3 ngày!! \n Không thể thêm"),
                                 "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string chitiet = txtsohd.Text;
                    string sohd = txtsohd.Text;
                    string tensach = cbtensach.Text;
                    string xoadl = "pr_Xoachitiethd";
                    if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa không!!"),
                                    "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        dch.Xoadulieu2dk(xoadl, "@sohd", sohd, "@tensach", tensach);
                    load(chitiet);
                    MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo");
                }
            }
         
        }
        private void drgChitiethd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsohd.Text = dgrchitiethd.CurrentRow.Cells["Số Hóa Đơn"].Value.ToString();
            cbtensach.Text = dgrchitiethd.CurrentRow.Cells["Tên Sách"].Value.ToString();
            txtsoluong.Text = dgrchitiethd.CurrentRow.Cells["Số Lượng"].Value.ToString();
            txtdongia.Text = dgrchitiethd.CurrentRow.Cells["Đơn Giá"].Value.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát khỏi chương trình ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            string chitiet = txtsohd.Text;
                txtsohd.Text = null;
                cbtensach.Text = null;
                txtsoluong.Text = null;
                txtdongia.Text = null;
                mtbngaylap.Text = null;
            load(chitiet);
        }

        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            hienDSsach();
            cbtensach.Text = null;
        }

        private void txtsohd_Validating(object sender, CancelEventArgs e)
        {
            if (txtsohd.Text == "")
            {
                errorProvider1.SetError(txtsohd, "Bạn phải nhập số hóa đơn");
                txtsohd.Focus();
            }
            else
            {
                try
                {
                    int sohd = int.Parse(txtsohd.Text);
                    errorProvider1.SetError(txtsohd, "");
                }
                catch
                {
                    errorProvider1.SetError(txtsohd, "Mã phải là số");
                    txtsohd.Focus();
                }
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
                if (cbtensach.Text == "")
                {
                    errorProvider1.SetError(cbtensach, "Bạn phải nhập số hóa đơn");
                    cbtensach.Focus();
                }
                else
                {
                    errorProvider1.SetError(cbtensach, "");
                    string sql = "pr_timkiemtensach";
                    string tensach = cbtensach.Text;
                    string sohd = txtsohd.Text;
                    dch.Timkiemdl2dk(sql, "@sohd", sohd, "@tensach", tensach, dgrchitiethd);
                }
        }
    }
}
