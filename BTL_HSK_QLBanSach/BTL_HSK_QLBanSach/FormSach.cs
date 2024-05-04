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
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
        }
        Main dch = new Main();
         private string TheLoai;
        private string NhaXuatban;
        private void FormSach_Load(object sender, EventArgs e)
        {
            HienDuLieuSach();
            ChonTheLoai();
            ChonNhaXuatBan();
        }
        private void HienDuLieuSach()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select sMaSach[Mã sách]");
            query.Append(",sTenNXB[Nhà xuất bản]");
            query.Append(",sTheLoai[Thể loại]");
            query.Append(",sTenSach[Tên sách]");
            query.Append(",sTacGia[Tác giả]");
            query.Append(",fDonGia[Đơn giá]");
            query.Append(",iSoLuong[Số lượng]");
            query.Append(" from tblSach, tblTheLoai, tblNhaXuatBan");
            query.Append(" where tblNhaXuatBan.sMaNXB=tblSach.sMaNXB and tblSach.sMaLoai=tblTheLoai.sMaLoai");
            dt = dch.execQuery(query.ToString());
            dgvSach.DataSource = dt;
        }

        private void ChonTheLoai()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select * from tblTheLoai");
            dt = dch.execQuery(query.ToString());
            cmbTheLoai.DisplayMember = "sTheLoai";
            cmbTheLoai.ValueMember = "sMaLoai";
            cmbTheLoai.DataSource = dt;
        }

        private void ChonNhaXuatBan()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select * from tblNhaXuatBan");
            dt = dch.execQuery(query.ToString());
            cmbNhaXuatBan.DisplayMember = "sTenNXB";
            cmbNhaXuatBan.ValueMember = "sMaNXB";
            cmbNhaXuatBan.DataSource = dt;
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId < 0)
            {
                rowId = 0;
            }

            if (rowId == dgvSach.Rows.Count - 1)
            {
                rowId -= 1;
            }

            DataGridViewRow row = dgvSach.Rows[rowId];
            txtMaSach.Text = row.Cells[0].Value.ToString();
            cmbNhaXuatBan.Text = row.Cells[1].Value.ToString();
            cmbTheLoai.Text = row.Cells[2].Value.ToString();
            txtTenSach.Text = row.Cells[3].Value.ToString();
            txtTacGia.Text = row.Cells[4].Value.ToString();
            nmrDonGia.Value =Convert.ToInt32(row.Cells[5].Value);
            nmrSoLuong.Value = (int)row.Cells[6].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //KiemTraTrungLap();

            errLoi.SetError(txtMaSach, "");
            errLoi.SetError(txtTacGia, "");
            errLoi.SetError(txtTenSach, "");

            StringBuilder ktra = new StringBuilder("select * from tblSach where sMaSach like '" + txtMaSach.Text + "'");
            DataTable dt = new DataTable();
            dt = dch.execQuery(ktra.ToString());
            if (dt.Rows.Count > 0)
            {
                errLoi.SetError(txtMaSach, "Mã sách đã tồn tại");
                return;
            }

            if (txtMaSach.Text == "")
            {
                errLoi.SetError(txtMaSach, "Bạn chưa nhập mã sách");
                return;
            }

            if (txtTacGia.Text == "")
            {
                errLoi.SetError(txtTacGia, "Bạn chưa nhập tên tác giả");
                return;
            }

            if (txtTenSach.Text == "")
            {
                errLoi.SetError(txtTenSach, "Bạn chưa nhập tên sách");
                return;
            }

            StringBuilder query = new StringBuilder("exec Them_Du_Lieu_Sach");
            query.Append(" @MaSach= '" + txtMaSach.Text + "'");
            query.Append(",@TenSach= N'" + txtTenSach.Text + "'");
            query.Append(",@MaLoai= " + TheLoai);
            query.Append(",@TacGia= N'" + txtTacGia.Text + "'");
            query.Append(",@DonGia= " + nmrDonGia.Value);
            query.Append(",@MaNXB= " + NhaXuatban);
            query.Append(",@SoLuong= " + nmrSoLuong.Value);
            int kq = dch.execNonQuery(query.ToString());
            if (kq > 0)
            {
                HienDuLieuSach();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaSach, "");
            errLoi.SetError(txtTacGia, "");
            errLoi.SetError(txtTenSach, "");

            if (txtMaSach.Text == "")
            {
                errLoi.SetError(txtMaSach, "Bạn chư nhập mã sách");
            }

            if (txtTacGia.Text == "")
            {
                errLoi.SetError(txtTacGia, "Bạn chưa nhập tên tác giả");
            }

            if (txtTenSach.Text == "")
            {
                errLoi.SetError(txtTenSach, "Bạn chưa nhập tên sách");
            }

            StringBuilder query = new StringBuilder("exec Sua_Du_Lieu_Sach");
            query.Append(" @MaSach= '" + txtMaSach.Text + "'");
            query.Append(",@TenSach= N'" + txtTenSach.Text + "'");
            query.Append(",@MaLoai= " + TheLoai);
            query.Append(",@TacGia= N'" + txtTacGia.Text + "'");
            query.Append(",@DonGia= " + nmrDonGia.Value);
            query.Append(",@MaNXB= " + NhaXuatban);
            query.Append(",@SoLuong= " + nmrSoLuong.Value);
            int kq = dch.execNonQuery(query.ToString());
            if (kq > 0)
            {
                HienDuLieuSach();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá cuốn " + txtTenSach.Text + " không? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                errLoi.SetError(txtMaSach, "");
                if (txtMaSach.Text == "")
                {
                    errLoi.SetError(txtMaSach, "Bạn chư nhập mã sách");
                    return;
                }

                StringBuilder query = new StringBuilder("exec Xoa_Du_Lieu_Sach");
                query.Append(" @MaSach= '" + txtMaSach.Text + "'");
                int kq = dch.execNonQuery(query.ToString());
                if (kq > 0)
                {
                    HienDuLieuSach();
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Không xoá được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbTheLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox theLoai = sender as ComboBox;
            TheLoai = theLoai.SelectedValue.ToString();
        }

        private void cmbNhaXuatBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox nhaXuatban = sender as ComboBox;
            NhaXuatban = nhaXuatban.SelectedValue.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiemTheoTenSach();
        }

        private void TimKiemTheoTenSach()
        {
            if (txtTenSach.Text == "")
            {
                HienDuLieuSach();
                MessageBox.Show("Không tìm thấy sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DataTable dt = new DataTable();
                StringBuilder query = new StringBuilder("exec TimKiemTheoTen");
                query.Append(" @TenSach= N'" + txtTenSach.Text + "'");
                dt = dch.execQuery(query.ToString());
                dgvSach.DataSource = dt;
            }
        }

        private void FormSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đóng form lại ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /*private void btnChonKhoangGia_Click(object sender, EventArgs e)
        {
            FormChonKhoangGia formChonKhoangGia = new FormChonKhoangGia();
            formChonKhoangGia.ShowDialog();
        }*/
    }
}
