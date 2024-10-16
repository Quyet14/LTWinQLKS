namespace QuanLyKhachSan
{
    partial class DichVu
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
            this.btnDat = new System.Windows.Forms.Button();
            this.cbbTenDichVu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbbGia = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dịch Vụ";
            // 
            // btnDat
            // 
            this.btnDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDat.Location = new System.Drawing.Point(476, 371);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(115, 42);
            this.btnDat.TabIndex = 1;
            this.btnDat.Text = "Đặt";
            this.btnDat.UseVisualStyleBackColor = true;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // cbbTenDichVu
            // 
            this.cbbTenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenDichVu.FormattingEnabled = true;
            this.cbbTenDichVu.Location = new System.Drawing.Point(377, 184);
            this.cbbTenDichVu.Name = "cbbTenDichVu";
            this.cbbTenDichVu.Size = new System.Drawing.Size(310, 33);
            this.cbbTenDichVu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá";
            // 
            // pbbGia
            // 
            this.pbbGia.Location = new System.Drawing.Point(377, 267);
            this.pbbGia.Name = "pbbGia";
            this.pbbGia.Size = new System.Drawing.Size(310, 33);
            this.pbbGia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(380, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông Tin Dịch Vụ";
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 506);
            this.Controls.Add(this.pbbGia);
            this.Controls.Add(this.cbbTenDichVu);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DichVu";
            this.Text = "DichVu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.ComboBox cbbTenDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbbGia;
        private System.Windows.Forms.Label label3;
    }
}