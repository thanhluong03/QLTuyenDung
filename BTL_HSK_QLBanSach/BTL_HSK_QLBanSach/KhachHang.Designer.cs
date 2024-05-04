namespace BTL_HSK_QLBanSach
{
    partial class KhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtNgaySinhKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSdtKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInputSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(5, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 293);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtTenKH);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 59);
            this.panel6.TabIndex = 2;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(6, 30);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(272, 22);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenKH_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng : ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtNgaySinhKH);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(3, 153);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(281, 57);
            this.panel8.TabIndex = 2;
            // 
            // txtNgaySinhKH
            // 
            this.txtNgaySinhKH.Location = new System.Drawing.Point(6, 30);
            this.txtNgaySinhKH.Name = "txtNgaySinhKH";
            this.txtNgaySinhKH.Size = new System.Drawing.Size(272, 22);
            this.txtNgaySinhKH.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh : ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtSdtKH);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(3, 216);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(281, 59);
            this.panel9.TabIndex = 2;
            // 
            // txtSdtKH
            // 
            this.txtSdtKH.Location = new System.Drawing.Point(6, 30);
            this.txtSdtKH.Name = "txtSdtKH";
            this.txtSdtKH.Size = new System.Drawing.Size(272, 22);
            this.txtSdtKH.TabIndex = 1;
            this.txtSdtKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSdtKH_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại : ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtDiaChiKH);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(3, 85);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 62);
            this.panel7.TabIndex = 2;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(6, 30);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(272, 22);
            this.txtDiaChiKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ : ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnADD);
            this.panel4.Location = new System.Drawing.Point(305, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(674, 108);
            this.panel4.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(539, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(379, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(208, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 49);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(46, 28);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(89, 49);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "Thêm";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtInputSearch);
            this.panel2.Location = new System.Drawing.Point(305, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 42);
            this.panel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tìm khách hàng theo tên : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(498, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInputSearch
            // 
            this.txtInputSearch.Location = new System.Drawing.Point(186, 13);
            this.txtInputSearch.Name = "txtInputSearch";
            this.txtInputSearch.Size = new System.Drawing.Size(306, 22);
            this.txtInputSearch.TabIndex = 0;
            this.txtInputSearch.TextChanged += new System.EventHandler(this.txtInputSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvKhachHang);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(305, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 293);
            this.panel3.TabIndex = 6;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(6, 39);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(659, 250);
            this.dgvKhachHang.TabIndex = 1;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Danh sách nhân viên : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "KhachHang";
            this.Text = "Quản Lí Khách Hàng";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtNgaySinhKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSdtKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInputSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}