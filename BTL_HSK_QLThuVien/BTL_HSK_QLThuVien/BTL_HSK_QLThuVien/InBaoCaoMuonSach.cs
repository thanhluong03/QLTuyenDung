using CrystalDecisions.CrystalReports.Engine;
using BTL_HSK_QLThuVien.BaoCao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_QLThuVien
{
    public partial class InBaoCaoMuonSach : Form
    {
        string connectionString = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLThuVien;Integrated Security=True";
        public InBaoCaoMuonSach()
        {
            InitializeComponent();
            LoadDatatoComboBox();
        }

        public void LoadDatatoComboBox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("Select iMaMuon from tblMuonSach", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_mamuonIn.ValueMember = "iMaMuon";
                        cb_mamuonIn.DisplayMember = "iMaMuon";
                        cb_mamuonIn.DataSource = dt;
                        cb_mamuonIn.Text = string.Empty;
                    }
                }
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            cb_mamuonIn.Text = "";
        }

        public void ShowBaoCao2(string storedProcedureName, string fileName)
        {
            cb_mamuonIn.Hide();
            label1.Hide();
            btn_inMamuon.Hide();
            ShowBaoCao2(storedProcedureName, fileName, null);
        }

        public void ShowBaoCao2(string storedProcedureName, string fileName, int? iMaMuon)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(storedProcedureName, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    if (iMaMuon != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@iMaMuon", iMaMuon);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            ReportDocument reportDocument = new ReportDocument();
                            string path = string.Format("{0}\\BaoCao\\{1}.rpt", Application.StartupPath, fileName);
                            reportDocument.Load(path);

                            // Gắn dữ liệu vào báo cáo
                            reportDocument.SetDataSource(dt);

                            // Cài đặt các tham số của báo cáo
                            reportDocument.SetParameterValue("NguoiLapPhieu", "Nguyễn Tuấn Anh");
                            reportDocument.SetParameterValue("Ten", "Anh");

                            crystalReportViewer1.ReportSource = reportDocument;
                        }
                    }
                }
            }
        }



        private void btn_inMamuon_Click(object sender, EventArgs e)
        {
            if (cb_mamuonIn.SelectedIndex >= 0)
            {
                this.ShowBaoCao2("Select_BaoCaoMuonSach", "QLMS");
            }
        }

        private void InBaoCaoMuonSach_Load(object sender, EventArgs e)
        {

        }
    }
}
