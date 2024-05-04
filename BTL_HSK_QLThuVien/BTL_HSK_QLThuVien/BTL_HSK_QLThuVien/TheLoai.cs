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
    public partial class TheLoai : Form
    {
        Main dch = new Main();
        public TheLoai()
        {
            InitializeComponent();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load ()
        {
            string hienTL = "V_HienTL ";
            dch.HienthiDulieutrenDatagridView(hienTL, dgrTL);
        }
        private void dgrTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaTL.Text = dgrTL.CurrentRow.Cells["Mã Loại"].Value.ToString();
            txttenTL.Text = dgrTL.CurrentRow.Cells["Thể Loại"].Value.ToString();
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            int matl = int.Parse(txtmaTL.Text);
            if (dch.ktraKhoa("tblTheLoai", "iMaLoai", matl) == true)
            {
                MessageBox.Show(String.Format("Đã tồn tại mã loại: {0}!! \n Không thể thêm", txtmaTL.Text),
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dch.KetnoiCSDL() == false)
                    return;

                string tentl = txttenTL.Text;
                SqlCommand cmd = new SqlCommand("pr_ThemTL", dch.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maloai", matl);
                cmd.Parameters.AddWithValue("@theloai", tentl);
                cmd.ExecuteNonQuery();

                load();
                MessageBox.Show(String.Format("Thêm thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            int matl = int.Parse(txtmaTL.Text);
            if (dch.ktraKhoa("tblTheLoai", "iMaLoai", matl) == true)
            {
                if (dch.KetnoiCSDL() == false)
                    return;

                string tentl = txttenTL.Text;
                SqlCommand cmd = new SqlCommand("pr_UpdateTL", dch.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maloai", matl);
                cmd.Parameters.AddWithValue("@theloai", tentl);
                cmd.ExecuteNonQuery();

                load();
                MessageBox.Show(String.Format("Update thành công"),
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(String.Format("Không tồn tại mã loại: {0} !! \n Không thể sửa", txtmaTL.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            int maloai = int.Parse(txtmaTL.Text);
            if (dch.ktraKhoa("tblTheLoai", "iMaLoai", maloai) == false)
            {
                MessageBox.Show(String.Format("Không tồn tại mã loại: {0} !! \n Không thể xóa", txtmaTL.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string matl = txtmaTL.Text;
                if (dch.KetnoiCSDL() == false)
                    return;
                if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa không!!"),
                                   "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
                try
                {
                    SqlCommand cmd = new SqlCommand("pr_DeleteTL", dch.cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maloai", matl);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(string.Format("Xóa thành công !!"),
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(String.Format("Tồn tại sách của thể loại: {0}!! \n Không thể xóa",txttenTL.Text),
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                load();
            }
        }

        private void btnTimkiemTL_Click(object sender, EventArgs e)
        {
            string maloai = txtmaTL.Text;
            string theloai = txttenTL.Text;
            string timmatl = "pr_TimKiemMaTL";
            string timtheloai = "pr_TimKiemTheLoai";

            if (txtmaTL.Text != "" && txttenTL.Text == "" )
            {
                dch.Timkiemdl(timmatl, "@maloai", maloai, dgrTL);
            }
            if (txtmaTL.Text == "" && txttenTL.Text != "")
            {
                dch.Timkiemdl(timtheloai, "@theloai", theloai, dgrTL);
            }
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load();
            txtmaTL.Clear();
            txttenTL.Clear();
        }
    }
}
