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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon f2 = new HoaDon();
            f2.MdiParent = this;
            f2.Show();
        }

        private void timKiemHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemHoaDon TK = new TimKiemHoaDon();
            TK.MdiParent = this;
            TK.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemChiTietHD TK = new TimKiemChiTietHD();
            TK.MdiParent = this;
            TK.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSach sach= new FormSach();
            sach.MdiParent = this;
            sach.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTheLoai sach = new FormTheLoai();
            sach.MdiParent = this;
            sach.Show();
        }

        private void hdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InBaoCaoSach sach = new InBaoCaoSach();
            sach.MdiParent = this;
            sach.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHang nhap = new NhapHang();
            nhap.MdiParent = this;
            nhap.Show();
        }

        private void nhânviênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Quản Lí Nhân Viên")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                NhanVien fkh = new NhanVien();
                fkh.MdiParent = this;
                fkh.Show();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Khách Hàng")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                KhachHang fkh = new KhachHang();
                fkh.MdiParent = this;
                fkh.Show();
            }
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Báo Cáo Nhân Viên ")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                InBaoCaoNhanVien nv = new InBaoCaoNhanVien();
                nv.MdiParent = this;
                nv.Show();
            }
        }

        private void DangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void đơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InBaoCaoDonNhap dn = new InBaoCaoDonNhap();
            dn.MdiParent = this;
            dn.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InBaoCaoHD dn = new InBaoCaoHD();
            dn.MdiParent = this;
            dn.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
