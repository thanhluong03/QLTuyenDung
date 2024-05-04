using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_HSK_QLThuVien
{
    class Main
    {
        public string sql = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLThuVien;Integrated Security=True";
        public SqlConnection cnn = new SqlConnection();
        public bool KetnoiCSDL()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.ConnectionString = sql;
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo");
                return false;
            }
            return true;
        }
        public void HienthiDulieutrenDatagridView(string strSQL, DataGridView dgr)
        {
            if (KetnoiCSDL() == false)
                return;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from " + strSQL, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgr.DataSource = dt;
                dgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                da.Dispose();
                dt.Dispose();
            }
            catch
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu", "Thông báo");
                return;
            }
        }
        public void Timkiemdl(string thutuc, string thamso, string giatri, DataGridView dgr)
        {
            int i = 0;
            try
            {
                if (KetnoiCSDL() == false)
                    return;
                SqlCommand cmd = new SqlCommand(thutuc, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(thamso, giatri);
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ad.Fill(tb);
                    i++;
                    dgr.DataSource = tb;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm dữ liệu", "Thông báo");
            }
        }
        public bool ktraKhoa(string tenBang, string tencot, int ma)
        {
            if (KetnoiCSDL() == true)
            {
                string strSQL = @"Select [" + tencot + "] from " + tenBang + " where [" + tencot + "] =" + ma;
                using (SqlDataAdapter adt = new SqlDataAdapter(strSQL, sql))
                {
                    using (DataTable tb = new DataTable("table"))
                    {
                        adt.Fill(tb);
                        if (tb.Rows.Count == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
