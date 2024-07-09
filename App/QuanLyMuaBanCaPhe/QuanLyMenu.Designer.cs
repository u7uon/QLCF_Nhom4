namespace QuanLyMuaBanCaPhe
{
    partial class frmQlMenu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblTenmon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvQuanlymenu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanlymenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 712);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMota);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.txtGiaTien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTenMon);
            this.panel3.Controls.Add(this.lblTenmon);
            this.panel3.Location = new System.Drawing.Point(60, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 637);
            this.panel3.TabIndex = 3;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(178, 341);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(246, 22);
            this.txtMota.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(41, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mô tả:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 133);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.Location = new System.Drawing.Point(334, 498);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 53);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(191, 498);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 53);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(171, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(33, 498);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 53);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = " Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(178, 417);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(246, 22);
            this.txtGiaTien.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(41, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(41, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hình ảnh :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(178, 96);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(246, 22);
            this.txtTenMon.TabIndex = 3;
            // 
            // lblTenmon
            // 
            this.lblTenmon.AutoSize = true;
            this.lblTenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenmon.ForeColor = System.Drawing.Color.Maroon;
            this.lblTenmon.Location = new System.Drawing.Point(41, 96);
            this.lblTenmon.Name = "lblTenmon";
            this.lblTenmon.Size = new System.Drawing.Size(84, 20);
            this.lblTenmon.TabIndex = 2;
            this.lblTenmon.Text = "Tên món :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvQuanlymenu);
            this.panel2.Location = new System.Drawing.Point(548, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 647);
            this.panel2.TabIndex = 2;
            // 
            // dtgvQuanlymenu
            // 
            this.dtgvQuanlymenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuanlymenu.Location = new System.Drawing.Point(16, 61);
            this.dtgvQuanlymenu.Name = "dtgvQuanlymenu";
            this.dtgvQuanlymenu.RowHeadersWidth = 51;
            this.dtgvQuanlymenu.RowTemplate.Height = 24;
            this.dtgvQuanlymenu.Size = new System.Drawing.Size(654, 549);
            this.dtgvQuanlymenu.TabIndex = 0;
            // 
            // frmQlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 712);
            this.Controls.Add(this.panel1);
            this.Name = "frmQlMenu";
            this.Text = "QuanLyMenu";
            this.Load += new System.EventHandler(this.QuanLyMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanlymenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvQuanlymenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblTenmon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}