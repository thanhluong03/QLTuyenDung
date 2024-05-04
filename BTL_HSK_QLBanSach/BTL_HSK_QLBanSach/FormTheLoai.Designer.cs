namespace BTL_HSK_QLBanSach
{
    partial class FormTheLoai
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
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblMaTheLoai = new System.Windows.Forms.Label();
            this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTheLoai.Location = new System.Drawing.Point(0, 0);
            this.dgvTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.RowHeadersWidth = 82;
            this.dgvTheLoai.RowTemplate.Height = 33;
            this.dgvTheLoai.Size = new System.Drawing.Size(680, 285);
            this.dgvTheLoai.TabIndex = 0;
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtTheLoai);
            this.panel1.Controls.Add(this.txtMaTheLoai);
            this.panel1.Controls.Add(this.lblTheLoai);
            this.panel1.Controls.Add(this.lblMaTheLoai);
            this.panel1.Location = new System.Drawing.Point(9, 299);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 138);
            this.panel1.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoa.Location = new System.Drawing.Point(286, 95);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 35);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSua.Location = new System.Drawing.Point(453, 57);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 35);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThem.Location = new System.Drawing.Point(138, 57);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 35);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(416, 13);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(216, 22);
            this.txtTheLoai.TabIndex = 3;
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Location = new System.Drawing.Point(114, 13);
            this.txtMaTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(173, 22);
            this.txtMaTheLoai.TabIndex = 2;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(349, 15);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(63, 17);
            this.lblTheLoai.TabIndex = 1;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // lblMaTheLoai
            // 
            this.lblMaTheLoai.AutoSize = true;
            this.lblMaTheLoai.Location = new System.Drawing.Point(27, 15);
            this.lblMaTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTheLoai.Name = "lblMaTheLoai";
            this.lblMaTheLoai.Size = new System.Drawing.Size(81, 17);
            this.lblMaTheLoai.TabIndex = 0;
            this.lblMaTheLoai.Text = "Mã thể loại:";
            // 
            // errLoi
            // 
            this.errLoi.ContainerControl = this;
            // 
            // FormTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTheLoai);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTheLoai";
            this.Text = "Quản Lí Thể loại";
            this.Load += new System.EventHandler(this.FormTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtMaTheLoai;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblMaTheLoai;
        private System.Windows.Forms.ErrorProvider errLoi;
    }
}