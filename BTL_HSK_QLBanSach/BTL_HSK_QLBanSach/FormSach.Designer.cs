namespace BTL_HSK_QLBanSach
{
    partial class FormSach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.PnChucNang = new System.Windows.Forms.Panel();
            this.btnChonKhoangGia = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.cmbTheLoai = new System.Windows.Forms.ComboBox();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nmrDonGia = new System.Windows.Forms.NumericUpDown();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.PnChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 82;
            this.dgvSach.RowTemplate.Height = 33;
            this.dgvSach.Size = new System.Drawing.Size(1210, 397);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // PnChucNang
            // 
            this.PnChucNang.Controls.Add(this.btnChonKhoangGia);
            this.PnChucNang.Controls.Add(this.btnTim);
            this.PnChucNang.Controls.Add(this.btnSua);
            this.PnChucNang.Controls.Add(this.btnXoa);
            this.PnChucNang.Controls.Add(this.btnThem);
            this.PnChucNang.Controls.Add(this.cmbNhaXuatBan);
            this.PnChucNang.Controls.Add(this.cmbTheLoai);
            this.PnChucNang.Controls.Add(this.nmrSoLuong);
            this.PnChucNang.Controls.Add(this.nmrDonGia);
            this.PnChucNang.Controls.Add(this.txtTacGia);
            this.PnChucNang.Controls.Add(this.txtTenSach);
            this.PnChucNang.Controls.Add(this.txtMaSach);
            this.PnChucNang.Controls.Add(this.lblDonGia);
            this.PnChucNang.Controls.Add(this.lblSoLuong);
            this.PnChucNang.Controls.Add(this.lblTacGia);
            this.PnChucNang.Controls.Add(this.lblTenSach);
            this.PnChucNang.Controls.Add(this.lblTheLoai);
            this.PnChucNang.Controls.Add(this.lblNhaXuatBan);
            this.PnChucNang.Controls.Add(this.lblMaSach);
            this.PnChucNang.Location = new System.Drawing.Point(0, 414);
            this.PnChucNang.Margin = new System.Windows.Forms.Padding(2);
            this.PnChucNang.Name = "PnChucNang";
            this.PnChucNang.Size = new System.Drawing.Size(1079, 167);
            this.PnChucNang.TabIndex = 1;
            // 
            // btnChonKhoangGia
            // 
            this.btnChonKhoangGia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChonKhoangGia.Location = new System.Drawing.Point(754, 113);
            this.btnChonKhoangGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonKhoangGia.Name = "btnChonKhoangGia";
            this.btnChonKhoangGia.Size = new System.Drawing.Size(139, 38);
            this.btnChonKhoangGia.TabIndex = 18;
            this.btnChonKhoangGia.Text = "Chọn khoảng giá";
            this.btnChonKhoangGia.UseVisualStyleBackColor = false;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTim.Location = new System.Drawing.Point(618, 113);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(84, 38);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSua.Location = new System.Drawing.Point(336, 113);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 38);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoa.Location = new System.Drawing.Point(480, 113);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 38);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThem.Location = new System.Drawing.Point(195, 113);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 38);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbNhaXuatBan
            // 
            this.cmbNhaXuatBan.FormattingEnabled = true;
            this.cmbNhaXuatBan.Location = new System.Drawing.Point(933, 12);
            this.cmbNhaXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNhaXuatBan.Name = "cmbNhaXuatBan";
            this.cmbNhaXuatBan.Size = new System.Drawing.Size(139, 24);
            this.cmbNhaXuatBan.TabIndex = 13;
            this.cmbNhaXuatBan.SelectedIndexChanged += new System.EventHandler(this.cmbNhaXuatBan_SelectedIndexChanged);
            // 
            // cmbTheLoai
            // 
            this.cmbTheLoai.FormattingEnabled = true;
            this.cmbTheLoai.Location = new System.Drawing.Point(682, 13);
            this.cmbTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTheLoai.Name = "cmbTheLoai";
            this.cmbTheLoai.Size = new System.Drawing.Size(139, 24);
            this.cmbTheLoai.TabIndex = 12;
            this.cmbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cmbTheLoai_SelectedIndexChanged_1);
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(773, 76);
            this.nmrSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.nmrSoLuong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(139, 22);
            this.nmrSoLuong.TabIndex = 11;
            // 
            // nmrDonGia
            // 
            this.nmrDonGia.Location = new System.Drawing.Point(524, 76);
            this.nmrDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.nmrDonGia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrDonGia.Name = "nmrDonGia";
            this.nmrDonGia.Size = new System.Drawing.Size(141, 22);
            this.nmrDonGia.TabIndex = 10;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(207, 72);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(229, 22);
            this.txtTacGia.TabIndex = 9;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(343, 15);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(261, 22);
            this.txtTenSach.TabIndex = 8;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(137, 13);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(117, 22);
            this.txtMaSach.TabIndex = 7;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(450, 76);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(61, 17);
            this.lblDonGia.TabIndex = 6;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(691, 77);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(68, 17);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(144, 72);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(59, 17);
            this.lblTacGia.TabIndex = 4;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(267, 17);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(71, 17);
            this.lblTenSach.TabIndex = 3;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(615, 17);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(63, 17);
            this.lblTheLoai.TabIndex = 2;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Location = new System.Drawing.Point(831, 15);
            this.lblNhaXuatBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(96, 17);
            this.lblNhaXuatBan.TabIndex = 1;
            this.lblNhaXuatBan.Text = "Nhà xuất bản:";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(66, 15);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(65, 17);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // errLoi
            // 
            this.errLoi.ContainerControl = this;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 589);
            this.Controls.Add(this.PnChucNang);
            this.Controls.Add(this.dgvSach);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSach";
            this.Text = "Quản Lí Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSach_FormClosing);
            this.Load += new System.EventHandler(this.FormSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.PnChucNang.ResumeLayout(false);
            this.PnChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Panel PnChucNang;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cmbNhaXuatBan;
        private System.Windows.Forms.ComboBox cmbTheLoai;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.NumericUpDown nmrDonGia;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ErrorProvider errLoi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnChonKhoangGia;
    }
}