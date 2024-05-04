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
    public partial class TimKiemHoaDon : Form
    {
        Main dch = new Main();
        public TimKiemHoaDon()
        {
            InitializeComponent();
        }

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
        private void TimKiemHoaDon_Load(object sender, EventArgs e)
        {
            hienDSKH();
            hienDSNV();
            AnDieukhien();
        }
        private void load()
        {
            string hoadon = "V_laydulieu";
            dch.HienthiDulieutrenDatagridView(hoadon, dgrhoadon);
        }
        private void timkiemSoHD ()
        {
            string sohd = txtsohd.Text;
            string sql = "pr_timkiemsohd";
            if (sohd != "")
            {
                dch.Timkiemdl(sql, "@sohd", sohd, dgrhoadon);
            }
            else
            {
                MessageBox.Show(String.Format("Hãy nhập Số Hóa Đơn"),
                                     "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsohd.Focus();
            }
        }

        private void timkiemTenNV()
        {
            string sql = "pr_timkiemnv";
            string tennv = cbnhanvien.Text;
            dch.Timkiemdl(sql, "@tennv", tennv, dgrhoadon);

        }
        private void timkiemTenKH()
        {
            string sql = "pr_timkiemkh";
            string tenkh = cbkhachhang.Text;
            dch.Timkiemdl(sql, "@tenkh", tenkh, dgrhoadon);

        }
        private void timkiemNgaylap()
        {
            string ngaylap = txtngaylap.Text;
            string sql = "pr_timkiemngaylap";
            if (ngaylap != "")
            {
                dch.Timkiemdl(sql, "@ngaylap", ngaylap, dgrhoadon);
            }
            else
            {
                MessageBox.Show(String.Format("Hãy nhập Ngày Lập"),
                                     "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngaylap.Focus();
            }
        }
        private void AnDieukhien()
        {
            txtsohd.Visible = false;
            txtngaylap.Visible = false;
            cbkhachhang.Visible = false;
            cbnhanvien.Visible = false;
        }

        private void rdsohd_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            txtsohd.Visible = true;
            txtsohd.Top = rdsohd.Top;
        }

        private void rdnhanvien_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            cbnhanvien.Visible = true;
            cbnhanvien.Top = rdnhanvien.Top;
        }

        private void rdkhachhang_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            cbkhachhang.Visible = true;
            cbkhachhang.Top = rdkhachhang.Top;
        }

        private void rdngaylap_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            txtngaylap.Visible = true;
            txtngaylap.Top = rdngaylap.Top;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (rdhienthitoanbo.Checked)
            {
                load();
            }
            if (rdsohd.Checked)
            {
                if (txtsohd.Text == "")
                {
                    MessageBox.Show(String.Format("Hãy điền số hóa đơn "),
                                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsohd.Focus();
                }
                else
                {
                    timkiemSoHD();
                }
            }
            if(rdnhanvien.Checked)
            {
                if (cbkhachhang.Text == "")
                {
                    MessageBox.Show(String.Format("Hãy chọn nhân viên"),
                                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbnhanvien.Focus();
                }
                else
                {
                    timkiemTenNV();
                }
            }
            if(rdkhachhang.Checked)
            {
                if (cbkhachhang.Text == "")
                {
                    MessageBox.Show(String.Format("Hãy chọn khách hàng"),
                                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbkhachhang.Focus();
                }
                else
                {
                    timkiemTenKH();
                }
               
            }
            if(rdngaylap.Checked)
            {
                if (txtngaylap.Text == "")
                {
                    MessageBox.Show(String.Format("Hãy nhập Ngày Lập"),
                                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtngaylap.Focus();
                }
                else
                {
                    timkiemNgaylap();
                }

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát khỏi chương trình ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
