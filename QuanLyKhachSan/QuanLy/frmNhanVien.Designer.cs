namespace NguyenKhanhLong_qlks
{
    partial class frmNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new QuanLyKhachSan.Components.VBButton();
            this.btnLuu = new QuanLyKhachSan.Components.VBButton();
            this.btnThem = new QuanLyKhachSan.Components.VBButton();
            this.txtDiaChi = new QuanLyKhachSan.Components.VBTextBox();
            this.txtSDT = new QuanLyKhachSan.Components.VBTextBox();
            this.txtHoten = new QuanLyKhachSan.Components.VBTextBox();
            this.txtMaNhanVien = new QuanLyKhachSan.Components.VBTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new QuanLyKhachSan.Components.VBTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbQuyen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(207, 373);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(69, 344);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 25);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(129, 309);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 24);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(10, 309);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(58, 24);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderRadius = 10;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.Location = new System.Drawing.Point(78, 176);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(116, 29);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSDT.BorderRadius = 10;
            this.txtSDT.BorderSize = 2;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSDT.Location = new System.Drawing.Point(77, 133);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.Size = new System.Drawing.Size(116, 29);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = false;
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoten.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHoten.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoten.BorderRadius = 10;
            this.txtHoten.BorderSize = 2;
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoten.Location = new System.Drawing.Point(78, 60);
            this.txtHoten.Multiline = false;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtHoten.PasswordChar = false;
            this.txtHoten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHoten.PlaceholderText = "";
            this.txtHoten.Size = new System.Drawing.Size(116, 29);
            this.txtHoten.TabIndex = 2;
            this.txtHoten.Texts = "";
            this.txtHoten.UnderlinedStyle = false;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNhanVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaNhanVien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaNhanVien.BorderRadius = 10;
            this.txtMaNhanVien.BorderSize = 2;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaNhanVien.Location = new System.Drawing.Point(78, 25);
            this.txtMaNhanVien.Multiline = false;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtMaNhanVien.PasswordChar = false;
            this.txtMaNhanVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNhanVien.PlaceholderText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(116, 29);
            this.txtMaNhanVien.TabIndex = 1;
            this.txtMaNhanVien.Texts = "";
            this.txtMaNhanVien.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvNhanVien.Location = new System.Drawing.Point(237, 72);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(434, 258);
            this.dgvNhanVien.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý Nhân Viên";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(146, 99);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(39, 17);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(78, 97);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(7, 99);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 13);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatKhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.BorderRadius = 10;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.Location = new System.Drawing.Point(77, 228);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(116, 29);
            this.txtMatKhau.TabIndex = 19;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quyền";
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân Viên"});
            this.cmbQuyen.Location = new System.Drawing.Point(77, 278);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(121, 21);
            this.cmbQuyen.TabIndex = 21;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 439);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private QuanLyKhachSan.Components.VBButton btnSua;
        private QuanLyKhachSan.Components.VBButton btnLuu;
        private QuanLyKhachSan.Components.VBButton btnThem;
        private QuanLyKhachSan.Components.VBTextBox txtDiaChi;
        private QuanLyKhachSan.Components.VBTextBox txtSDT;
        private QuanLyKhachSan.Components.VBTextBox txtHoten;
        private QuanLyKhachSan.Components.VBTextBox txtMaNhanVien;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label4;
        private QuanLyKhachSan.Components.VBTextBox txtMatKhau;
        private System.Windows.Forms.ComboBox cmbQuyen;
        private System.Windows.Forms.Label label6;
    }
}