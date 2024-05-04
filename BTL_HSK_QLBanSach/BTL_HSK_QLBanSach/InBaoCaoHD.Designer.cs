
namespace BTL_HSK_QLBanSach
{
    partial class InBaoCaoHD
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
            this.cryHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.txtkhachhang = new System.Windows.Forms.TextBox();
            this.rdkhachhang = new System.Windows.Forms.RadioButton();
            this.dtthangnam = new System.Windows.Forms.DateTimePicker();
            this.rdthangnam = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cryHD
            // 
            this.cryHD.ActiveViewIndex = -1;
            this.cryHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryHD.Location = new System.Drawing.Point(3, 76);
            this.cryHD.Name = "cryHD";
            this.cryHD.Size = new System.Drawing.Size(1303, 651);
            this.cryHD.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1168, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "In ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkhachhang
            // 
            this.txtkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkhachhang.Location = new System.Drawing.Point(150, 19);
            this.txtkhachhang.Name = "txtkhachhang";
            this.txtkhachhang.Size = new System.Drawing.Size(198, 27);
            this.txtkhachhang.TabIndex = 14;
            // 
            // rdkhachhang
            // 
            this.rdkhachhang.AutoSize = true;
            this.rdkhachhang.Location = new System.Drawing.Point(12, 25);
            this.rdkhachhang.Name = "rdkhachhang";
            this.rdkhachhang.Size = new System.Drawing.Size(132, 21);
            this.rdkhachhang.TabIndex = 15;
            this.rdkhachhang.TabStop = true;
            this.rdkhachhang.Text = "Tên khách hàng";
            this.rdkhachhang.UseVisualStyleBackColor = true;
            this.rdkhachhang.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dtthangnam
            // 
            this.dtthangnam.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtthangnam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtthangnam.Location = new System.Drawing.Point(557, 23);
            this.dtthangnam.Name = "dtthangnam";
            this.dtthangnam.Size = new System.Drawing.Size(200, 22);
            this.dtthangnam.TabIndex = 20;
            this.dtthangnam.Value = new System.DateTime(2023, 4, 12, 15, 17, 26, 0);
            // 
            // rdthangnam
            // 
            this.rdthangnam.AutoSize = true;
            this.rdthangnam.Location = new System.Drawing.Point(429, 23);
            this.rdthangnam.Name = "rdthangnam";
            this.rdthangnam.Size = new System.Drawing.Size(101, 21);
            this.rdthangnam.TabIndex = 21;
            this.rdthangnam.TabStop = true;
            this.rdthangnam.Text = "Tháng năm";
            this.rdthangnam.UseVisualStyleBackColor = true;
            this.rdthangnam.CheckedChanged += new System.EventHandler(this.rdthangnam_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(937, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // InBaoCaoHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 739);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rdthangnam);
            this.Controls.Add(this.dtthangnam);
            this.Controls.Add(this.rdkhachhang);
            this.Controls.Add(this.txtkhachhang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cryHD);
            this.Name = "InBaoCaoHD";
            this.Text = "Báo Cáo Hóa Đơn";
            this.Load += new System.EventHandler(this.InBaoCaoHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtkhachhang;
        private System.Windows.Forms.RadioButton rdkhachhang;
        private System.Windows.Forms.DateTimePicker dtthangnam;
        private System.Windows.Forms.RadioButton rdthangnam;
        private System.Windows.Forms.Button button2;
    }
}