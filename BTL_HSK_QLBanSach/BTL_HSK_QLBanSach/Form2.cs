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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelSubMenu.Visible = false;
            panelSubMenuData.Visible = false;
            panelSubMenuSach.Visible = false;
            panelSubReport.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
            if (panelSubMenuData.Visible == true)
            {
                panelSubMenuData.Visible = false;
            }
            if (panelSubMenuSach.Visible == true)
            {
                panelSubMenuSach.Visible = false;
            }
            if (panelSubReport.Visible == true)
            {
                panelSubReport.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private void btnNewPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPass f = new ForgetPass();
            f.Show();
            hideSubMenu();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuSach);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Quản Lí Sách")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                FormSach sach = new FormSach();
                sach.MdiParent = this;
                sach.Dock = DockStyle.Fill;
                sach.Show();
                hideSubMenu();
            }
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Quản Lí Thể Loại")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                FormTheLoai sach = new FormTheLoai();
                sach.MdiParent = this;
                sach.Dock = DockStyle.Fill;
                sach.Show();
                hideSubMenu();
            }
          
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Quản Lí Nhà Xuất Bản")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                Nhaxuatban nxb = new Nhaxuatban();
                nxb.MdiParent = this;
                nxb.Dock = DockStyle.Fill;
                nxb.Show();
                hideSubMenu();
            }
            
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuData);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Quản Lí Hóa Đơn")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {

                HoaDon f2 = new HoaDon();
                f2.MdiParent = this;
                f2.Dock = DockStyle.Fill;
                f2.Show();
                hideSubMenu();
            }

        }

        private void btnDonNhap_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Quản Lí Nhập Hàng")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {

                NhapHang nhap = new NhapHang();
                nhap.MdiParent = this;
                nhap.Dock = DockStyle.Fill;
                nhap.Show();
                hideSubMenu();
            }
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
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
                NhanVien fnv = new NhanVien();
                fnv.MdiParent = this;
                fnv.Dock = DockStyle.Fill;
                fnv.Show();
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Quản Lí Khách Hàng")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                KhachHang fnv = new KhachHang();
                fnv.MdiParent = this;
                fnv.Dock = DockStyle.Fill;
                fnv.Show();
            }
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubReport);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Báo Cáo Hóa Đơn")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                InBaoCaoHD sach = new InBaoCaoHD();
                sach.MdiParent = this;
                sach.Dock = DockStyle.Fill;
                sach.Show();
                hideSubMenu();
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Báo Cáo Sách")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                InBaoCaoSach sach = new InBaoCaoSach();
                sach.MdiParent = this;
                sach.Dock = DockStyle.Fill;
                sach.Show();
                hideSubMenu();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
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
                nv.Dock = DockStyle.Fill;
                nv.Show();
            }
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Báo Cáo Đơn Nhập ")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                InBaoCaoDonNhap nv = new InBaoCaoDonNhap();
                nv.MdiParent = this;
                nv.Dock = DockStyle.Fill;
                nv.Show();
            }
            hideSubMenu();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();


        }
    }
}
