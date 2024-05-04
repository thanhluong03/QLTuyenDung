using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_QLThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string v)
        {
            InitializeComponent();
            lbnguoidung.Text = v;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
             if (MessageBox.Show("Bạn có chắc đóng Trang chủ không?", "FormClosing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              {
                  e.Cancel = false;
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Hide();
            }
              else
              {
                  e.Cancel = true;
              }
       
        }

        private void thểLoạiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();
            tl.MdiParent = this;
            tl.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.MdiParent = this;
            nxb.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.MdiParent = this;
            s.Show();
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DangNhap dk = new DangNhap();
            dk.Show();
            this.Hide();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MdiParent = this;
            sv.Show();
        }

        private void báoCáoSáchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InBaoCaoSach bcs = new InBaoCaoSach(lbnguoidung.Text);
            bcs.MdiParent = this;
            bcs.Show();
        }

        private void mượnSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MuonSach tl = new MuonSach();
            tl.MdiParent = this;
            tl.Show();
        }

        private void chiTiếtMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietMuonSach ct = new ChiTietMuonSach();
            ct.MdiParent = this;
            ct.Show();
        }
    }
}
