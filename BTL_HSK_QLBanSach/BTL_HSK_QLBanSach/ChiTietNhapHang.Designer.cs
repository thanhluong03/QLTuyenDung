namespace BTL_HSK_QLBanSach
{
    partial class ChiTietNhapHang
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
            this.dgvCTNhapHang = new System.Windows.Forms.DataGridView();
            this.lbSoDonNhap = new System.Windows.Forms.Label();
            this.txtSNH = new System.Windows.Forms.TextBox();
            this.lbNgayNhapp = new System.Windows.Forms.Label();
            this.lbNguoiNhap = new System.Windows.Forms.Label();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.lbNXB = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.btnXoaCTDN = new System.Windows.Forms.Button();
            this.btnSuaCTDN = new System.Windows.Forms.Button();
            this.btnTimCTDN = new System.Windows.Forms.Button();
            this.btnThemCTDN = new System.Windows.Forms.Button();
            this.ccbSachNhap = new System.Windows.Forms.ComboBox();
            this.lbSachCT = new System.Windows.Forms.Label();
            this.lbSLNhap = new System.Windows.Forms.Label();
            this.lbGiaNhap = new System.Windows.Forms.Label();
            this.tbGiaNhap = new System.Windows.Forms.MaskedTextBox();
            this.tbSLNhap = new System.Windows.Forms.MaskedTextBox();
            this.txtNgayLap = new System.Windows.Forms.MaskedTextBox();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTNhapHang
            // 
            this.dgvCTNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTNhapHang.Location = new System.Drawing.Point(46, 93);
            this.dgvCTNhapHang.Name = "dgvCTNhapHang";
            this.dgvCTNhapHang.ReadOnly = true;
            this.dgvCTNhapHang.RowHeadersWidth = 51;
            this.dgvCTNhapHang.RowTemplate.Height = 24;
            this.dgvCTNhapHang.Size = new System.Drawing.Size(703, 263);
            this.dgvCTNhapHang.TabIndex = 0;
            this.dgvCTNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTNhapHang_CellClick);
            // 
            // lbSoDonNhap
            // 
            this.lbSoDonNhap.AutoSize = true;
            this.lbSoDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSoDonNhap.Location = new System.Drawing.Point(52, 14);
            this.lbSoDonNhap.Name = "lbSoDonNhap";
            this.lbSoDonNhap.Size = new System.Drawing.Size(176, 20);
            this.lbSoDonNhap.TabIndex = 1;
            this.lbSoDonNhap.Text = "Xem chi tiết đơn nhập:";
            // 
            // txtSNH
            // 
            this.txtSNH.Location = new System.Drawing.Point(253, 12);
            this.txtSNH.Name = "txtSNH";
            this.txtSNH.ReadOnly = true;
            this.txtSNH.Size = new System.Drawing.Size(66, 22);
            this.txtSNH.TabIndex = 2;
            // 
            // lbNgayNhapp
            // 
            this.lbNgayNhapp.AutoSize = true;
            this.lbNgayNhapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNgayNhapp.Location = new System.Drawing.Point(400, 16);
            this.lbNgayNhapp.Name = "lbNgayNhapp";
            this.lbNgayNhapp.Size = new System.Drawing.Size(93, 20);
            this.lbNgayNhapp.TabIndex = 4;
            this.lbNgayNhapp.Text = "Ngày nhập:";
            // 
            // lbNguoiNhap
            // 
            this.lbNguoiNhap.AutoSize = true;
            this.lbNguoiNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNguoiNhap.Location = new System.Drawing.Point(51, 52);
            this.lbNguoiNhap.Name = "lbNguoiNhap";
            this.lbNguoiNhap.Size = new System.Drawing.Size(84, 20);
            this.lbNguoiNhap.TabIndex = 6;
            this.lbNguoiNhap.Text = "Người lập:";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(147, 51);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.ReadOnly = true;
            this.txtNguoiLap.Size = new System.Drawing.Size(209, 22);
            this.txtNguoiLap.TabIndex = 7;
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNXB.Location = new System.Drawing.Point(400, 51);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(112, 20);
            this.lbNXB.TabIndex = 8;
            this.lbNXB.Text = "Nhà xuất bản:";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(535, 52);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.ReadOnly = true;
            this.txtNXB.Size = new System.Drawing.Size(214, 22);
            this.txtNXB.TabIndex = 9;
            // 
            // btnXoaCTDN
            // 
            this.btnXoaCTDN.Enabled = false;
            this.btnXoaCTDN.Location = new System.Drawing.Point(579, 415);
            this.btnXoaCTDN.Name = "btnXoaCTDN";
            this.btnXoaCTDN.Size = new System.Drawing.Size(75, 23);
            this.btnXoaCTDN.TabIndex = 17;
            this.btnXoaCTDN.Text = "Xoá";
            this.btnXoaCTDN.UseVisualStyleBackColor = true;
            this.btnXoaCTDN.Click += new System.EventHandler(this.btnXoaCTDN_Click);
            // 
            // btnSuaCTDN
            // 
            this.btnSuaCTDN.Enabled = false;
            this.btnSuaCTDN.Location = new System.Drawing.Point(437, 415);
            this.btnSuaCTDN.Name = "btnSuaCTDN";
            this.btnSuaCTDN.Size = new System.Drawing.Size(75, 23);
            this.btnSuaCTDN.TabIndex = 16;
            this.btnSuaCTDN.Text = "Sửa";
            this.btnSuaCTDN.UseVisualStyleBackColor = true;
            this.btnSuaCTDN.Click += new System.EventHandler(this.btnSuaCTDN_Click);
            // 
            // btnTimCTDN
            // 
            this.btnTimCTDN.Location = new System.Drawing.Point(292, 415);
            this.btnTimCTDN.Name = "btnTimCTDN";
            this.btnTimCTDN.Size = new System.Drawing.Size(75, 23);
            this.btnTimCTDN.TabIndex = 15;
            this.btnTimCTDN.Text = "Tìm";
            this.btnTimCTDN.UseVisualStyleBackColor = true;
            this.btnTimCTDN.Click += new System.EventHandler(this.btnTimCTDN_Click);
            // 
            // btnThemCTDN
            // 
            this.btnThemCTDN.Enabled = false;
            this.btnThemCTDN.Location = new System.Drawing.Point(147, 415);
            this.btnThemCTDN.Name = "btnThemCTDN";
            this.btnThemCTDN.Size = new System.Drawing.Size(75, 23);
            this.btnThemCTDN.TabIndex = 14;
            this.btnThemCTDN.Text = "Thêm";
            this.btnThemCTDN.UseVisualStyleBackColor = true;
            this.btnThemCTDN.Click += new System.EventHandler(this.btnThemCTDN_Click);
            // 
            // ccbSachNhap
            // 
            this.ccbSachNhap.FormattingEnabled = true;
            this.ccbSachNhap.Location = new System.Drawing.Point(162, 374);
            this.ccbSachNhap.Name = "ccbSachNhap";
            this.ccbSachNhap.Size = new System.Drawing.Size(205, 24);
            this.ccbSachNhap.TabIndex = 18;
            // 
            // lbSachCT
            // 
            this.lbSachCT.AutoSize = true;
            this.lbSachCT.Location = new System.Drawing.Point(77, 377);
            this.lbSachCT.Name = "lbSachCT";
            this.lbSachCT.Size = new System.Drawing.Size(79, 17);
            this.lbSachCT.TabIndex = 21;
            this.lbSachCT.Text = "Chọn sách:";
            // 
            // lbSLNhap
            // 
            this.lbSLNhap.AutoSize = true;
            this.lbSLNhap.Location = new System.Drawing.Point(382, 376);
            this.lbSLNhap.Name = "lbSLNhap";
            this.lbSLNhap.Size = new System.Drawing.Size(68, 17);
            this.lbSLNhap.TabIndex = 22;
            this.lbSLNhap.Text = "Số lượng:";
            // 
            // lbGiaNhap
            // 
            this.lbGiaNhap.AutoSize = true;
            this.lbGiaNhap.Location = new System.Drawing.Point(554, 377);
            this.lbGiaNhap.Name = "lbGiaNhap";
            this.lbGiaNhap.Size = new System.Drawing.Size(70, 17);
            this.lbGiaNhap.TabIndex = 23;
            this.lbGiaNhap.Text = "Giá nhập:";
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Location = new System.Drawing.Point(624, 374);
            this.tbGiaNhap.Mask = "0000###";
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(100, 22);
            this.tbGiaNhap.TabIndex = 24;
            // 
            // tbSLNhap
            // 
            this.tbSLNhap.Location = new System.Drawing.Point(452, 374);
            this.tbSLNhap.Mask = "0###";
            this.tbSLNhap.Name = "tbSLNhap";
            this.tbSLNhap.Size = new System.Drawing.Size(51, 22);
            this.tbSLNhap.TabIndex = 25;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(511, 14);
            this.txtNgayLap.Mask = "00/00/0000";
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(125, 22);
            this.txtNgayLap.TabIndex = 26;
            this.txtNgayLap.ValidatingType = typeof(System.DateTime);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(724, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 33);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // ChiTietNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.tbSLNhap);
            this.Controls.Add(this.tbGiaNhap);
            this.Controls.Add(this.lbGiaNhap);
            this.Controls.Add(this.lbSLNhap);
            this.Controls.Add(this.lbSachCT);
            this.Controls.Add(this.ccbSachNhap);
            this.Controls.Add(this.btnXoaCTDN);
            this.Controls.Add(this.btnSuaCTDN);
            this.Controls.Add(this.btnTimCTDN);
            this.Controls.Add(this.btnThemCTDN);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.lbNXB);
            this.Controls.Add(this.txtNguoiLap);
            this.Controls.Add(this.lbNguoiNhap);
            this.Controls.Add(this.lbNgayNhapp);
            this.Controls.Add(this.txtSNH);
            this.Controls.Add(this.lbSoDonNhap);
            this.Controls.Add(this.dgvCTNhapHang);
            this.Name = "ChiTietNhapHang";
            this.Text = "Chi Tiết Nhập Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietNhapHang_FormClosing);
            this.Load += new System.EventHandler(this.ChiTietNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTNhapHang;
        private System.Windows.Forms.Label lbSoDonNhap;
        private System.Windows.Forms.TextBox txtSNH;
        private System.Windows.Forms.Label lbNgayNhapp;
        private System.Windows.Forms.Label lbNguoiNhap;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Button btnXoaCTDN;
        private System.Windows.Forms.Button btnSuaCTDN;
        private System.Windows.Forms.Button btnTimCTDN;
        private System.Windows.Forms.Button btnThemCTDN;
        private System.Windows.Forms.ComboBox ccbSachNhap;
        private System.Windows.Forms.Label lbSachCT;
        private System.Windows.Forms.Label lbSLNhap;
        private System.Windows.Forms.Label lbGiaNhap;
        private System.Windows.Forms.MaskedTextBox tbGiaNhap;
        private System.Windows.Forms.MaskedTextBox tbSLNhap;
        private System.Windows.Forms.MaskedTextBox txtNgayLap;
        private System.Windows.Forms.Button btnReload;
    }
}