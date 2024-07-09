namespace QuanLyMuaBanCaPhe
{
    partial class frmDoiMatKhau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNewpassword = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMk = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDoiMK);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(38, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 524);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(386, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDoiMK.Location = new System.Drawing.Point(114, 442);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(192, 48);
            this.btnDoiMK.TabIndex = 4;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(42, 325);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 85);
            this.panel5.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(257, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập lại mật khẩu:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtNewpassword);
            this.panel4.Controls.Add(this.lblMatKhauMoi);
            this.panel4.Location = new System.Drawing.Point(42, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 85);
            this.panel4.TabIndex = 2;
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewpassword.Location = new System.Drawing.Point(202, 36);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.Size = new System.Drawing.Size(295, 27);
            this.txtNewpassword.TabIndex = 1;
            this.txtNewpassword.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMatKhauMoi.Location = new System.Drawing.Point(22, 32);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(174, 29);
            this.lblMatKhauMoi.TabIndex = 0;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Controls.Add(this.lblMk);
            this.panel3.Location = new System.Drawing.Point(42, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 85);
            this.panel3.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(184, 36);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(298, 27);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMk
            // 
            this.lblMk.AutoSize = true;
            this.lblMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMk.Location = new System.Drawing.Point(22, 32);
            this.lblMk.Name = "lblMk";
            this.lblMk.Size = new System.Drawing.Size(124, 29);
            this.lblMk.TabIndex = 0;
            this.lblMk.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDangNhap);
            this.panel2.Controls.Add(this.lblDangNhap);
            this.panel2.Location = new System.Drawing.Point(42, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 85);
            this.panel2.TabIndex = 0;
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.Location = new System.Drawing.Point(231, 32);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(251, 27);
            this.txtDangNhap.TabIndex = 1;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDangNhap.Location = new System.Drawing.Point(22, 32);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(203, 29);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // frmDoiMatKhau
            // 
            this.AcceptButton = this.btnDoiMK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(687, 546);
            this.Controls.Add(this.panel1);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông_tin_cá_nhân";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNewpassword;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}