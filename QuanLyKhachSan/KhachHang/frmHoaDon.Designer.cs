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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatDV = new QuanLyKhachSan.Components.VBButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colMaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong1
            // 
            this.dgvPhong1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong1.Location = new System.Drawing.Point(98, 85);
            this.dgvPhong1.Name = "dgvPhong1";
            this.dgvPhong1.RowHeadersWidth = 51;
            this.dgvPhong1.RowTemplate.Height = 24;
            this.dgvPhong1.Size = new System.Drawing.Size(666, 243);
            this.dgvPhong1.TabIndex = 0;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDichVu,
            this.colTenDichVu,
            this.colGiaDichVu});
            this.dgvDichVu.Location = new System.Drawing.Point(98, 364);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(666, 216);
            this.dgvDichVu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(308, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin";
            // 
            // btnDatDV
            // 
            this.btnDatDV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDatDV.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDatDV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDatDV.BorderRadius = 20;
            this.btnDatDV.BorderSize = 0;
            this.btnDatDV.FlatAppearance.BorderSize = 0;
            this.btnDatDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatDV.ForeColor = System.Drawing.Color.White;
            this.btnDatDV.Location = new System.Drawing.Point(316, 608);
            this.btnDatDV.Name = "btnDatDV";
            this.btnDatDV.Size = new System.Drawing.Size(150, 40);
            this.btnDatDV.TabIndex = 3;
            this.btnDatDV.Text = "Đặt Dịch Vụ";
            this.btnDatDV.TextColor = System.Drawing.Color.White;
            this.btnDatDV.UseVisualStyleBackColor = false;
            this.btnDatDV.Click += new System.EventHandler(this.btnDatDV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dịch  Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(24, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng";
            // 
            // colMaDichVu
            // 
            this.colMaDichVu.HeaderText = "Mã DỊch Vụ";
            this.colMaDichVu.MinimumWidth = 6;
            this.colMaDichVu.Name = "colMaDichVu";
            this.colMaDichVu.Width = 125;
            // 
            // colTenDichVu
            // 
            this.colTenDichVu.HeaderText = "Tên Dịch Vụ";
            this.colTenDichVu.MinimumWidth = 6;
            this.colTenDichVu.Name = "colTenDichVu";
            this.colTenDichVu.Width = 125;
            // 
            // colGiaDichVu
            // 
            this.colGiaDichVu.HeaderText = "Giá Dịch Vụ";
            this.colGiaDichVu.MinimumWidth = 6;
            this.colGiaDichVu.Name = "colGiaDichVu";
            this.colGiaDichVu.Width = 125;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 678);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDatDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.dgvPhong1);
            this.Name = "frmHoaDon";
            this.Text = "dgvPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong1;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Label label1;
        private Components.VBButton btnDatDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaDichVu;
    }
}