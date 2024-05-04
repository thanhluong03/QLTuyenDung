namespace BTL_HSK_QLThuVien
{
    partial class ChiTietMuonSach
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
            this.dgv_chitietmuonsach = new System.Windows.Forms.DataGridView();
            this.iMaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSoLuongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_inbc = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.tb_giamuon = new System.Windows.Forms.TextBox();
            this.tb_soluongmuon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_masv = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.cb_mamuon = new System.Windows.Forms.ComboBox();
            this.cb_masach = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietmuonsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_chitietmuonsach
            // 
            this.dgv_chitietmuonsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietmuonsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMaMuon,
            this.sTenSach,
            this.fSoLuongMuon,
            this.dNgayTra,
            this.sTrangThai,
            this.fGiaMuon});
            this.dgv_chitietmuonsach.Location = new System.Drawing.Point(66, 288);
            this.dgv_chitietmuonsach.Name = "dgv_chitietmuonsach";
            this.dgv_chitietmuonsach.Size = new System.Drawing.Size(665, 162);
            this.dgv_chitietmuonsach.TabIndex = 39;
            this.dgv_chitietmuonsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietmuonsach_CellContentClick);
            // 
            // iMaMuon
            // 
            this.iMaMuon.DataPropertyName = "iMaMuon";
            this.iMaMuon.HeaderText = "Mã mượn";
            this.iMaMuon.Name = "iMaMuon";
            this.iMaMuon.ReadOnly = true;
            // 
            // sTenSach
            // 
            this.sTenSach.DataPropertyName = "sTenSach";
            this.sTenSach.HeaderText = "Mã sách";
            this.sTenSach.Name = "sTenSach";
            this.sTenSach.ReadOnly = true;
            // 
            // fSoLuongMuon
            // 
            this.fSoLuongMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fSoLuongMuon.DataPropertyName = "fSoLuongMuon";
            this.fSoLuongMuon.HeaderText = "Số lượng mượn";
            this.fSoLuongMuon.Name = "fSoLuongMuon";
            this.fSoLuongMuon.ReadOnly = true;
            // 
            // dNgayTra
            // 
            this.dNgayTra.DataPropertyName = "dNgayTra";
            this.dNgayTra.HeaderText = "Ngày trả";
            this.dNgayTra.Name = "dNgayTra";
            this.dNgayTra.ReadOnly = true;
            // 
            // sTrangThai
            // 
            this.sTrangThai.DataPropertyName = "sTrangThai";
            this.sTrangThai.HeaderText = "Trạng thái";
            this.sTrangThai.Name = "sTrangThai";
            this.sTrangThai.ReadOnly = true;
            // 
            // fGiaMuon
            // 
            this.fGiaMuon.DataPropertyName = "fGiaMuon";
            this.fGiaMuon.HeaderText = "Giá mượn";
            this.fGiaMuon.Name = "fGiaMuon";
            this.fGiaMuon.ReadOnly = true;
            this.fGiaMuon.Width = 116;
            // 
            // btn_inbc
            // 
            this.btn_inbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_inbc.Location = new System.Drawing.Point(583, 146);
            this.btn_inbc.Name = "btn_inbc";
            this.btn_inbc.Size = new System.Drawing.Size(75, 23);
            this.btn_inbc.TabIndex = 38;
            this.btn_inbc.Text = "In báo cáo";
            this.btn_inbc.UseVisualStyleBackColor = true;
            this.btn_inbc.Click += new System.EventHandler(this.btn_inbc_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_timkiem.Location = new System.Drawing.Point(357, 146);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 37;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_boqua.Location = new System.Drawing.Point(472, 146);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(75, 23);
            this.btn_boqua.TabIndex = 36;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_xoa.Location = new System.Drawing.Point(246, 146);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 35;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_sua.Location = new System.Drawing.Point(134, 146);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 34;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Items.AddRange(new object[] {
            "Đã Trả",
            "Chưa Trả"});
            this.cb_trangthai.Location = new System.Drawing.Point(458, 51);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(200, 21);
            this.cb_trangthai.TabIndex = 33;
            // 
            // tb_giamuon
            // 
            this.tb_giamuon.Location = new System.Drawing.Point(458, 86);
            this.tb_giamuon.Name = "tb_giamuon";
            this.tb_giamuon.Size = new System.Drawing.Size(200, 20);
            this.tb_giamuon.TabIndex = 32;
            this.tb_giamuon.Validating += new System.ComponentModel.CancelEventHandler(this.tb_giamuon_Validating);
            // 
            // tb_soluongmuon
            // 
            this.tb_soluongmuon.Location = new System.Drawing.Point(119, 86);
            this.tb_soluongmuon.Name = "tb_soluongmuon";
            this.tb_soluongmuon.Size = new System.Drawing.Size(180, 20);
            this.tb_soluongmuon.TabIndex = 31;
            this.tb_soluongmuon.TextChanged += new System.EventHandler(this.tb_soluongmuon_TextChanged);
            this.tb_soluongmuon.Validating += new System.ComponentModel.CancelEventHandler(this.tb_soluongmuon_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Chi tiết mượn sách";
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaytra.Location = new System.Drawing.Point(458, 15);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaytra.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Giá mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ngày trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tên sách";
            // 
            // tb_masv
            // 
            this.tb_masv.AutoSize = true;
            this.tb_masv.Location = new System.Drawing.Point(21, 89);
            this.tb_masv.Name = "tb_masv";
            this.tb_masv.Size = new System.Drawing.Size(78, 13);
            this.tb_masv.TabIndex = 24;
            this.tb_masv.Text = "Số lượng mượn";
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_them.Location = new System.Drawing.Point(24, 146);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(21, 18);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(51, 13);
            this.label_1.TabIndex = 20;
            this.label_1.Text = "Mã mượn";
            // 
            // cb_mamuon
            // 
            this.cb_mamuon.FormattingEnabled = true;
            this.cb_mamuon.Location = new System.Drawing.Point(119, 13);
            this.cb_mamuon.Name = "cb_mamuon";
            this.cb_mamuon.Size = new System.Drawing.Size(180, 21);
            this.cb_mamuon.TabIndex = 41;
            this.cb_mamuon.TextChanged += new System.EventHandler(this.cb_mamuon_TextChanged);
            this.cb_mamuon.Validating += new System.ComponentModel.CancelEventHandler(this.cb_mamuon_Validating);
            // 
            // cb_masach
            // 
            this.cb_masach.FormattingEnabled = true;
            this.cb_masach.Location = new System.Drawing.Point(119, 51);
            this.cb_masach.Name = "cb_masach";
            this.cb_masach.Size = new System.Drawing.Size(180, 21);
            this.cb_masach.TabIndex = 42;
            this.cb_masach.TextChanged += new System.EventHandler(this.cb_masach_TextChanged);
            this.cb_masach.Validating += new System.ComponentModel.CancelEventHandler(this.cb_masach_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(50, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 185);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiết mượn sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_masach);
            this.groupBox2.Controls.Add(this.cb_mamuon);
            this.groupBox2.Controls.Add(this.btn_inbc);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.btn_boqua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.cb_trangthai);
            this.groupBox2.Controls.Add(this.tb_giamuon);
            this.groupBox2.Controls.Add(this.tb_soluongmuon);
            this.groupBox2.Controls.Add(this.dtp_ngaytra);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_masv);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.label_1);
            this.groupBox2.Location = new System.Drawing.Point(56, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 177);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết mượn sách";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_chitietmuonsach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết mượn sách";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietmuonsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chitietmuonsach;
        private System.Windows.Forms.Button btn_inbc;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.TextBox tb_giamuon;
        private System.Windows.Forms.TextBox tb_soluongmuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_ngaytra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tb_masv;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.ComboBox cb_mamuon;
        private System.Windows.Forms.ComboBox cb_masach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSoLuongMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaMuon;
    }
}