namespace QuanLyMuaBanCaPhe
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý quán cafe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnQuenMK);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 347);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(533, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnQuenMK.Location = new System.Drawing.Point(299, 276);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(184, 37);
            this.btnQuenMK.TabIndex = 4;
            this.btnQuenMK.Text = "Quên Mật Khẩu";
            this.btnQuenMK.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDangNhap.Location = new System.Drawing.Point(95, 276);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(152, 37);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Controls.Add(this.lblMatKhau);
            this.panel3.Location = new System.Drawing.Point(43, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 65);
            this.panel3.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(275, 23);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(324, 27);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.Maroon;
            this.lblMatKhau.Location = new System.Drawing.Point(28, 16);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(160, 32);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật Khẩu :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenDangNhap);
            this.panel2.Controls.Add(this.lblTenDangNhap);
            this.panel2.Location = new System.Drawing.Point(43, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 65);
            this.panel2.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(275, 23);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(324, 27);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.Maroon;
            this.lblTenDangNhap.Location = new System.Drawing.Point(18, 13);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(243, 32);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập :";
            // 
            // Login
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(815, 416);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Button btnQuenMK;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnExit;
    }
}

