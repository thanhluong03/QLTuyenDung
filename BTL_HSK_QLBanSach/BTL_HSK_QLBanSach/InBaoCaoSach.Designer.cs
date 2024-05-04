
namespace BTL_HSK_QLBanSach
{
    partial class InBaoCaoSach
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
            this.lblNhapKhoangDau = new System.Windows.Forms.Label();
            this.btnInSach = new System.Windows.Forms.Button();
            this.crySach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.nmrMin = new System.Windows.Forms.NumericUpDown();
            this.lblNhapKhoangCuoi = new System.Windows.Forms.Label();
            this.nmrMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNhapKhoangDau
            // 
            this.lblNhapKhoangDau.AutoSize = true;
            this.lblNhapKhoangDau.Location = new System.Drawing.Point(31, 14);
            this.lblNhapKhoangDau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapKhoangDau.Name = "lblNhapKhoangDau";
            this.lblNhapKhoangDau.Size = new System.Drawing.Size(125, 17);
            this.lblNhapKhoangDau.TabIndex = 0;
            this.lblNhapKhoangDau.Text = "Nhập khoảng đầu:";
            // 
            // btnInSach
            // 
            this.btnInSach.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInSach.Location = new System.Drawing.Point(985, 8);
            this.btnInSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnInSach.Name = "btnInSach";
            this.btnInSach.Size = new System.Drawing.Size(75, 26);
            this.btnInSach.TabIndex = 2;
            this.btnInSach.Text = "Tìm";
            this.btnInSach.UseVisualStyleBackColor = false;
            this.btnInSach.Click += new System.EventHandler(this.btnInSach_Click);
            // 
            // crySach
            // 
            this.crySach.ActiveViewIndex = -1;
            this.crySach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crySach.Cursor = System.Windows.Forms.Cursors.Default;
            this.crySach.Location = new System.Drawing.Point(-1, 47);
            this.crySach.Margin = new System.Windows.Forms.Padding(2);
            this.crySach.Name = "crySach";
            this.crySach.Size = new System.Drawing.Size(1264, 687);
            this.crySach.TabIndex = 3;
            this.crySach.ToolPanelWidth = 133;
            // 
            // nmrMin
            // 
            this.nmrMin.Location = new System.Drawing.Point(160, 10);
            this.nmrMin.Margin = new System.Windows.Forms.Padding(2);
            this.nmrMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrMin.Name = "nmrMin";
            this.nmrMin.Size = new System.Drawing.Size(217, 22);
            this.nmrMin.TabIndex = 4;
            // 
            // lblNhapKhoangCuoi
            // 
            this.lblNhapKhoangCuoi.AutoSize = true;
            this.lblNhapKhoangCuoi.Location = new System.Drawing.Point(485, 14);
            this.lblNhapKhoangCuoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapKhoangCuoi.Name = "lblNhapKhoangCuoi";
            this.lblNhapKhoangCuoi.Size = new System.Drawing.Size(127, 17);
            this.lblNhapKhoangCuoi.TabIndex = 5;
            this.lblNhapKhoangCuoi.Text = "Nhập khoảng cuối:";
            // 
            // nmrMax
            // 
            this.nmrMax.Location = new System.Drawing.Point(621, 13);
            this.nmrMax.Margin = new System.Windows.Forms.Padding(2);
            this.nmrMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrMax.Name = "nmrMax";
            this.nmrMax.Size = new System.Drawing.Size(217, 22);
            this.nmrMax.TabIndex = 6;
            // 
            // InBaoCaoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 740);
            this.Controls.Add(this.nmrMax);
            this.Controls.Add(this.lblNhapKhoangCuoi);
            this.Controls.Add(this.nmrMin);
            this.Controls.Add(this.crySach);
            this.Controls.Add(this.btnInSach);
            this.Controls.Add(this.lblNhapKhoangDau);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InBaoCaoSach";
            this.Text = "Báo Cáo Sách";
            this.Load += new System.EventHandler(this.InBaoCaoSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapKhoangDau;
        private System.Windows.Forms.Button btnInSach;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crySach;
        private System.Windows.Forms.NumericUpDown nmrMin;
        private System.Windows.Forms.Label lblNhapKhoangCuoi;
        private System.Windows.Forms.NumericUpDown nmrMax;
    }
}