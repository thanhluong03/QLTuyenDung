
namespace BTL_HSK_QLThuVien
{
    partial class InBaoCaoSach
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
            this.crySach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rdtheloai = new System.Windows.Forms.RadioButton();
            this.rdgiamuon = new System.Windows.Forms.RadioButton();
            this.txtgiatridau = new System.Windows.Forms.TextBox();
            this.txtgiatricuoi = new System.Windows.Forms.TextBox();
            this.lbden = new System.Windows.Forms.Label();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.lbnguoilap = new System.Windows.Forms.Label();
            this.txtnguoilap = new System.Windows.Forms.TextBox();
            this.cbtheloai = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // crySach
            // 
            this.crySach.ActiveViewIndex = -1;
            this.crySach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crySach.Cursor = System.Windows.Forms.Cursors.Default;
            this.crySach.Location = new System.Drawing.Point(3, 86);
            this.crySach.Name = "crySach";
            this.crySach.Size = new System.Drawing.Size(1295, 565);
            this.crySach.TabIndex = 0;
            // 
            // rdtheloai
            // 
            this.rdtheloai.AutoSize = true;
            this.rdtheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtheloai.Location = new System.Drawing.Point(12, 27);
            this.rdtheloai.Name = "rdtheloai";
            this.rdtheloai.Size = new System.Drawing.Size(89, 24);
            this.rdtheloai.TabIndex = 1;
            this.rdtheloai.TabStop = true;
            this.rdtheloai.Text = "Thể loại";
            this.rdtheloai.UseVisualStyleBackColor = true;
            this.rdtheloai.CheckedChanged += new System.EventHandler(this.rdtheloai_CheckedChanged);
            // 
            // rdgiamuon
            // 
            this.rdgiamuon.AutoSize = true;
            this.rdgiamuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgiamuon.Location = new System.Drawing.Point(327, 24);
            this.rdgiamuon.Name = "rdgiamuon";
            this.rdgiamuon.Size = new System.Drawing.Size(102, 24);
            this.rdgiamuon.TabIndex = 4;
            this.rdgiamuon.TabStop = true;
            this.rdgiamuon.Text = "Giá mượn";
            this.rdgiamuon.UseVisualStyleBackColor = true;
            this.rdgiamuon.CheckedChanged += new System.EventHandler(this.rdgiamuon_CheckedChanged);
            // 
            // txtgiatridau
            // 
            this.txtgiatridau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiatridau.Location = new System.Drawing.Point(435, 23);
            this.txtgiatridau.Name = "txtgiatridau";
            this.txtgiatridau.Size = new System.Drawing.Size(104, 27);
            this.txtgiatridau.TabIndex = 5;
            // 
            // txtgiatricuoi
            // 
            this.txtgiatricuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiatricuoi.Location = new System.Drawing.Point(587, 23);
            this.txtgiatricuoi.Name = "txtgiatricuoi";
            this.txtgiatricuoi.Size = new System.Drawing.Size(104, 27);
            this.txtgiatricuoi.TabIndex = 6;
            // 
            // lbden
            // 
            this.lbden.AutoSize = true;
            this.lbden.Location = new System.Drawing.Point(545, 30);
            this.lbden.Name = "lbden";
            this.lbden.Size = new System.Drawing.Size(36, 17);
            this.lbden.TabIndex = 6;
            this.lbden.Text = "đến ";
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnInBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoCao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInBaoCao.Location = new System.Drawing.Point(1176, 16);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(75, 34);
            this.btnInBaoCao.TabIndex = 3;
            this.btnInBaoCao.Text = "In";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // lbnguoilap
            // 
            this.lbnguoilap.AutoSize = true;
            this.lbnguoilap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnguoilap.Location = new System.Drawing.Point(750, 27);
            this.lbnguoilap.Name = "lbnguoilap";
            this.lbnguoilap.Size = new System.Drawing.Size(79, 20);
            this.lbnguoilap.TabIndex = 8;
            this.lbnguoilap.Text = "Người lập";
            // 
            // txtnguoilap
            // 
            this.txtnguoilap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnguoilap.Location = new System.Drawing.Point(835, 23);
            this.txtnguoilap.Name = "txtnguoilap";
            this.txtnguoilap.Size = new System.Drawing.Size(123, 27);
            this.txtnguoilap.TabIndex = 0;
            this.txtnguoilap.Validating += new System.ComponentModel.CancelEventHandler(this.txtnguoilap_Validating);
            // 
            // cbtheloai
            // 
            this.cbtheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtheloai.FormattingEnabled = true;
            this.cbtheloai.Location = new System.Drawing.Point(107, 23);
            this.cbtheloai.Name = "cbtheloai";
            this.cbtheloai.Size = new System.Drawing.Size(157, 28);
            this.cbtheloai.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InBaoCaoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 655);
            this.Controls.Add(this.cbtheloai);
            this.Controls.Add(this.txtnguoilap);
            this.Controls.Add(this.lbnguoilap);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.lbden);
            this.Controls.Add(this.txtgiatricuoi);
            this.Controls.Add(this.txtgiatridau);
            this.Controls.Add(this.rdgiamuon);
            this.Controls.Add(this.rdtheloai);
            this.Controls.Add(this.crySach);
            this.Name = "InBaoCaoSach";
            this.Text = "InBaoCaoSach";
            this.Load += new System.EventHandler(this.InBaoCaoSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crySach;
        private System.Windows.Forms.RadioButton rdtheloai;
        private System.Windows.Forms.RadioButton rdgiamuon;
        private System.Windows.Forms.TextBox txtgiatridau;
        private System.Windows.Forms.TextBox txtgiatricuoi;
        private System.Windows.Forms.Label lbden;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Label lbnguoilap;
        private System.Windows.Forms.TextBox txtnguoilap;
        private System.Windows.Forms.ComboBox cbtheloai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}