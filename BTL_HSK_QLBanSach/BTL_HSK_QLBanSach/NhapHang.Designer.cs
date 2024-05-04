namespace BTL_HSK_QLBanSach
{
    partial class NhapHang
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
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.lbNhapHang = new System.Windows.Forms.Label();
            this.lbSoDN = new System.Windows.Forms.Label();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.lbNguoiNhap = new System.Windows.Forms.Label();
            this.lbNXB = new System.Windows.Forms.Label();
            this.tbSoDN = new System.Windows.Forms.MaskedTextBox();
            this.tbNgayNhap = new System.Windows.Forms.MaskedTextBox();
            this.ccbNhanVien = new System.Windows.Forms.ComboBox();
            this.ccbNXB = new System.Windows.Forms.ComboBox();
            this.btnThemDN = new System.Windows.Forms.Button();
            this.btnTimDN = new System.Windows.Forms.Button();
            this.btnSuaDN = new System.Windows.Forms.Button();
            this.btnXoaDN = new System.Windows.Forms.Button();
            this.btnXemCTDN = new System.Windows.Forms.Button();
            this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Location = new System.Drawing.Point(41, 44);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowHeadersWidth = 51;
            this.dgvNhapHang.RowTemplate.Height = 24;
            this.dgvNhapHang.Size = new System.Drawing.Size(716, 298);
            this.dgvNhapHang.TabIndex = 0;
            this.dgvNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellClick);
            // 
            // lbNhapHang
            // 
            this.lbNhapHang.AutoSize = true;
            this.lbNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNhapHang.Location = new System.Drawing.Point(35, 13);
            this.lbNhapHang.Name = "lbNhapHang";
            this.lbNhapHang.Size = new System.Drawing.Size(142, 20);
            this.lbNhapHang.TabIndex = 1;
            this.lbNhapHang.Text = "Bảng Nhập Hàng:";
            // 
            // lbSoDN
            // 
            this.lbSoDN.AutoSize = true;
            this.lbSoDN.Location = new System.Drawing.Point(86, 365);
            this.lbSoDN.Name = "lbSoDN";
            this.lbSoDN.Size = new System.Drawing.Size(93, 17);
            this.lbSoDN.TabIndex = 2;
            this.lbSoDN.Text = "Số đơn nhập:";
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.Location = new System.Drawing.Point(89, 399);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(81, 17);
            this.lbNgayNhap.TabIndex = 3;
            this.lbNgayNhap.Text = "Ngày nhập:";
            // 
            // lbNguoiNhap
            // 
            this.lbNguoiNhap.AutoSize = true;
            this.lbNguoiNhap.Location = new System.Drawing.Point(382, 365);
            this.lbNguoiNhap.Name = "lbNguoiNhap";
            this.lbNguoiNhap.Size = new System.Drawing.Size(127, 17);
            this.lbNguoiNhap.TabIndex = 4;
            this.lbNguoiNhap.Text = "Nhân viên lập đơn:";
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Location = new System.Drawing.Point(385, 399);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(96, 17);
            this.lbNXB.TabIndex = 5;
            this.lbNXB.Text = "Nhà xuất bản:";
            // 
            // tbSoDN
            // 
            this.tbSoDN.Location = new System.Drawing.Point(190, 362);
            this.tbSoDN.Mask = "0####";
            this.tbSoDN.Name = "tbSoDN";
            this.tbSoDN.Size = new System.Drawing.Size(100, 22);
            this.tbSoDN.TabIndex = 6;
            this.tbSoDN.Validating += new System.ComponentModel.CancelEventHandler(this.tbSoDN_Validating);
            // 
            // tbNgayNhap
            // 
            this.tbNgayNhap.Location = new System.Drawing.Point(190, 396);
            this.tbNgayNhap.Mask = "00/00/0000";
            this.tbNgayNhap.Name = "tbNgayNhap";
            this.tbNgayNhap.Size = new System.Drawing.Size(100, 22);
            this.tbNgayNhap.TabIndex = 7;
            this.tbNgayNhap.ValidatingType = typeof(System.DateTime);
            this.tbNgayNhap.Validating += new System.ComponentModel.CancelEventHandler(this.tbNgayNhap_Validating);
            // 
            // ccbNhanVien
            // 
            this.ccbNhanVien.FormattingEnabled = true;
            this.ccbNhanVien.Location = new System.Drawing.Point(506, 362);
            this.ccbNhanVien.Name = "ccbNhanVien";
            this.ccbNhanVien.Size = new System.Drawing.Size(208, 24);
            this.ccbNhanVien.TabIndex = 8;
            // 
            // ccbNXB
            // 
            this.ccbNXB.FormattingEnabled = true;
            this.ccbNXB.Location = new System.Drawing.Point(506, 393);
            this.ccbNXB.Name = "ccbNXB";
            this.ccbNXB.Size = new System.Drawing.Size(208, 24);
            this.ccbNXB.TabIndex = 9;
            // 
            // btnThemDN
            // 
            this.btnThemDN.Location = new System.Drawing.Point(53, 432);
            this.btnThemDN.Name = "btnThemDN";
            this.btnThemDN.Size = new System.Drawing.Size(75, 23);
            this.btnThemDN.TabIndex = 10;
            this.btnThemDN.Text = "Thêm";
            this.btnThemDN.UseVisualStyleBackColor = true;
            this.btnThemDN.Click += new System.EventHandler(this.btnThemDN_Click);
            // 
            // btnTimDN
            // 
            this.btnTimDN.Location = new System.Drawing.Point(198, 432);
            this.btnTimDN.Name = "btnTimDN";
            this.btnTimDN.Size = new System.Drawing.Size(75, 23);
            this.btnTimDN.TabIndex = 11;
            this.btnTimDN.Text = "Tìm";
            this.btnTimDN.UseVisualStyleBackColor = true;
            this.btnTimDN.Click += new System.EventHandler(this.btnTimDN_Click);
            // 
            // btnSuaDN
            // 
            this.btnSuaDN.Enabled = false;
            this.btnSuaDN.Location = new System.Drawing.Point(343, 432);
            this.btnSuaDN.Name = "btnSuaDN";
            this.btnSuaDN.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDN.TabIndex = 12;
            this.btnSuaDN.Text = "Sửa";
            this.btnSuaDN.UseVisualStyleBackColor = true;
            this.btnSuaDN.Click += new System.EventHandler(this.btnSuaDN_Click);
            // 
            // btnXoaDN
            // 
            this.btnXoaDN.Enabled = false;
            this.btnXoaDN.Location = new System.Drawing.Point(485, 432);
            this.btnXoaDN.Name = "btnXoaDN";
            this.btnXoaDN.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDN.TabIndex = 13;
            this.btnXoaDN.Text = "Xoá";
            this.btnXoaDN.UseVisualStyleBackColor = true;
            this.btnXoaDN.Click += new System.EventHandler(this.btnXoaDN_Click);
            // 
            // btnXemCTDN
            // 
            this.btnXemCTDN.Enabled = false;
            this.btnXemCTDN.Location = new System.Drawing.Point(640, 432);
            this.btnXemCTDN.Name = "btnXemCTDN";
            this.btnXemCTDN.Size = new System.Drawing.Size(106, 23);
            this.btnXemCTDN.TabIndex = 14;
            this.btnXemCTDN.Text = "Xem chi tiết";
            this.btnXemCTDN.UseVisualStyleBackColor = true;
            this.btnXemCTDN.Click += new System.EventHandler(this.btnXemCTDN_Click);
            // 
            // errLoi
            // 
            this.errLoi.ContainerControl = this;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(712, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 33);
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 467);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnXemCTDN);
            this.Controls.Add(this.btnXoaDN);
            this.Controls.Add(this.btnSuaDN);
            this.Controls.Add(this.btnTimDN);
            this.Controls.Add(this.btnThemDN);
            this.Controls.Add(this.ccbNXB);
            this.Controls.Add(this.ccbNhanVien);
            this.Controls.Add(this.tbNgayNhap);
            this.Controls.Add(this.tbSoDN);
            this.Controls.Add(this.lbNXB);
            this.Controls.Add(this.lbNguoiNhap);
            this.Controls.Add(this.lbNgayNhap);
            this.Controls.Add(this.lbSoDN);
            this.Controls.Add(this.lbNhapHang);
            this.Controls.Add(this.dgvNhapHang);
            this.Name = "NhapHang";
            this.Text = "Quản Lí Nhập Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhapHang_FormClosing);
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.Label lbNhapHang;
        private System.Windows.Forms.Label lbSoDN;
        private System.Windows.Forms.Label lbNgayNhap;
        private System.Windows.Forms.Label lbNguoiNhap;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.MaskedTextBox tbSoDN;
        private System.Windows.Forms.MaskedTextBox tbNgayNhap;
        private System.Windows.Forms.ComboBox ccbNhanVien;
        private System.Windows.Forms.ComboBox ccbNXB;
        private System.Windows.Forms.Button btnThemDN;
        private System.Windows.Forms.Button btnTimDN;
        private System.Windows.Forms.Button btnSuaDN;
        private System.Windows.Forms.Button btnXoaDN;
        private System.Windows.Forms.Button btnXemCTDN;
        private System.Windows.Forms.ErrorProvider errLoi;
        private System.Windows.Forms.Button btnReload;
    }
}