namespace QuanLyKhachSan.KhachHang
{
    partial class frmHoaDonDichVu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHoaDonDV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datNgayLap = new System.Windows.Forms.DateTimePicker();
            this.vbtTongTien = new QuanLyKhachSan.Components.VBTextBox();
            this.btnSua = new QuanLyKhachSan.Components.VBButton();
            this.btnXoa = new QuanLyKhachSan.Components.VBButton();
            this.btnThem = new QuanLyKhachSan.Components.VBButton();
            this.vbtMaNV = new QuanLyKhachSan.Components.VBTextBox();
            this.vbtMaHoaDon = new QuanLyKhachSan.Components.VBTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Dịch Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // dgvHoaDonDV
            // 
            this.dgvHoaDonDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonDV.Location = new System.Drawing.Point(12, 288);
            this.dgvHoaDonDV.Name = "dgvHoaDonDV";
            this.dgvHoaDonDV.RowHeadersWidth = 51;
            this.dgvHoaDonDV.RowTemplate.Height = 24;
            this.dgvHoaDonDV.Size = new System.Drawing.Size(776, 150);
            this.dgvHoaDonDV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng Tiền";
            // 
            // datNgayLap
            // 
            this.datNgayLap.Location = new System.Drawing.Point(565, 100);
            this.datNgayLap.Name = "datNgayLap";
            this.datNgayLap.Size = new System.Drawing.Size(223, 22);
            this.datNgayLap.TabIndex = 9;
            // 
            // vbtTongTien
            // 
            this.vbtTongTien.BackColor = System.Drawing.SystemColors.Window;
            this.vbtTongTien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.vbtTongTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.vbtTongTien.BorderRadius = 15;
            this.vbtTongTien.BorderSize = 2;
            this.vbtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vbtTongTien.Location = new System.Drawing.Point(583, 151);
            this.vbtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.vbtTongTien.Multiline = false;
            this.vbtTongTien.Name = "vbtTongTien";
            this.vbtTongTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.vbtTongTien.PasswordChar = false;
            this.vbtTongTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.vbtTongTien.PlaceholderText = "";
            this.vbtTongTien.Size = new System.Drawing.Size(182, 35);
            this.vbtTongTien.TabIndex = 8;
            this.vbtTongTien.Texts = "";
            this.vbtTongTien.UnderlinedStyle = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.BackgroundColor = System.Drawing.Color.Blue;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(583, 227);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Blue;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Blue;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(367, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Blue;
            this.btnThem.BackgroundColor = System.Drawing.Color.Blue;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(149, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 40);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // vbtMaNV
            // 
            this.vbtMaNV.BackColor = System.Drawing.SystemColors.Window;
            this.vbtMaNV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.vbtMaNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.vbtMaNV.BorderRadius = 15;
            this.vbtMaNV.BorderSize = 2;
            this.vbtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vbtMaNV.Location = new System.Drawing.Point(200, 151);
            this.vbtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.vbtMaNV.Multiline = false;
            this.vbtMaNV.Name = "vbtMaNV";
            this.vbtMaNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.vbtMaNV.PasswordChar = false;
            this.vbtMaNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.vbtMaNV.PlaceholderText = "";
            this.vbtMaNV.Size = new System.Drawing.Size(174, 35);
            this.vbtMaNV.TabIndex = 2;
            this.vbtMaNV.Texts = "";
            this.vbtMaNV.UnderlinedStyle = false;
            // 
            // vbtMaHoaDon
            // 
            this.vbtMaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.vbtMaHoaDon.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.vbtMaHoaDon.BorderFocusColor = System.Drawing.Color.HotPink;
            this.vbtMaHoaDon.BorderRadius = 15;
            this.vbtMaHoaDon.BorderSize = 2;
            this.vbtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vbtMaHoaDon.Location = new System.Drawing.Point(200, 86);
            this.vbtMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.vbtMaHoaDon.Multiline = false;
            this.vbtMaHoaDon.Name = "vbtMaHoaDon";
            this.vbtMaHoaDon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.vbtMaHoaDon.PasswordChar = false;
            this.vbtMaHoaDon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.vbtMaHoaDon.PlaceholderText = "";
            this.vbtMaHoaDon.Size = new System.Drawing.Size(174, 35);
            this.vbtMaHoaDon.TabIndex = 1;
            this.vbtMaHoaDon.Texts = "";
            this.vbtMaHoaDon.UnderlinedStyle = false;
            // 
            // frmHoaDonDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datNgayLap);
            this.Controls.Add(this.vbtTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHoaDonDV);
            this.Controls.Add(this.vbtMaNV);
            this.Controls.Add(this.vbtMaHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDonDichVu";
            this.Text = "Hóa Đơn Dịch Vụ";
            this.Load += new System.EventHandler(this.frmHoaDonDichVu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Components.VBTextBox vbtMaHoaDon;
        private Components.VBTextBox vbtMaNV;
        private System.Windows.Forms.DataGridView dgvHoaDonDV;
        private Components.VBButton btnThem;
        private Components.VBButton btnXoa;
        private Components.VBButton btnSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Components.VBTextBox vbtTongTien;
        private System.Windows.Forms.DateTimePicker datNgayLap;
    }
}