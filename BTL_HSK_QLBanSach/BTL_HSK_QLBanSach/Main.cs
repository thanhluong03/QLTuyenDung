using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BTL_HSK_QLBanSach
{
    class Main
    {
        public string sql  = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLSach;Integrated Security=True";
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
        public void hienDLDGV(string sql, DataGridView dgv)
        {
            if (KetnoiCSDL() == false) return;
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dgv.DataSource = dt;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                adt.Dispose();
                dt.Dispose();
            }
            catch
            {
                MessageBox.Show("Lỗi hiện dữ liệu", "Thông báo");
                return;
            }
        }
        public void hienDLCCB(string tenBang, string tenCotKhoa, string tenCotHienThi, ComboBox cbo)
        {
            if (KetnoiCSDL() == false)
                return;
            string strSQL = "Select " + tenCotKhoa + ", " + tenCotHienThi + " from " + tenBang;
            using (SqlDataAdapter adt = new SqlDataAdapter(strSQL, sql))
            {
                DataTable dt = new DataTable();
                adt.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = tenCotHienThi;
                cbo.ValueMember = tenCotKhoa;
            }
        }
        public void Xoadulieu(string sTenThutuc, string sThamso, string sGiatri)
        {
            if (KetnoiCSDL() == false)
                return;
            try
            {
                SqlCommand cmd = new SqlCommand(sTenThutuc, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(sThamso, sGiatri);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo");
            }

        }
        public void Timkiemdl (string thutuc, string thamso, string giatri, DataGridView dgr)
        {
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
                    dgr.DataSource = tb;

                }
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm dữ liệu", "Thông báo");
            }
        }
        public void Timkiemdl2dk(string thutuc, string thamso1, string giatri1, string thamso2, string giatri2, DataGridView dgr)
        {
            try
            {
                if (KetnoiCSDL() == false)
                    return;
                SqlCommand cmd = new SqlCommand(thutuc, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(thamso1, giatri1);
                cmd.Parameters.AddWithValue(thamso2, giatri2);
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable();
                    ad.Fill(tb);
                    dgr.DataSource = tb;

                }
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm dữ liệu", "Thông báo");
            }
        }
        public void Xoadulieu2dk(string sTenThutuc, string sThamso1, string sGiatri1, string sThamso2, string sGiatri2)
        {
            if (KetnoiCSDL() == false)
                return;
            try
            {
                SqlCommand cmd = new SqlCommand(sTenThutuc, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(sThamso1, sGiatri1);
                cmd.Parameters.AddWithValue(sThamso2, sGiatri2);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo");
            }

        }

        public DataTable execQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(sql))
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dt);
            }
            return dt;
        }

        public int execNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection sqlCon = new SqlConnection(sql))
            {
                sqlCon.Open();
                using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                {
                    data = sqlCmd.ExecuteNonQuery();
                }
            }
            return data;
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
