
namespace BTL_HSK_QLBanSach
{
    partial class TimKiemHoaDon
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
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtngaylap = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrhoadon = new System.Windows.Forms.DataGridView();
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.rdsohd = new System.Windows.Forms.RadioButton();
            this.rdnhanvien = new System.Windows.Forms.RadioButton();
            this.rdkhachhang = new System.Windows.Forms.RadioButton();
            this.rdngaylap = new System.Windows.Forms.RadioButton();
            this.rdhienthitoanbo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(313, 356);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(174, 24);
            this.cbnhanvien.TabIndex = 43;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(946, 493);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 27);
            this.btnthoat.TabIndex = 40;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtngaylap
            // 
            this.txtngaylap.Location = new System.Drawing.Point(313, 443);
            this.txtngaylap.Name = "txtngaylap";
            this.txtngaylap.Size = new System.Drawing.Size(121, 22);
            this.txtngaylap.TabIndex = 33;
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(313, 319);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(121, 22);
            this.txtsohd.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh Sách Hóa Đơn";
            // 
            // dgrhoadon
            // 
            this.dgrhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrhoadon.Location = new System.Drawing.Point(67, 58);
            this.dgrhoadon.Name = "dgrhoadon";
            this.dgrhoadon.RowHeadersWidth = 51;
            this.dgrhoadon.RowTemplate.Height = 24;
            this.dgrhoadon.Size = new System.Drawing.Size(930, 190);
            this.dgrhoadon.TabIndex = 23;
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(313, 399);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(174, 24);
            this.cbkhachhang.TabIndex = 44;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(852, 291);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(104, 36);
            this.btntimkiem.TabIndex = 37;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // rdsohd
            // 
            this.rdsohd.AutoSize = true;
            this.rdsohd.Location = new System.Drawing.Point(67, 319);
            this.rdsohd.Name = "rdsohd";
            this.rdsohd.Size = new System.Drawing.Size(192, 21);
            this.rdsohd.TabIndex = 45;
            this.rdsohd.TabStop = true;
            this.rdsohd.Text = "Tìm kiếm theo số hóa đơn";
            this.rdsohd.UseVisualStyleBackColor = true;
            this.rdsohd.CheckedChanged += new System.EventHandler(this.rdsohd_CheckedChanged);
            // 
            // rdnhanvien
            // 
            this.rdnhanvien.AutoSize = true;
            this.rdnhanvien.Location = new System.Drawing.Point(67, 357);
            this.rdnhanvien.Name = "rdnhanvien";
            this.rdnhanvien.Size = new System.Drawing.Size(207, 21);
            this.rdnhanvien.TabIndex = 46;
            this.rdnhanvien.TabStop = true;
            this.rdnhanvien.Text = "Tìm kiếm theo tên nhân viên";
            this.rdnhanvien.UseVisualStyleBackColor = true;
            this.rdnhanvien.CheckedChanged += new System.EventHandler(this.rdnhanvien_CheckedChanged);
            // 
            // rdkhachhang
            // 
            this.rdkhachhang.AutoSize = true;
            this.rdkhachhang.Location = new System.Drawing.Point(67, 402);
            this.rdkhachhang.Name = "rdkhachhang";
            this.rdkhachhang.Size = new System.Drawing.Size(219, 21);
            this.rdkhachhang.TabIndex = 47;
            this.rdkhachhang.TabStop = true;
            this.rdkhachhang.Text = "Tìm kiếm theo tên khách hàng";
            this.rdkhachhang.UseVisualStyleBackColor = true;
            this.rdkhachhang.CheckedChanged += new System.EventHandler(this.rdkhachhang_CheckedChanged);
            // 
            // rdngaylap
            // 
            this.rdngaylap.AutoSize = true;
            this.rdngaylap.Location = new System.Drawing.Point(67, 443);
            this.rdngaylap.Name = "rdngaylap";
            this.rdngaylap.Size = new System.Drawing.Size(175, 21);
            this.rdngaylap.TabIndex = 48;
            this.rdngaylap.TabStop = true;
            this.rdngaylap.Text = "Tìm kiếm theo ngày lập";
            this.rdngaylap.UseVisualStyleBackColor = true;
            this.rdngaylap.CheckedChanged += new System.EventHandler(this.rdngaylap_CheckedChanged);
            // 
            // rdhienthitoanbo
            // 
            this.rdhienthitoanbo.AutoSize = true;
            this.rdhienthitoanbo.Location = new System.Drawing.Point(67, 281);
            this.rdhienthitoanbo.Name = "rdhienthitoanbo";
            this.rdhienthitoanbo.Size = new System.Drawing.Size(199, 21);
            this.rdhienthitoanbo.TabIndex = 49;
            this.rdhienthitoanbo.TabStop = true;
            this.rdhienthitoanbo.Text = "Hiển thị toàn bộ danh sách";
            this.rdhienthitoanbo.UseVisualStyleBackColor = true;
            // 
            // TimKiemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 548);
            this.Controls.Add(this.rdhienthitoanbo);
            this.Controls.Add(this.rdngaylap);
            this.Controls.Add(this.rdkhachhang);
            this.Controls.Add(this.rdnhanvien);
            this.Controls.Add(this.rdsohd);
            this.Controls.Add(this.cbkhachhang);
            this.Controls.Add(this.cbnhanvien);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txtngaylap);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrhoadon);
            this.Name = "TimKiemHoaDon";
            this.Text = "TimKiemHoaDon";
            this.Load += new System.EventHandler(this.TimKiemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtngaylap;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrhoadon;
        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.RadioButton rdsohd;
        private System.Windows.Forms.RadioButton rdnhanvien;
        private System.Windows.Forms.RadioButton rdkhachhang;
        private System.Windows.Forms.RadioButton rdngaylap;
        private System.Windows.Forms.RadioButton rdhienthitoanbo;
    }
}