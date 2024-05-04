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
    public partial class ForgetPass : Form
    {

        public ForgetPass()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Không được để trống tên đăng nhập hoặc mật khẩu", "Thông Báo");
            }
            else
            {
                string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    string username = txtUsername.Text;
                    string query = "select count(*) from tblDangKi where sTenDangNhap = @tenDangNhap";
                    SqlCommand command = new SqlCommand(query, cnn);
                    command.Parameters.AddWithValue("@tenDangNhap", username);
                    int count = (int)command.ExecuteScalar();
                    cnn.Close();
                    if (count <= 0)
                    {
                        MessageBox.Show("Không tồn tại tài khoản! Vui lòng đăng kí tài khoản mới", "Thông Báo");
                    }
                    else
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "update_user";
                            cmd.Parameters.AddWithValue("@tenDangNhap", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text);
                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Đặt lại thành công!", "Thông Báo");
                            }
                        }
                    }
                }
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }


    }
}
