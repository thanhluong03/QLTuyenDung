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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
                string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    string username = txtUsername.Text;
                    string pass = txtPassword.Text;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pr_DangNhap";
                        cmd.Parameters.AddWithValue("@tenDangNhap", username);
                        cmd.Parameters.AddWithValue("@matKhau", pass);
                        cnn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows == true)
                            {
                                Form1 f1 = new Form1(txtUsername.Text);
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
            this.Hide();
        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc đóng Trang Đăng Nhập không?", "FormClosing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;            
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if(txtUsername.Text == "")
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
