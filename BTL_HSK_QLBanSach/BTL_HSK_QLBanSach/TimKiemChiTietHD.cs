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
    public partial class TimKiemChiTietHD : Form
    {
        Main dch = new Main();
        public TimKiemChiTietHD()
        {
            InitializeComponent();
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
            cbsach.DataSource = v;
            cbsach.DisplayMember = "sTenSACH";
            cbsach.ValueMember = "sMaSach";
        }
        private void TimKiemChiTietHD_Load(object sender, EventArgs e)
        {
            hienDSsach();
            AnDieukhien();
        }
        private void load()
        {
            string sql = "V_laychitiethd";
            dch.HienthiDulieutrenDatagridView(sql, dgrchitiethd);
        }

        private void timkiemsohd()
        {
            string sql = "pr_timkiemsocthd";
            string sohd = txtsohd.Text;
            dch.Timkiemdl(sql, "@sohd", sohd, dgrchitiethd);
        }
        private void timkiemtensach()
        {
            string sql = "pr_timkiemtensach";
            string tensach = cbsach.Text;
            dch.Timkiemdl(sql, "@tensach", tensach, dgrchitiethd);
        }
        private void AnDieukhien()
        {
            txtsohd.Visible = false;
            cbsach.Visible = false;
            txtsoluong.Visible = false;
        }
        private void rdsohd_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            txtsohd.Visible = true;
            txtsohd.Top = rdsohd.Top;
        }

        private void rdsach_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            cbsach.Visible = true;
            cbsach.Top = rdsach.Top;
        }

        private void rdsoluong_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            txtsoluong.Visible = true;
            txtsoluong.Top = rdsoluong.Top;
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
                    timkiemsohd();
                }
            }
            if (rdsach.Checked)
            {
                if (cbsach.Text == "")
                {
                    MessageBox.Show(String.Format("Hãy chọn sách "),
                                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbsach.Focus();
                }
                else
                {
                    timkiemtensach();
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
