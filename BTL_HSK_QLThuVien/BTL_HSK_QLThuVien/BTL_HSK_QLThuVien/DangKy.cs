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

namespace BTL_HSK_QLThuVien
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
         //   this.Close();
            DangNhap f = new DangNhap();
            f.Show();
            this.Hide();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmanv.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Không được để trống thông tin đăng ký!", "Thông Báo");
            }
            else
            {
                string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    string username = txtUsername.Text;
                    string query = "select count(*) from tblDangNhap where sTenDangNhap = @tendangnhap";
                    SqlCommand command = new SqlCommand(query, cnn);
                    command.Parameters.AddWithValue("@tendangnhap", username);
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
                            cmd.CommandText = "pr_DangKy";
                            cmd.Parameters.AddWithValue("@tendangnhap", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@matkhau", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@manv", txtmanv.Text);
                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Đăng ký thành công!", "Thông Báo");
                                txtmanv.Text = "";
                                txtUsername.Text = "";
                                txtPassword.Text = "";
                            }
                        }
                    }
                }
            }
        }

        private void txtmanv_Validating(object sender, CancelEventArgs e)
        {
            if (txtmanv.Text == "")
            {
                errorProvider1.SetError(txtmanv, "Hãy nhập Mã nhân viên!!");
                txtmanv.Focus();
            }
            else
            {
                errorProvider1.SetError(txtmanv, "");
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Hãy nhập Tên đăng nhập!!");
                txtUsername.Focus();
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Hãy nhập Mật khẩu!!");
                txtPassword.Focus();
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }
    }
}
