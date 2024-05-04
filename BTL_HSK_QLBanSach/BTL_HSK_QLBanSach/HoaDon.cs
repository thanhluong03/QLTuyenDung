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
    public partial class HoaDon : Form
    {
        Main dch = new Main();
        public HoaDon()
        {
            InitializeComponent();
        }


        private void HoaDon_Load(object sender, EventArgs e)
        {
            load();
            hienDSNV();
            hienDSKH();
            cbkhachhang.Text = null;
            cbnhanvien.Text = null;
            //if(gb1 == "" && gb2 && gb3 )
       
        }

        private void load()
        {
            string hoadon = "V_laydulieu";
            dch.HienthiDulieutrenDatagridView(hoadon, dgrhoadon);
           // if(r)
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

             int sohd = int.Parse(txtsohd.Text);
             DateTime dt = DateTime.Now;
             DateTime ngay = Convert.ToDateTime(mtbngaylap.Text);
             mtbngaylap.Text = ngay.ToString("dd/MM/yyyy");
             if (dch.ktraKhoa("tblHoaDon", "iSoHD", sohd) == true)
             {
                 MessageBox.Show(String.Format("Số hóa đơn bị trùng!! \n Không thể thêm"),
                                  "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else if (ngay > dt)
             {
                 MessageBox.Show(String.Format("Kiểm tra lại ngày lập \n Ngày lập không được lớn hơn ngày hiện tại"),
                                  "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else
             {
                 string hoadon = "V_laydulieu";
                 if (dch.KetnoiCSDL() == false)
                     return;

                 string manv = cbnhanvien.Text;
                 string makh = cbkhachhang.Text;
                 DateTime ngaylap = Convert.ToDateTime(mtbngaylap.Text);
                 SqlCommand cmd = new SqlCommand("pr_themhd", dch.cnn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@sohd", sohd);
                 cmd.Parameters.AddWithValue("@tennv", manv);
                 cmd.Parameters.AddWithValue("@tenkh", makh);
                 cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
                 cmd.ExecuteNonQuery();

                 load();
                 MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
             }
         }

         private void btnsua_Click(object sender, EventArgs e)
         {
             int sohd = int.Parse(txtsohd.Text);
             DateTime dt = DateTime.Now;
             DateTime date = Convert.ToDateTime(dgrhoadon.CurrentRow.Cells["Ngày Lập"].Value);
             TimeSpan t = dt - date;
             double d = t.TotalDays;
             if (dch.ktraKhoa("tblHoaDon", "iSoHD", sohd) == false)
             {
                 MessageBox.Show(String.Format("Không tìm thấy số hóa đơn!! \n Không thể sửa"),
                                  "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else if (d <=3)
             {

                 string manv = cbnhanvien.Text;
                 string makh = cbkhachhang.Text;
                 DateTime ngaylap = Convert.ToDateTime(mtbngaylap.Text);
                 SqlCommand cmd = new SqlCommand("pr_suahd", dch.cnn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@sohd", sohd);
                 cmd.Parameters.AddWithValue("@tennv", manv);
                 cmd.Parameters.AddWithValue("@tenkh", makh);
                 cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
                 cmd.ExecuteNonQuery();
                 load();
                 MessageBox.Show("Sửa hóa đơn thành công", "Thông báo");
             }
             else
             {
                 MessageBox.Show(String.Format("Hóa đơn thanh toán đã quá 3 ngày!! \n Không thể sửa"),
                                  "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
         }

         private void btnxoa_Click(object sender, EventArgs e)
         {
             int hd = int.Parse(txtsohd.Text);
             DateTime dt = DateTime.Now;
                  DateTime date = Convert.ToDateTime(dgrhoadon.CurrentRow.Cells["Ngày Lập"].Value);
                  TimeSpan t = dt - date;
                  double d = t.TotalDays;
             if (dch.ktraKhoa("tblHoaDon", "iSoHD", hd) == false)
             {
                 MessageBox.Show(String.Format("Không tìm thấy số hóa đơn!! \n Không thể xóa"),
                                  "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else if (d<=3)
             {
                 string sohd = txtsohd.Text;
                 string xoadl = "pr_Xoahd";
                 if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa không!! \n Nếu xóa dữ liệu chi tiết hóa đơn sẽ mất"),
                                   "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                     dch.Xoadulieu(xoadl, "@sohd", sohd);
                 load();
                 MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
             }      
            else
             {
                 MessageBox.Show(String.Format("Hóa đơn thanh toán đã quá 3 ngày!! \n Không thể xóa"),
                               "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }

         }

         private void btnload_Click(object sender, EventArgs e)
         {
             txtsohd.Text = null;
             cbnhanvien.Text = null;
             cbkhachhang.Text = null;
             mtbngaylap.Text = null;
             txttongtien.Text = null;
             load();
         }

         private void btnthoat_Click(object sender, EventArgs e)
         {
             DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát khỏi chương trình ? ","Thông báo",  MessageBoxButtons.YesNo);
             if (result == DialogResult.Yes)
                 Close();
         }

         private void drgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             DateTime date = Convert.ToDateTime(dgrhoadon.CurrentRow.Cells["Ngày Lập"].Value);
             txtsohd.Text = dgrhoadon.CurrentRow.Cells["Số Hóa Đơn"].Value.ToString();
             cbnhanvien.Text = dgrhoadon.CurrentRow.Cells["Tên Nhân Viên"].Value.ToString();
             cbkhachhang.Text = dgrhoadon.CurrentRow.Cells["Tên Khách Hàng"].Value.ToString();
             mtbngaylap.Text = date.ToString("dd/MM/yyyy");
             txttongtien.Text = dgrhoadon.CurrentRow.Cells["Tổng tiền"].Value.ToString();
         }

         private void btnchitiet_Click(object sender, EventArgs e)
         {
             if ( txtsohd.Text == "" || mtbngaylap.Text == "")
             {
                 MessageBox.Show(String.Format(" Hãy nhập số hóa đơn và ngày lập"),
                                  "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtsohd.Focus();
                 mtbngaylap.Focus();
             }
             else
             {
                 ChiTietHD ch = new ChiTietHD(txtsohd.Text, mtbngaylap.Text, cbkhachhang.Text);
                 ch.Show();
             }
         }

         /*private void btntimkiem_Click(object sender, EventArgs e)
         {
             if (cbkhachhang.Text == "")
             {
                 MessageBox.Show(String.Format(" Bạn phải nhập mã khách hàng "),
                                  "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtmakh.Focus();
             }
             else
             {
                 string constr = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLSach;Integrated Security=True";
                 using (SqlConnection cnn = new SqlConnection(constr))
                 {
                     string makh = txtmakh.Text;
                     using (SqlCommand cmd = cnn.CreateCommand())
                     {
                         cmd.CommandType = CommandType.StoredProcedure;
                         cmd.CommandText = "pr_timkiem";
                         cmd.Parameters.AddWithValue("@makh", makh);
                         cnn.Open();
                         using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                         {
                             DataTable tb = new DataTable();
                             ad.Fill(tb);
                             dgrhoadon.DataSource = tb;

                         }
                         cnn.Close();
                     }
                 }
             }
         }*/
            private DataTable layDSnv()
        {
            string constr = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLSach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblNhanVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("nhanvien");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }

        }
        private void hienDSNV()
        {
            DataTable t = layDSnv();
            DataView v = new DataView(t);
            v.Sort = "sTenNV";
            cbnhanvien.DataSource = v;
            cbnhanvien.DisplayMember = "sTenNV";
            cbnhanvien.ValueMember = "sMaNV";
        }
        private DataTable layDSkh()
        {
            string constr = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLSach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblKhachHang", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("khachhang");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienDSKH()
        {
            DataTable t = layDSkh();
            DataView v = new DataView(t);
            v.Sort = "sTenKH";
            cbkhachhang.DataSource = v;
            cbkhachhang.DisplayMember = "sTenKH";
            cbkhachhang.ValueMember = "sMaKH";
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

        private void mtbngaylap_Validating(object sender, CancelEventArgs e)
        {
                try
                {
                    DateTime dt = DateTime.Now;
                    DateTime ngaylap = Convert.ToDateTime(mtbngaylap.Text);
                    mtbngaylap.Text = ngaylap.ToString("dd/MM/yyyy");
                    if (ngaylap < dt)
                    {
                        errorProvider1.SetError(mtbngaylap, "");
                    }
                    else
                    {
                        errorProvider1.SetError(mtbngaylap, "Ngày lập không được lớn hơn ngày hiện tại");
                        mtbngaylap.Focus();
                    }
                }
                catch
                {
                    errorProvider1.SetError(mtbngaylap, "Hãy nhập đúng ngày tháng");
                    mtbngaylap.Focus();
                }
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if(cbkhachhang.Text == "")
            {
                errorProvider1.SetError(cbkhachhang, "Bạn chưa nhập tên khách hàng");
                cbkhachhang.Focus();
            }
            else
            {
                errorProvider1.SetError(cbkhachhang, "");
                string sql = "pr_timkiemkh";
                string tenkh = cbkhachhang.Text;
                dch.Timkiemdl(sql, "@tenkh", tenkh, dgrhoadon);
            }
            
        }

        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChiTietHD ch = new ChiTietHD(txtsohd.Text, mtbngaylap.Text, cbkhachhang.Text);
            if (MessageBox.Show("Bạn có chắc đóng Hóa Đơn lại không?", "FormClosing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                ch.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void rdmuanhieu_CheckedChanged(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
