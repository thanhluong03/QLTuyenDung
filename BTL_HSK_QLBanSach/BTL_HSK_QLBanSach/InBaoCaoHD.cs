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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BTL_HSK_QLBanSach
{
    public partial class InBaoCaoHD : Form
    {
        Main dch = new Main();
        public InBaoCaoHD()
        {
            InitializeComponent();
        }

        private void InBaoCaoHD_Load(object sender, EventArgs e)
        {
            load();
            AnDieukhien();
        }

        private void load ()
        {

            if (dch.KetnoiCSDL() == false)
                return;
            string sql = "pr_baocaohd";
            SqlCommand cmd = new SqlCommand(sql, dch.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
            {
                DataTable tb = new System.Data.DataTable();
                ad.Fill(tb);
                HoaDonBan rpt = new HoaDonBan();
                rpt.SetDataSource(tb);
                cryHD.ReportSource = rpt;
                cryHD.Refresh();
            }
        }

        /*private void nguoilap()
        {
            if (txtnguoilap.Text == "")
            {
                MessageBox.Show("hãy nhập người lập", "Thông báo");
                txtnguoilap.Focus();
            }
            else
            {
                ReportDocument cry = new ReportDocument();
                cry.Load(@"D:\File Học\Năm2022_2023\HocKy-2\C# Programing\BTL_HSK_QLBanSach\BTL_HSK_QLBanSach\InHD.rpt");
                ParameterFieldDefinition pfd = cry.DataDefinition.ParameterFields["nguoilap"];
                ParameterValues pv = new ParameterValues();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pdv.Value = txtnguoilap.Text;
                pv.Add(pdv);
                pfd.CurrentValues.Clear();
                pfd.ApplyCurrentValues(pv);
                cryHD.ReportSource = cry;
                cryHD.Refresh();
            }
        }*/

        private void khachhang()
        {
            if (dch.KetnoiCSDL() == false)
                return;
            string sql = "pr_timkiemhdkh";
            SqlCommand cmd = new SqlCommand(sql, dch.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenkh", txtkhachhang.Text);
            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
            {
                DataTable tb = new System.Data.DataTable();
                ad.Fill(tb);
                HoaDonBan rpt = new HoaDonBan();
                rpt.SetDataSource(tb);
                cryHD.ReportSource = rpt;
                cryHD.Refresh();
            }
        }

        private void thangnam()
        {
            if (dch.KetnoiCSDL() == false)
                return;
            string sql = "pr_thangnam";
            SqlCommand cmd = new SqlCommand(sql, dch.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngay", dtthangnam.Value);
            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
            {
                DataTable tb = new System.Data.DataTable();
                ad.Fill(tb);
                HoaDonBan rpt = new HoaDonBan();
                rpt.SetDataSource(tb);
                cryHD.ReportSource = rpt;
                cryHD.Refresh();
            }
        }
        private void AnDieukhien()
        {
            txtkhachhang.Visible = false;
            dtthangnam.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rdkhachhang.Checked)
            {
                khachhang();
            }
            if(rdthangnam.Checked)
            {
                thangnam();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            txtkhachhang.Visible = true;
            txtkhachhang.Top = rdkhachhang.Top;
        }
        private void rdthangnam_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            dtthangnam.Visible = true;
            dtthangnam.Top = rdthangnam.Top;
        }
    }
}
