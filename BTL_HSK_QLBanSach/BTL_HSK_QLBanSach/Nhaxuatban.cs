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
    public partial class Nhaxuatban : Form
    {
        Main hamChung = new Main();
        public Nhaxuatban()
        {
            InitializeComponent();
        }
        private void hienbangNXB()
        {

            string sql = @"select * from V_Nhaxuatban";
            hamChung.hienDLDGV(sql, dgvNXB);
        }

        private void Nhaxuatban_Load(object sender, EventArgs e)
        {
            hienbangNXB();
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNXB.Text = dgvNXB.CurrentRow.Cells["Mã nhà xuất bản"].Value.ToString();
            txtTenNXB.Text = dgvNXB.CurrentRow.Cells["Tên nhà xuất bản"].Value.ToString();
            txtDiaChi.Text = dgvNXB.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            mtxtSDT.Text = dgvNXB.CurrentRow.Cells["Điện thoại"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (hamChung.KetnoiCSDL() == true)
            {
                try
                {
                    using (SqlDataAdapter adt = new SqlDataAdapter())
                    {
                        adt.SelectCommand = new SqlCommand(@"Select * from V_Nhaxuatban", hamChung.cnn);
                        DataTable dt = new DataTable("NhaXuatBan");
                        adt.Fill(dt);
                        DataRow newR = dt.NewRow();
                        newR["Mã nhà xuất bản"] = txtMaNXB.Text.ToString();
                        newR["Tên nhà xuất bản"] = txtTenNXB.Text.ToString();
                        newR["Địa chỉ"] = txtDiaChi.Text;
                        newR["Điện thoại"] = mtxtSDT.Text;
                        dt.Rows.Add(newR);
                        SqlCommand cmd = new SqlCommand(@"exec pr_ThemNXB @manxb, @tennxb, @diachi, @SDT", hamChung.cnn);
                        cmd.Parameters.Add("@manxb", SqlDbType.VarChar, 20, "Mã nhà xuất bản");
                        cmd.Parameters.Add("@tennxb", SqlDbType.NVarChar, 50, "Tên nhà xuất bản");
                        cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 100, "Địa chỉ");
                        cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 10, "Điện thoại");

                        //cmd.ExecuteNonQuery();
                        adt.InsertCommand = cmd;
                        adt.Update(dt);
                        MessageBox.Show("Thêm thành công một nhà xuất bản", "Thông báo");
                        hienbangNXB();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm nhà xuất bản." + ex, "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (hamChung.KetnoiCSDL() == true)
            {
                using (SqlCommand cmd = new SqlCommand("Delete from tblNhaXuatBan where sMaNXB='" + txtMaNXB.Text + "'", hamChung.cnn))
                {
                    cmd.CommandText = "Delete from tblNhaXuatBan where sMaNXB= '" + txtMaNXB.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    int j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Xoá dữ liệu thanh công", "Thông báo");
                        hienbangNXB();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi xoá dữ liệu.", "Thông báo");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (hamChung.KetnoiCSDL() == true)
            {
                try
                {
                    string manxb = txtMaNXB.Text;
                    string diachi = txtDiaChi.Text;
                    string tenNXB = txtTenNXB.Text;
                    string sdt = mtxtSDT.Text;
                    string upd = @"exec Pr_SuaNXB '" + manxb + "', N'" + tenNXB + "', N'" + diachi + "', '" + sdt + "'";
                    SqlCommand cmd = new SqlCommand(upd, hamChung.cnn);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa nhà xuất bản thành công", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    hienbangNXB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công" + ex, "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text != "" && txtTenNXB.Text == "" && txtDiaChi.Text == "" && mtxtSDT.Text == "")
            {
                hamChung.hienDLDGV("exec Pr_TimNXBtheoma '" + txtMaNXB.Text + "'", dgvNXB);
            }
            if (txtMaNXB.Text == "" && txtTenNXB.Text != "" && txtDiaChi.Text == "" && mtxtSDT.Text == "")
            {
                hamChung.hienDLDGV("exec Pr_TimNXBtheoten N'" + txtTenNXB.Text + "'", dgvNXB);
            }
            if (txtMaNXB.Text == "" && txtTenNXB.Text == "" && txtDiaChi.Text != "" && mtxtSDT.Text == "")
            {
                hamChung.hienDLDGV("exec Pr_TimNXBtheoDC N'" + txtDiaChi.Text + "'", dgvNXB);

            }
        }
    }
}