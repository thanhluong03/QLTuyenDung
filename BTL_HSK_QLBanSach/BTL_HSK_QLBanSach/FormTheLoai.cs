using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_QLBanSach
{
    public partial class FormTheLoai : Form
    {
        public FormTheLoai()
        {
            InitializeComponent();
        }
        Main dch = new Main();
        private void FormTheLoai_Load(object sender, EventArgs e)
        {
            HienDuLieuTheLoai();
        }
        private void HienDuLieuTheLoai()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select sMaLoai[Mã loại]");
            query.Append(",sTheLoai[Thể loại]");
            query.Append(" from tblTheLoai");
            dt = dch.execQuery(query.ToString());
            dgvTheLoai.DataSource = dt;
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId < 0)
            {
                rowId = 0;
            }

            if (rowId == dgvTheLoai.Rows.Count - 1)
            {
                rowId -= 1;
            }

            DataGridViewRow row = dgvTheLoai.Rows[rowId];
            txtMaTheLoai.Text = row.Cells[0].Value.ToString();
            txtTheLoai.Text = row.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaTheLoai, "");
            errLoi.SetError(txtTheLoai, "");

            StringBuilder ktra = new StringBuilder("select * from tblTheLoai where sMaLoai='" + txtMaTheLoai.Text + "'");
            DataTable dt = new DataTable();
            dt = dch.execQuery(ktra.ToString());
            if (dt.Rows.Count > 0)
            {
                errLoi.SetError(txtMaTheLoai, "Mã thể loại bị trùng");
                return;
            }

            if (txtMaTheLoai.Text == "")
            {
                errLoi.SetError(txtMaTheLoai, "Bạn chưa có điền mã thể loại");
                return;
            }

            if (txtTheLoai.Text == "")
            {
                errLoi.SetError(txtTheLoai, "Thể loại không được để trống");
                return;
            }

            StringBuilder query = new StringBuilder("exec Them_Du_Lieu_The_Loai");
            query.Append(" @MaLoai= '" + txtMaTheLoai.Text + "'");
            query.Append(",@TheLoai=N'" + txtTheLoai.Text + "'");
            int kq = dch.execNonQuery(query.ToString());
            if (kq > 0)
            {
                HienDuLieuTheLoai();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("exec Sua_Du_Lieu_The_Loai");
            query.Append(" @MaLoai= '" + txtMaTheLoai.Text + "'");
            query.Append(",@TheLoai=N'" + txtTheLoai.Text + "'");
            int kq = dch.execNonQuery(query.ToString());
            if (kq > 0)
            {
                HienDuLieuTheLoai();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("exec Xoa_Du_Lieu_The_Loai");
            query.Append(" @MaLoai= '" + txtMaTheLoai.Text + "'");
            int kq = dch.execNonQuery(query.ToString());
            if (kq > 0)
            {
                HienDuLieuTheLoai();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Không xoá được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
