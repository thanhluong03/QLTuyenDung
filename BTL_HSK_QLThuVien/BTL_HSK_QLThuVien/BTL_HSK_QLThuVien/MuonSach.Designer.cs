namespace BTL_HSK_QLThuVien
{
    partial class MuonSach
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
            this.label_1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_mamuon = new System.Windows.Forms.TextBox();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.label_3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.dgv_muonsach = new System.Windows.Forms.DataGridView();
            this.iMaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTongTienMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.tb_tongtienmuon = new System.Windows.Forms.TextBox();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_inbc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_masv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muonsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(19, 26);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(51, 13);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "Mã mượn";
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_them.Location = new System.Drawing.Point(22, 154);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_mamuon
            // 
            this.tb_mamuon.Location = new System.Drawing.Point(117, 23);
            this.tb_mamuon.Name = "tb_mamuon";
            this.tb_mamuon.Size = new System.Drawing.Size(180, 20);
            this.tb_mamuon.TabIndex = 2;
            this.tb_mamuon.TextChanged += new System.EventHandler(this.tb_mamuon_TextChanged);
            this.tb_mamuon.Validating += new System.ComponentModel.CancelEventHandler(this.tb_mamuon_Validating);
            // 
            // cb_manv
            // 
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(117, 59);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(180, 21);
            this.cb_manv.TabIndex = 3;
            this.cb_manv.TextChanged += new System.EventHandler(this.cb_manv_TextChanged);
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(19, 97);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(71, 13);
            this.label_3.TabIndex = 4;
            this.label_3.Text = "Tên sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mượn sách";
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_sua.Location = new System.Drawing.Point(117, 154);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_xoa.Location = new System.Drawing.Point(222, 154);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dgv_muonsach
            // 
            this.dgv_muonsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muonsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMaMuon,
            this.sTenNV,
            this.sTenSV,
            this.dNgayMuon,
            this.sTrangThai,
            this.fTongTienMuon});
            this.dgv_muonsach.Location = new System.Drawing.Point(12, 302);
            this.dgv_muonsach.Name = "dgv_muonsach";
            this.dgv_muonsach.Size = new System.Drawing.Size(705, 150);
            this.dgv_muonsach.TabIndex = 19;
            this.dgv_muonsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_muonsach_CellContentClick);
            // 
            // iMaMuon
            // 
            this.iMaMuon.DataPropertyName = "iMaMuon";
            this.iMaMuon.HeaderText = "Mã mượn";
            this.iMaMuon.Name = "iMaMuon";
            this.iMaMuon.ReadOnly = true;
            // 
            // sTenNV
            // 
            this.sTenNV.DataPropertyName = "sTenNV";
            this.sTenNV.HeaderText = "Tên nhân viên";
            this.sTenNV.MinimumWidth = 7;
            this.sTenNV.Name = "sTenNV";
            this.sTenNV.ReadOnly = true;
            this.sTenNV.Width = 101;
            // 
            // sTenSV
            // 
            this.sTenSV.DataPropertyName = "sTenSV";
            this.sTenSV.HeaderText = "Tên sinh viên";
            this.sTenSV.MinimumWidth = 10;
            this.sTenSV.Name = "sTenSV";
            this.sTenSV.ReadOnly = true;
            this.sTenSV.Width = 115;
            // 
            // dNgayMuon
            // 
            this.dNgayMuon.DataPropertyName = "dNgayMuon";
            this.dNgayMuon.HeaderText = "Ngày mượn";
            this.dNgayMuon.Name = "dNgayMuon";
            this.dNgayMuon.ReadOnly = true;
            // 
            // sTrangThai
            // 
            this.sTrangThai.DataPropertyName = "sTrangThai";
            this.sTrangThai.HeaderText = "Trạng thái";
            this.sTrangThai.Name = "sTrangThai";
            this.sTrangThai.ReadOnly = true;
            // 
            // fTongTienMuon
            // 
            this.fTongTienMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fTongTienMuon.DataPropertyName = "fTongTienMuon";
            this.fTongTienMuon.HeaderText = "Tổng tiền mượn";
            this.fTongTienMuon.Name = "fTongTienMuon";
            this.fTongTienMuon.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(35, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 162);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách mượn sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tiền mượn";
            // 
            // dtp_ngaymuon
            // 
            this.dtp_ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaymuon.Location = new System.Drawing.Point(435, 23);
            this.dtp_ngaymuon.Name = "dtp_ngaymuon";
            this.dtp_ngaymuon.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaymuon.TabIndex = 9;
            // 
            // tb_tongtienmuon
            // 
            this.tb_tongtienmuon.Location = new System.Drawing.Point(435, 94);
            this.tb_tongtienmuon.Name = "tb_tongtienmuon";
            this.tb_tongtienmuon.Size = new System.Drawing.Size(200, 20);
            this.tb_tongtienmuon.TabIndex = 12;
            this.tb_tongtienmuon.TextChanged += new System.EventHandler(this.tb_tongtienmuon_TextChanged);
            this.tb_tongtienmuon.Validating += new System.ComponentModel.CancelEventHandler(this.tb_tongtienmuon_Validating);
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Items.AddRange(new object[] {
            "Đã Mượn",
            "Chưa Mượn"});
            this.cb_trangthai.Location = new System.Drawing.Point(435, 59);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(200, 21);
            this.cb_trangthai.TabIndex = 13;
            // 
            // btn_boqua
            // 
            this.btn_boqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_boqua.Location = new System.Drawing.Point(455, 154);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(75, 23);
            this.btn_boqua.TabIndex = 16;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_timkiem.Location = new System.Drawing.Point(346, 154);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 17;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_inbc
            // 
            this.btn_inbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_inbc.Location = new System.Drawing.Point(560, 154);
            this.btn_inbc.Name = "btn_inbc";
            this.btn_inbc.Size = new System.Drawing.Size(75, 23);
            this.btn_inbc.TabIndex = 18;
            this.btn_inbc.Text = "In báo cáo";
            this.btn_inbc.UseVisualStyleBackColor = true;
            this.btn_inbc.Click += new System.EventHandler(this.btn_inbc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_masv);
            this.groupBox2.Controls.Add(this.btn_inbc);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.btn_boqua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.cb_trangthai);
            this.groupBox2.Controls.Add(this.tb_tongtienmuon);
            this.groupBox2.Controls.Add(this.dtp_ngaymuon);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_3);
            this.groupBox2.Controls.Add(this.cb_manv);
            this.groupBox2.Controls.Add(this.tb_mamuon);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.label_1);
            this.groupBox2.Location = new System.Drawing.Point(35, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 206);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mượn sách";
            // 
            // cb_masv
            // 
            this.cb_masv.FormattingEnabled = true;
            this.cb_masv.Location = new System.Drawing.Point(117, 94);
            this.cb_masv.Name = "cb_masv";
            this.cb_masv.Size = new System.Drawing.Size(180, 21);
            this.cb_masv.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_muonsach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muon sach";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muonsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tb_mamuon;
        private System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridView dgv_muonsach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ngaymuon;
        private System.Windows.Forms.TextBox tb_tongtienmuon;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_inbc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTongTienMuon;
    }
}

