
namespace BTL_HSK_QLBanSach
{
    partial class HoaDon
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
            this.dgrhoadon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbngaylap = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrhoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrhoadon
            // 
            this.dgrhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrhoadon.Location = new System.Drawing.Point(147, 301);
            this.dgrhoadon.Name = "dgrhoadon";
            this.dgrhoadon.ReadOnly = true;
            this.dgrhoadon.RowHeadersWidth = 51;
            this.dgrhoadon.RowTemplate.Height = 24;
            this.dgrhoadon.Size = new System.Drawing.Size(930, 223);
            this.dgrhoadon.TabIndex = 12;
            this.dgrhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgHoaDon_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số HD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(794, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1009, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng Tiền";
            // 
            // txtsohd
            // 
            this.txtsohd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsohd.Location = new System.Drawing.Point(50, 77);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(74, 27);
            this.txtsohd.TabIndex = 1;
            this.txtsohd.Validating += new System.ComponentModel.CancelEventHandler(this.txtsohd_Validating);
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Location = new System.Drawing.Point(1013, 75);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(121, 27);
            this.txttongtien.TabIndex = 5;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(129, 163);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 36);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(330, 163);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 36);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(532, 163);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(102, 36);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa Số HD";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(1014, 163);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 36);
            this.btnload.TabIndex = 9;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(989, 255);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(100, 33);
            this.btnchitiet.TabIndex = 10;
            this.btnchitiet.Text = "Xem Chi Tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(1119, 515);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 27);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(196, 75);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(212, 28);
            this.cbnhanvien.TabIndex = 2;
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(495, 76);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(218, 28);
            this.cbkhachhang.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbngaylap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbkhachhang);
            this.groupBox1.Controls.Add(this.txtsohd);
            this.groupBox1.Controls.Add(this.cbnhanvien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 125);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mtbngaylap
            // 
            this.mtbngaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbngaylap.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mtbngaylap.Location = new System.Drawing.Point(798, 75);
            this.mtbngaylap.Mask = "00/00/0000";
            this.mtbngaylap.Name = "mtbngaylap";
            this.mtbngaylap.Size = new System.Drawing.Size(134, 27);
            this.mtbngaylap.TabIndex = 4;
            this.mtbngaylap.ValidatingType = typeof(System.DateTime);
            this.mtbngaylap.Validating += new System.ComponentModel.CancelEventHandler(this.mtbngaylap_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(751, 163);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(134, 36);
            this.btntimkiem.TabIndex = 24;
            this.btntimkiem.Text = "Tìm kiếm KH";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 554);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrhoadon);
            this.Name = "HoaDon";
            this.Text = "Quản Lí Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoaDon_FormClosing);
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrhoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrhoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtbngaylap;
        private System.Windows.Forms.Button btntimkiem;
    }
}