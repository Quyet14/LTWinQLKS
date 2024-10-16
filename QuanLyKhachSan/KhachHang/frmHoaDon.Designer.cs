namespace QuanLyKhachSan
{
    partial class frmHoaDon
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
            this.dgvPhong1 = new System.Windows.Forms.DataGridView();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnDat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong1
            // 
            this.dgvPhong1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong1.Location = new System.Drawing.Point(12, 70);
            this.dgvPhong1.Name = "dgvPhong1";
            this.dgvPhong1.RowHeadersWidth = 51;
            this.dgvPhong1.RowTemplate.Height = 24;
            this.dgvPhong1.Size = new System.Drawing.Size(976, 232);
            this.dgvPhong1.TabIndex = 0;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(12, 308);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(976, 232);
            this.dgvDichVu.TabIndex = 0;
            // 
            // btnDat
            // 
            this.btnDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDat.Location = new System.Drawing.Point(453, 554);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(100, 37);
            this.btnDat.TabIndex = 1;
            this.btnDat.Text = "Đặt";
            this.btnDat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(436, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin";
            // 
            // dgvPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.dgvPhong1);
            this.Name = "dgvPhong";
            this.Text = "dgvPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong1;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.Label label1;
    }
}