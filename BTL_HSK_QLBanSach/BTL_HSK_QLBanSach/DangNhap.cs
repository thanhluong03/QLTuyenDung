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
using System.Configuration;


namespace BTL_HSK_QLBanSach
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống", "Thông Báo");

            }
            {
                string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    string username = txtUsername.Text;
                    string pass = txtPassword.Text;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_login";
                        cmd.Parameters.AddWithValue("@tenDangNhap", username);
                        cmd.Parameters.AddWithValue("@matKhau", pass);
                        cnn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows == true)
                            {
                                Form2 f1 = new Form2();
                                f1.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Sai thông tin đăng nhập!!", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
        }

        private void picPassword_Click(object sender, EventArgs e)
        {

        }

        private void picPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void picPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            DangKy fdk = new DangKy();
            fdk.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPass f = new ForgetPass();
            f.Show();
            this.Hide();
        }


        private void fDangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void fDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    string username = txtUsername.Text;
                    string pass = txtPassword.Text;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_login";
                        cmd.Parameters.AddWithValue("@tenDangNhap", username);
                        cmd.Parameters.AddWithValue("@matKhau", pass);
                        cnn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows == true)
                            {
                                Form1 f1 = new Form1();
                                f1.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Sai thông tin đăng nhập!!", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
