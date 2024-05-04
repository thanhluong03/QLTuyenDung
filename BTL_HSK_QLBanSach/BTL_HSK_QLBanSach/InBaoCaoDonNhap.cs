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

namespace BTL_HSK_QLBanSach
{
    public partial class InBaoCaoDonNhap : Form
    {
        Main dch = new Main();
        public InBaoCaoDonNhap()
        {
            InitializeComponent();
        }
        private void load()
        {
            if (dch.KetnoiCSDL() == true)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dch.cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "thongkenhaphang";
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        BaoCaoDonNhap rpt = new BaoCaoDonNhap();
                        rpt.SetDataSource(tb);
                        ParameterFieldDefinition pfd = rpt.DataDefinition.ParameterFields["NguoiLap"];
                        ParameterValues pv = new ParameterValues();
                        ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                        pdv.Value = txtTenNguoiLap.Text;
                        pv.Add(pdv);
                        pfd.CurrentValues.Clear();
                        pfd.ApplyCurrentValues(pv);
                        cryDN.ReportSource = rpt;
                        cryDN.Refresh();
                    }

                }
            }
        }
        private void btnInds_Click(object sender, EventArgs e)
        {
            //cryRpt.Load(@"C:\Users\Admin\Documents\Visual Studio 2022\lthsk\BTL_HSK_Sach\BTL_HSK_Sach\DonNhap_Thang.rpt");
            if (dch.KetnoiCSDL() == true)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dch.cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_crp_ThongKeNhapHang";
                    cmd.Parameters.AddWithValue("@thang", txtthang.Text);
                    cmd.Parameters.AddWithValue("@nam", txtnam.Text);

                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        BaoCaoDonNhap rpt = new BaoCaoDonNhap();
                        rpt.SetDataSource(tb);
                        ParameterFieldDefinition pfd = rpt.DataDefinition.ParameterFields["NguoiLap"];
                        ParameterValues pv = new ParameterValues();
                        ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                        pdv.Value = txtTenNguoiLap.Text;
                        pv.Add(pdv);
                        pfd.CurrentValues.Clear();
                        pfd.ApplyCurrentValues(pv);
                        cryDN.ReportSource = rpt;
                        cryDN.Refresh();
                    }

                }
            }
        }

        private void txtthang_Validating(object sender, CancelEventArgs e)
        {
            if (txtthang.Text == "")
            {
                errorProvider1.SetError(txtthang, "Bạn phải nhập tháng");
            }
            else
            {
                try
                {
                    int thang = int.Parse(txtthang.Text);
                    if (thang < 0 || thang > 12)
                        errorProvider1.SetError(txtthang, "Chỉ có 12 tháng");
                    else
                        errorProvider1.SetError(txtthang, "");
                }
                catch
                {
                    errorProvider1.SetError(txtthang, "Nhập tháng bằng số");
                }
            }
        }

        private void txtnam_Validating(object sender, CancelEventArgs e)
        {
            if (txtnam.Text == "")
            {
                errorProvider1.SetError(txtnam, "Bạn phải nhập năm");
            }
            else
            {
                try
                {
                    int nam = int.Parse(txtnam.Text);
                    if (nam > DateTime.Today.Year)
                        errorProvider1.SetError(txtnam, "Lớn hơn năm hiện tại");
                    else
                        errorProvider1.SetError(txtnam, "");
                }
                catch
                {
                    errorProvider1.SetError(txtnam, "Điểm không hợp lệ");
                }
            }
        }

        private void InBaoCaoDonNhap_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
