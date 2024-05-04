
namespace BTL_HSK_QLThuVien
{
    partial class NhaXuatBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.txtsodt = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttennxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.btnTimKiemNXB = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.btnSuaNXB = new System.Windows.Forms.Button();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.dgrNXB = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 6;
            // 
            // gbthongtin
            // 
            this.gbthongtin.Controls.Add(this.txtsodt);
            this.gbthongtin.Controls.Add(this.label5);
            this.gbthongtin.Controls.Add(this.label4);
            this.gbthongtin.Controls.Add(this.txtdiachi);
            this.gbthongtin.Controls.Add(this.label2);
            this.gbthongtin.Controls.Add(this.txttennxb);
            this.gbthongtin.Controls.Add(this.label3);
            this.gbthongtin.Controls.Add(this.txtmanxb);
            this.gbthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbthongtin.Location = new System.Drawing.Point(12, 21);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Size = new System.Drawing.Size(419, 287);
            this.gbthongtin.TabIndex = 3;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "Thông tin nhà xuất bản";
            // 
            // txtsodt
            // 
            this.txtsodt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsodt.Location = new System.Drawing.Point(172, 226);
            this.txtsodt.Mask = "0000000000";
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(133, 27);
            this.txtsodt.TabIndex = 3;
            this.txtsodt.ValidatingType = typeof(int);
            this.txtsodt.Validating += new System.ComponentModel.CancelEventHandler(this.txtsodt_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(170, 169);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(211, 27);
            this.txtdiachi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên nhà xuất bản";
            // 
            // txttennxb
            // 
            this.txttennxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennxb.Location = new System.Drawing.Point(172, 108);
            this.txttennxb.Name = "txttennxb";
            this.txttennxb.Size = new System.Drawing.Size(209, 27);
            this.txttennxb.TabIndex = 1;
            this.txttennxb.Validating += new System.ComponentModel.CancelEventHandler(this.txttennxb_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã nhà xuất bản";
            // 
            // txtmanxb
            // 
            this.txtmanxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanxb.Location = new System.Drawing.Point(170, 52);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.Size = new System.Drawing.Size(123, 27);
            this.txtmanxb.TabIndex = 0;
            this.txtmanxb.Validating += new System.ComponentModel.CancelEventHandler(this.txtmanxb_Validating);
            // 
            // btnTimKiemNXB
            // 
            this.btnTimKiemNXB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTimKiemNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNXB.Location = new System.Drawing.Point(758, 376);
            this.btnTimKiemNXB.Name = "btnTimKiemNXB";
            this.btnTimKiemNXB.Size = new System.Drawing.Size(126, 38);
            this.btnTimKiemNXB.TabIndex = 7;
            this.btnTimKiemNXB.Text = "Tìm kiếm";
            this.btnTimKiemNXB.UseVisualStyleBackColor = false;
            this.btnTimKiemNXB.Click += new System.EventHandler(this.btnTimKiemNXB_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(977, 376);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(126, 38);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXoaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNXB.Location = new System.Drawing.Point(545, 376);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(126, 38);
            this.btnXoaNXB.TabIndex = 6;
            this.btnXoaNXB.Text = "Xóa";
            this.btnXoaNXB.UseVisualStyleBackColor = false;
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);
            // 
            // btnSuaNXB
            // 
            this.btnSuaNXB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSuaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNXB.Location = new System.Drawing.Point(348, 376);
            this.btnSuaNXB.Name = "btnSuaNXB";
            this.btnSuaNXB.Size = new System.Drawing.Size(126, 38);
            this.btnSuaNXB.TabIndex = 5;
            this.btnSuaNXB.Text = "Sửa";
            this.btnSuaNXB.UseVisualStyleBackColor = false;
            this.btnSuaNXB.Click += new System.EventHandler(this.btnSuaNXB_Click);
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThemNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNXB.Location = new System.Drawing.Point(143, 376);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(126, 38);
            this.btnThemNXB.TabIndex = 4;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.UseVisualStyleBackColor = false;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // dgrNXB
            // 
            this.dgrNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNXB.Location = new System.Drawing.Point(469, 57);
            this.dgrNXB.Name = "dgrNXB";
            this.dgrNXB.ReadOnly = true;
            this.dgrNXB.RowHeadersWidth = 51;
            this.dgrNXB.RowTemplate.Height = 24;
            this.dgrNXB.Size = new System.Drawing.Size(769, 197);
            this.dgrNXB.TabIndex = 18;
            this.dgrNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNXB_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Danh sách nhà xuất bản";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 477);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgrNXB);
            this.Controls.Add(this.btnTimKiemNXB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbthongtin);
            this.Controls.Add(this.btnXoaNXB);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSuaNXB);
            this.Controls.Add(this.btnThemNXB);
            this.Name = "NhaXuatBan";
            this.Text = "Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.NhaXuatBan_Load);
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button btnTimKiemNXB;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.Button btnSuaNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.MaskedTextBox txtsodt;
        private System.Windows.Forms.DataGridView dgrNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}