
namespace BTL_HSK_QLBanSach
{
    partial class Nhaxuatban
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.lbnMaNXB = new System.Windows.Forms.Label();
            this.lbnTenNXB = new System.Windows.Forms.Label();
            this.lbnDC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Location = new System.Drawing.Point(134, 577);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 24);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(327, 577);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(532, 577);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTim.Location = new System.Drawing.Point(747, 577);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(42, 37);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(232, 22);
            this.txtMaNXB.TabIndex = 4;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(463, 37);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(259, 22);
            this.txtTenNXB.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(42, 102);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(232, 22);
            this.txtDiaChi.TabIndex = 6;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(463, 102);
            this.mtxtSDT.Mask = "0000000000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(259, 22);
            this.mtxtSDT.TabIndex = 7;
            // 
            // lbnMaNXB
            // 
            this.lbnMaNXB.AutoSize = true;
            this.lbnMaNXB.Location = new System.Drawing.Point(39, 17);
            this.lbnMaNXB.Name = "lbnMaNXB";
            this.lbnMaNXB.Size = new System.Drawing.Size(113, 17);
            this.lbnMaNXB.TabIndex = 8;
            this.lbnMaNXB.Text = "Mã nhà xuất bản";
            // 
            // lbnTenNXB
            // 
            this.lbnTenNXB.AutoSize = true;
            this.lbnTenNXB.Location = new System.Drawing.Point(460, 17);
            this.lbnTenNXB.Name = "lbnTenNXB";
            this.lbnTenNXB.Size = new System.Drawing.Size(119, 17);
            this.lbnTenNXB.TabIndex = 9;
            this.lbnTenNXB.Text = "Tên nhà xuất bản";
            // 
            // lbnDC
            // 
            this.lbnDC.AutoSize = true;
            this.lbnDC.Location = new System.Drawing.Point(39, 70);
            this.lbnDC.Name = "lbnDC";
            this.lbnDC.Size = new System.Drawing.Size(51, 17);
            this.lbnDC.TabIndex = 10;
            this.lbnDC.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số điện thoại";
            // 
            // dgvNXB
            // 
            this.dgvNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(42, 148);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.RowHeadersWidth = 51;
            this.dgvNXB.RowTemplate.Height = 24;
            this.dgvNXB.Size = new System.Drawing.Size(854, 423);
            this.dgvNXB.TabIndex = 12;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);
            // 
            // Nhaxuatban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 613);
            this.Controls.Add(this.dgvNXB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnDC);
            this.Controls.Add(this.lbnTenNXB);
            this.Controls.Add(this.lbnMaNXB);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "Nhaxuatban";
            this.Text = "Quản Lí Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.Nhaxuatban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Label lbnMaNXB;
        private System.Windows.Forms.Label lbnTenNXB;
        private System.Windows.Forms.Label lbnDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNXB;
    }
}