namespace BTL_HSK_QLThuVien
{
    partial class InBaoCaoMuonSach
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_mamuonIn = new System.Windows.Forms.ComboBox();
            this.btn_inMamuon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn mã mượn cần in";
            // 
            // cb_mamuonIn
            // 
            this.cb_mamuonIn.FormattingEnabled = true;
            this.cb_mamuonIn.Location = new System.Drawing.Point(40, 160);
            this.cb_mamuonIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_mamuonIn.Name = "cb_mamuonIn";
            this.cb_mamuonIn.Size = new System.Drawing.Size(175, 24);
            this.cb_mamuonIn.TabIndex = 2;
            // 
            // btn_inMamuon
            // 
            this.btn_inMamuon.Location = new System.Drawing.Point(75, 210);
            this.btn_inMamuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inMamuon.Name = "btn_inMamuon";
            this.btn_inMamuon.Size = new System.Drawing.Size(100, 28);
            this.btn_inMamuon.TabIndex = 3;
            this.btn_inMamuon.Text = "In";
            this.btn_inMamuon.UseVisualStyleBackColor = true;
            this.btn_inMamuon.Click += new System.EventHandler(this.btn_inMamuon_Click);
            // 
            // InBaoCaoMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_inMamuon);
            this.Controls.Add(this.cb_mamuonIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InBaoCaoMuonSach";
            this.Text = "InBaoCao";
            this.Load += new System.EventHandler(this.InBaoCaoMuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_mamuonIn;
        private System.Windows.Forms.Button btn_inMamuon;
    }
}