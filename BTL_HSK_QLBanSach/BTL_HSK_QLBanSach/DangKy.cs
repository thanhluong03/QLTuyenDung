using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_QLBanSach
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }



        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            txtName.BackColor = SystemColors.Control;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Không được để trống thông tin đăng ký!", "Thông Báo");
            }
            else
            {
                string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    string username = txtUserName.Text;
                    string query = "select count(*) from tblDangKi where sTenDangNhap = @tenDangNhap";
                    SqlCommand command = new SqlCommand(query, cnn);
                    command.Parameters.AddWithValue("@tenDangNhap", username);
                    int count = (int)command.ExecuteScalar();
                    cnn.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Đã tồn tại tài khoản! Vui lòng đăng nhập hoặc bấm quên mật khẩu", "Thông Báo");
                    }
                    else
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "insert_newuser";
                            cmd.Parameters.AddWithValue("@tenDangNhap", txtUserName.Text);
                            cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@TenUser", txtName.Text);
                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Đăng ký thành công!", "Thông Báo");
                                txtName.Text = "";
                                txtUserName.Text = "";
                                txtPassword.Text = "";
                            }
                        }
                    }
                }
            }




        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPass f = new ForgetPass();
            f.Show();
            this.Close();
        }
    }
}
