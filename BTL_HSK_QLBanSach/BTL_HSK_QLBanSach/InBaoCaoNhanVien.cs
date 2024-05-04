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
    public partial class InBaoCaoNhanVien : Form
    {
        public InBaoCaoNhanVien()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DSNV";
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new System.Data.DataTable();
                        ad.Fill(tb);
                        BaoCaoNhanVien rpt = new BaoCaoNhanVien();
                        rpt.SetDataSource(tb);
                        crystalReportViewer1.ReportSource = rpt;
                        crystalReportViewer1.Refresh();
                    }
                }

            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DSNVtheothang";
                    cmd.Parameters.AddWithValue("@ngayVao", dateTimePicker1.Value);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new System.Data.DataTable();
                        ad.Fill(tb);
                        BaoCaoNhanVien rpt = new BaoCaoNhanVien();
                        rpt.SetDataSource(tb);
                        crystalReportViewer1.ReportSource = rpt;
                        crystalReportViewer1.Refresh();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_qlsach"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DSNV";
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new System.Data.DataTable();
                        ad.Fill(tb);
                        BaoCaoNhanVien rpt = new BaoCaoNhanVien();
                        rpt.SetDataSource(tb);
                        crystalReportViewer1.ReportSource = rpt;
                        crystalReportViewer1.Refresh();
                    }
                }

            }
        }

     
    }
}
