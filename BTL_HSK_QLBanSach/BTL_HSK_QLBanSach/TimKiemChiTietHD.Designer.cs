
namespace BTL_HSK_QLBanSach
{
    partial class TimKiemChiTietHD
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
            this.rdhienthitoanbo = new System.Windows.Forms.RadioButton();
            this.rdsoluong = new System.Windows.Forms.RadioButton();
            this.rdsach = new System.Windows.Forms.RadioButton();
            this.rdsohd = new System.Windows.Forms.RadioButton();
            this.cbsach = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrchitiethd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrchitiethd)).BeginInit();
            this.SuspendLayout();
            // 
            // rdhienthitoanbo
            // 
            this.rdhienthitoanbo.AutoSize = true;
            this.rdhienthitoanbo.Location = new System.Drawing.Point(83, 272);
            this.rdhienthitoanbo.Name = "rdhienthitoanbo";
            this.rdhienthitoanbo.Size = new System.Drawing.Size(199, 21);
            this.rdhienthitoanbo.TabIndex = 62;
            this.rdhienthitoanbo.TabStop = true;
            this.rdhienthitoanbo.Text = "Hiển thị toàn bộ danh sách";
            this.rdhienthitoanbo.UseVisualStyleBackColor = true;
            // 
            // rdsoluong
            // 
            this.rdsoluong.AutoSize = true;
            this.rdsoluong.Location = new System.Drawing.Point(83, 397);
            this.rdsoluong.Name = "rdsoluong";
            this.rdsoluong.Size = new System.Drawing.Size(175, 21);
            this.rdsoluong.TabIndex = 60;
            this.rdsoluong.TabStop = true;
            this.rdsoluong.Text = "Tìm kiếm theo số lượng";
            this.rdsoluong.UseVisualStyleBackColor = true;
            this.rdsoluong.CheckedChanged += new System.EventHandler(this.rdsoluong_CheckedChanged);
            // 
            // rdsach
            // 
            this.rdsach.AutoSize = true;
            this.rdsach.Location = new System.Drawing.Point(83, 356);
            this.rdsach.Name = "rdsach";
            this.rdsach.Size = new System.Drawing.Size(179, 21);
            this.rdsach.TabIndex = 59;
            this.rdsach.TabStop = true;
            this.rdsach.Text = "Tìm kiếm theo tên sách ";
            this.rdsach.UseVisualStyleBackColor = true;
            this.rdsach.CheckedChanged += new System.EventHandler(this.rdsach_CheckedChanged);
            // 
            // rdsohd
            // 
            this.rdsohd.AutoSize = true;
            this.rdsohd.Location = new System.Drawing.Point(83, 311);
            this.rdsohd.Name = "rdsohd";
            this.rdsohd.Size = new System.Drawing.Size(192, 21);
            this.rdsohd.TabIndex = 58;
            this.rdsohd.TabStop = true;
            this.rdsohd.Text = "Tìm kiếm theo số hóa đơn";
            this.rdsohd.UseVisualStyleBackColor = true;
            this.rdsohd.CheckedChanged += new System.EventHandler(this.rdsohd_CheckedChanged);
            // 
            // cbsach
            // 
            this.cbsach.FormattingEnabled = true;
            this.cbsach.Location = new System.Drawing.Point(320, 353);
            this.cbsach.Name = "cbsach";
            this.cbsach.Size = new System.Drawing.Size(202, 24);
            this.cbsach.TabIndex = 56;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(999, 489);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 27);
            this.btnthoat.TabIndex = 55;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(905, 287);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(104, 36);
            this.btntimkiem.TabIndex = 54;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(320, 397);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(121, 22);
            this.txtsoluong.TabIndex = 53;
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(320, 311);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(121, 22);
            this.txtsohd.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Danh Sách Chi Tiết Hóa Đơn";
            // 
            // dgrchitiethd
            // 
            this.dgrchitiethd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrchitiethd.Location = new System.Drawing.Point(79, 54);
            this.dgrchitiethd.Name = "dgrchitiethd";
            this.dgrchitiethd.RowHeadersWidth = 51;
            this.dgrchitiethd.RowTemplate.Height = 24;
            this.dgrchitiethd.Size = new System.Drawing.Size(930, 190);
            this.dgrchitiethd.TabIndex = 50;
           
            // 
            // TimKiemChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 544);
            this.Controls.Add(this.rdhienthitoanbo);
            this.Controls.Add(this.rdsoluong);
            this.Controls.Add(this.rdsach);
            this.Controls.Add(this.rdsohd);
            this.Controls.Add(this.cbsach);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrchitiethd);
            this.Name = "TimKiemChiTietHD";
            this.Text = "TimKiemChiTietHD";
            this.Load += new System.EventHandler(this.TimKiemChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrchitiethd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdhienthitoanbo;
        private System.Windows.Forms.RadioButton rdsoluong;
        private System.Windows.Forms.RadioButton rdsach;
        private System.Windows.Forms.RadioButton rdsohd;
        private System.Windows.Forms.ComboBox cbsach;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrchitiethd;
    }
}