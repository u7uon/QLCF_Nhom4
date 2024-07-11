namespace QuanLyMuaBanCaPhe
{
    partial class FrmOrder
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
            this.dtgvTaiquan = new System.Windows.Forms.DataGridView();
            this.lblOrder = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiquan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTaiquan
            // 
            this.dtgvTaiquan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiquan.Location = new System.Drawing.Point(1023, 57);
            this.dtgvTaiquan.Name = "dtgvTaiquan";
            this.dtgvTaiquan.RowHeadersWidth = 51;
            this.dtgvTaiquan.RowTemplate.Height = 24;
            this.dtgvTaiquan.Size = new System.Drawing.Size(467, 637);
            this.dtgvTaiquan.TabIndex = 0;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrder.Location = new System.Drawing.Point(420, 3);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(153, 51);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "MENU";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(21, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 695);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(1195, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "BILL";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 765);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.dtgvTaiquan);
            this.Controls.Add(this.panel3);
            this.Name = "FrmOrder";
            this.Text = "order";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiquan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvTaiquan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label1;
    }
}