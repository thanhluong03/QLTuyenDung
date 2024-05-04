using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class InBaoCaoSach : Form
    {
        Main dch = new Main();
        public InBaoCaoSach()
        {
            InitializeComponent();
        }
        public InBaoCaoSach(string v)
        {
            InitializeComponent();
             txtnguoilap.Text = v;
        }
        private DataTable layDStheloai()
        {
            string constr = @"Data Source=LAPTOP-KU30EBQQ\SQLEXPRESS01;Initial Catalog=BTL_HSK_QLThuVien;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblTheLoai", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("theloai");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienDSTheLoai()
        {
            DataTable t = layDStheloai();
            DataView v = new DataView(t);
            v.Sort = "sTheLoai";
            cbtheloai.DataSource = v;
            cbtheloai.DisplayMember = "sTheLoai";
            cbtheloai.ValueMember = "iMaLoai";
        }
        private void InBaoCaoSach_Load(object sender, EventArgs e)
        {
            load();
            hienDSTheLoai();
            AnDieukhien();
            cbtheloai.Text = null;
        }

        private void load()
        {
            if (dch.KetnoiCSDL() == true)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dch.cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "pr_BaoCaoSach";
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        BaoCaoSach rpt = new BaoCaoSach();
                        rpt.SetDataSource(tb);
                        ParameterFieldDefinition pfd = rpt.DataDefinition.ParameterFields["nguoilap"];
                        ParameterValues pv = new ParameterValues();
                        ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                        pdv.Value = txtnguoilap.Text;
                        pv.Add(pdv);
                        pfd.CurrentValues.Clear();
                        pfd.ApplyCurrentValues(pv);
                        crySach.ReportSource = rpt;
                        crySach.Refresh();
                    }

                }
            }
        }
        private void baocaotheloai()
        {
            if (dch.KetnoiCSDL() == true)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dch.cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "pr_BaoCaoTheoTheLoai";
                    cmd.Parameters.AddWithValue("@theloai", cbtheloai.Text);

                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        BaoCaoSach rpt = new BaoCaoSach();
                        rpt.SetDataSource(tb);
                        ParameterFieldDefinition pfd = rpt.DataDefinition.ParameterFields["nguoilap"];
                        ParameterValues pv = new ParameterValues();
                        ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                        pdv.Value = txtnguoilap.Text;
                        pv.Add(pdv);
                        pfd.CurrentValues.Clear();
                        pfd.ApplyCurrentValues(pv);
                        crySach.ReportSource = rpt;
                        crySach.Refresh();
                    }

                }
            }
        }
        private void baocaogiamuon()
        {
            if (dch.KetnoiCSDL() == true)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dch.cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "pr_BaoCaoGiaMuonTrongKhoang";
                    cmd.Parameters.AddWithValue("@giatridau", txtgiatridau.Text);
                    cmd.Parameters.AddWithValue("@giatricuoi", txtgiatricuoi.Text);

                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        BaoCaoSach rpt = new BaoCaoSach();
                        rpt.SetDataSource(tb);
                        ParameterFieldDefinition pfd = rpt.DataDefinition.ParameterFields["nguoilap"];
                        ParameterValues pv = new ParameterValues();
                        ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                        pdv.Value = txtnguoilap.Text;
                        pv.Add(pdv);
                        pfd.CurrentValues.Clear();
                        pfd.ApplyCurrentValues(pv);
                        crySach.ReportSource = rpt;
                        crySach.Refresh();
                    }

                }
            }
        }
        private void AnDieukhien()
        {
            cbtheloai.Visible = false;
            txtgiatridau.Visible = false;
            txtgiatricuoi.Visible = false;
            lbden.Visible = false;
        }

        private void rdtheloai_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            cbtheloai.Visible = true;
            cbtheloai.Top = rdtheloai.Top;
        }

        private void rdgiamuon_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            txtgiatridau.Visible = true;
            txtgiatricuoi.Visible = true;
            lbden.Visible = true;
            txtgiatridau.Top = rdgiamuon.Top;
            txtgiatricuoi.Top = rdgiamuon.Top;
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            if (rdtheloai.Checked )
            {
                baocaotheloai();
            }
            if(rdgiamuon.Checked)
            {
                baocaogiamuon();
            }
        }

        private void txtnguoilap_Validating(object sender, CancelEventArgs e)
        {
         /*   if(txtnguoilap.Text == "")
            {
                errorProvider1.SetError(txtnguoilap, "Không được trống!!");
                txtnguoilap.Focus();
            }
            else
            {
                errorProvider1.SetError(txtnguoilap, "");
            }*/
        }
    }
}
