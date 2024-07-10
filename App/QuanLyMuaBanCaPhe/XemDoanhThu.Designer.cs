namespace QuanLyMuaBanCaPhe
{
    partial class frmThongke
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
            this.btnViewDoanhThu = new System.Windows.Forms.Button();
            this.dtpkNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 659);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btnViewDoanhThu);
            this.panel3.Controls.Add(this.dtpkNgayKetThuc);
            this.panel3.Controls.Add(this.dtpkNgaybatdau);
            this.panel3.Location = new System.Drawing.Point(16, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 68);
            this.panel3.TabIndex = 1;
            // 
            // btnViewDoanhThu
            // 
            this.btnViewDoanhThu.BackColor = System.Drawing.Color.White;
            this.btnViewDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDoanhThu.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnViewDoanhThu.Location = new System.Drawing.Point(264, 18);
            this.btnViewDoanhThu.Name = "btnViewDoanhThu";
            this.btnViewDoanhThu.Size = new System.Drawing.Size(225, 45);
            this.btnViewDoanhThu.TabIndex = 1;
            this.btnViewDoanhThu.Text = "Thống kê";
            this.btnViewDoanhThu.UseVisualStyleBackColor = false;
            // 
            // dtpkNgayKetThuc
            // 
            this.dtpkNgayKetThuc.Location = new System.Drawing.Point(495, 21);
            this.dtpkNgayKetThuc.Name = "dtpkNgayKetThuc";
            this.dtpkNgayKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpkNgayKetThuc.TabIndex = 1;
            // 
            // dtpkNgaybatdau
            // 
            this.dtpkNgaybatdau.Location = new System.Drawing.Point(12, 18);
            this.dtpkNgaybatdau.Name = "dtpkNgaybatdau";
            this.dtpkNgaybatdau.Size = new System.Drawing.Size(238, 22);
            this.dtpkNgaybatdau.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvBill);
            this.panel2.Location = new System.Drawing.Point(3, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 504);
            this.panel2.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(13, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(787, 498);
            this.dtgvBill.TabIndex = 0;
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1857, 1055);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongke";
            this.Text = "XemDoanhThu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpkNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpkNgaybatdau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Button btnViewDoanhThu;
    }
}