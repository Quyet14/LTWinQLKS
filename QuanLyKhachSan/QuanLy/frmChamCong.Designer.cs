namespace QuanLyKhachSan
{
    partial class frmChamCong
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
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.Colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new QuanLyKhachSan.Components.VBTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThang = new QuanLyKhachSan.Components.VBTextBox();
            this.btnTinhLuong = new QuanLyKhachSan.Components.VBButton();
            this.btnTimKiem = new QuanLyKhachSan.Components.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colum,
            this.Column1,
            this.Column3});
            this.dgvChamCong.Location = new System.Drawing.Point(13, 234);
            this.dgvChamCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(1067, 279);
            this.dgvChamCong.TabIndex = 0;
            // 
            // Colum
            // 
            this.Colum.DataPropertyName = "MaChamCong";
            this.Colum.HeaderText = "Mã Chấm Công";
            this.Colum.MinimumWidth = 6;
            this.Colum.Name = "Colum";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNhanVien";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ngay";
            this.Column3.HeaderText = "Ngày";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNV.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaNV.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaNV.BorderRadius = 15;
            this.txtMaNV.BorderSize = 2;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaNV.Location = new System.Drawing.Point(389, 141);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaNV.Multiline = false;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtMaNV.PasswordChar = false;
            this.txtMaNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.Size = new System.Drawing.Size(411, 54);
            this.txtMaNV.TabIndex = 2;
            this.txtMaNV.Texts = "";
            this.txtMaNV.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tháng";
            // 
            // txtThang
            // 
            this.txtThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThang.BackColor = System.Drawing.SystemColors.Window;
            this.txtThang.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtThang.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtThang.BorderRadius = 15;
            this.txtThang.BorderSize = 2;
            this.txtThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtThang.Location = new System.Drawing.Point(389, 59);
            this.txtThang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtThang.Multiline = false;
            this.txtThang.Name = "txtThang";
            this.txtThang.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtThang.PasswordChar = false;
            this.txtThang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtThang.PlaceholderText = "";
            this.txtThang.Size = new System.Drawing.Size(411, 54);
            this.txtThang.TabIndex = 1;
            this.txtThang.Texts = "";
            this.txtThang.UnderlinedStyle = false;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinhLuong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTinhLuong.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTinhLuong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTinhLuong.BorderRadius = 20;
            this.btnTinhLuong.BorderSize = 0;
            this.btnTinhLuong.FlatAppearance.BorderSize = 0;
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.Location = new System.Drawing.Point(859, 141);
            this.btnTinhLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(206, 60);
            this.btnTinhLuong.TabIndex = 4;
            this.btnTinhLuong.Text = "Tính Lương";
            this.btnTinhLuong.TextColor = System.Drawing.Color.White;
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimKiem.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 20;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(859, 54);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(206, 60);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1100, 551);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvChamCong);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChamCong";
            this.Text = "Chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label label2;
        private Components.VBTextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private Components.VBTextBox txtThang;
        private Components.VBButton btnTinhLuong;
        private Components.VBButton btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}