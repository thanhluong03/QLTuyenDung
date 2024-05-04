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

namespace BTL_HSK_QLBanSach
{
    public partial class InBaoCaoSach : Form
    {
        public InBaoCaoSach()
        {
            InitializeComponent();
        }
        Main dch = new Main();
        private void load()
        {
            if (dch.KetnoiCSDL() == false)
                return;
            string sql = "HienThiSach";
            SqlCommand cmd = new SqlCommand(sql, dch.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
            {
                DataTable tb = new System.Data.DataTable();
                ad.Fill(tb);
                BaoCaoSach rpt = new BaoCaoSach();
                rpt.SetDataSource(tb);
                crySach.ReportSource = rpt;
                crySach.Refresh();
            }
        }

        private void btnInSach_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("exec HienThiDuLieuSach");
            query.Append(" @Min= " + nmrMin.Value);
            query.Append(",@Max= " + nmrMax.Value);
            dt = dch.execQuery(query.ToString());
            BaoCaoSach reportChonKhoangGia = new BaoCaoSach();
            reportChonKhoangGia.SetDataSource(dt);
            crySach.ReportSource = reportChonKhoangGia;
        }

        private void InBaoCaoSach_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
