
namespace BTL_HSK_QLBanSach
{
    partial class InBaoCaoDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtthang = new System.Windows.Forms.MaskedTextBox();
            this.txtnam = new System.Windows.Forms.MaskedTextBox();
            this.btnInds = new System.Windows.Forms.Button();
            this.cryDN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNguoiLap = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm:";
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(116, 2);
            this.txtthang.Mask = "0#";
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(50, 22);
            this.txtthang.TabIndex = 2;
            this.txtthang.Validating += new System.ComponentModel.CancelEventHandler(this.txtthang_Validating);
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(274, 2);
            this.txtnam.Mask = "0000";
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(54, 22);
            this.txtnam.TabIndex = 3;
            this.txtnam.Validating += new System.ComponentModel.CancelEventHandler(this.txtnam_Validating);
            // 
            // btnInds
            // 
            this.btnInds.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInds.Location = new System.Drawing.Point(721, 2);
            this.btnInds.Name = "btnInds";
            this.btnInds.Size = new System.Drawing.Size(75, 23);
            this.btnInds.TabIndex = 4;
            this.btnInds.Text = "In";
            this.btnInds.UseVisualStyleBackColor = false;
            this.btnInds.Click += new System.EventHandler(this.btnInds_Click);
            // 
            // cryDN
            // 
            this.cryDN.ActiveViewIndex = -1;
            this.cryDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryDN.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryDN.Location = new System.Drawing.Point(4, 30);
            this.cryDN.Name = "cryDN";
            this.cryDN.Size = new System.Drawing.Size(1222, 616);
            this.cryDN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Người lập:";
            // 
            // txtTenNguoiLap
            // 
            this.txtTenNguoiLap.Location = new System.Drawing.Point(480, 2);
            this.txtTenNguoiLap.Name = "txtTenNguoiLap";
            this.txtTenNguoiLap.Size = new System.Drawing.Size(191, 22);
            this.txtTenNguoiLap.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InBaoCaoDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 646);
            this.Controls.Add(this.txtTenNguoiLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cryDN);
            this.Controls.Add(this.btnInds);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InBaoCaoDonNhap";
            this.Text = "Báo Cáo Đơn Nhập";
            this.Load += new System.EventHandler(this.InBaoCaoDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtthang;
        private System.Windows.Forms.MaskedTextBox txtnam;
        private System.Windows.Forms.Button btnInds;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNguoiLap;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}