namespace QuanLyKhachSan.NhanVien
{
    partial class frmQuanLyKhachHang
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThemSua = new QuanLyKhachSan.Components.VBButton();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.colStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtCMND = new QuanLyKhachSan.Components.VBTextBox();
            this.txtEmail = new QuanLyKhachSan.Components.VBTextBox();
            this.txtSDT = new QuanLyKhachSan.Components.VBTextBox();
            this.txtDiaChi = new QuanLyKhachSan.Components.VBTextBox();
            this.txtHoTen = new QuanLyKhachSan.Components.VBTextBox();
            this.txtMaKhachHang = new QuanLyKhachSan.Components.VBTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(637, 37);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(555, 46);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "DANH SACH KHACH HANG";
            // 
            // btnThemSua
            // 
            this.btnThemSua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThemSua.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnThemSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemSua.BorderRadius = 20;
            this.btnThemSua.BorderSize = 0;
            this.btnThemSua.FlatAppearance.BorderSize = 0;
            this.btnThemSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSua.ForeColor = System.Drawing.Color.White;
            this.btnThemSua.Location = new System.Drawing.Point(152, 480);
            this.btnThemSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(200, 49);
            this.btnThemSua.TabIndex = 33;
            this.btnThemSua.Text = "Them/Sua";
            this.btnThemSua.TextColor = System.Drawing.Color.White;
            this.btnThemSua.UseVisualStyleBackColor = false;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentId,
            this.colFullName,
            this.colGender,
            this.DiaChi,
            this.colAverageScore,
            this.colMajor,
            this.CMND});
            this.dgvKhachHang.Location = new System.Drawing.Point(532, 100);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 72;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(807, 305);
            this.dgvKhachHang.TabIndex = 32;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // colStudentId
            // 
            this.colStudentId.HeaderText = "MaKhachHang";
            this.colStudentId.MinimumWidth = 9;
            this.colStudentId.Name = "colStudentId";
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Họ và tên";
            this.colFullName.MinimumWidth = 9;
            this.colFullName.Name = "colFullName";
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Giới tính";
            this.colGender.MinimumWidth = 9;
            this.colGender.Name = "colGender";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // colAverageScore
            // 
            this.colAverageScore.HeaderText = "SĐT";
            this.colAverageScore.MinimumWidth = 9;
            this.colAverageScore.Name = "colAverageScore";
            // 
            // colMajor
            // 
            this.colMajor.HeaderText = "Email";
            this.colMajor.MinimumWidth = 9;
            this.colMajor.Name = "colMajor";
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.txtCMND);
            this.grbStudentInfo.Controls.Add(this.txtEmail);
            this.grbStudentInfo.Controls.Add(this.txtSDT);
            this.grbStudentInfo.Controls.Add(this.txtDiaChi);
            this.grbStudentInfo.Controls.Add(this.txtHoTen);
            this.grbStudentInfo.Controls.Add(this.txtMaKhachHang);
            this.grbStudentInfo.Controls.Add(this.label2);
            this.grbStudentInfo.Controls.Add(this.label1);
            this.grbStudentInfo.Controls.Add(this.rbFemale);
            this.grbStudentInfo.Controls.Add(this.rbMale);
            this.grbStudentInfo.Controls.Add(this.lblMajor);
            this.grbStudentInfo.Controls.Add(this.lblDTB);
            this.grbStudentInfo.Controls.Add(this.lblGender);
            this.grbStudentInfo.Controls.Add(this.lblTenSV);
            this.grbStudentInfo.Controls.Add(this.lblMaSV);
            this.grbStudentInfo.Location = new System.Drawing.Point(31, 60);
            this.grbStudentInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbStudentInfo.Size = new System.Drawing.Size(455, 400);
            this.grbStudentInfo.TabIndex = 31;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Thông tin khách hàng";
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.SystemColors.Window;
            this.txtCMND.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCMND.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCMND.BorderRadius = 10;
            this.txtCMND.BorderSize = 2;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCMND.Location = new System.Drawing.Point(176, 318);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCMND.Multiline = false;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtCMND.PasswordChar = false;
            this.txtCMND.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCMND.PlaceholderText = "";
            this.txtCMND.Size = new System.Drawing.Size(193, 39);
            this.txtCMND.TabIndex = 24;
            this.txtCMND.Texts = "";
            this.txtCMND.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(176, 256);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(193, 39);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
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
            this.txtSDT.Location = new System.Drawing.Point(176, 203);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.Size = new System.Drawing.Size(193, 39);
            this.txtSDT.TabIndex = 22;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = false;
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
            this.txtDiaChi.Location = new System.Drawing.Point(176, 155);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(193, 39);
            this.txtDiaChi.TabIndex = 21;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoTen.BorderRadius = 10;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTen.Location = new System.Drawing.Point(176, 60);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.Size = new System.Drawing.Size(193, 39);
            this.txtHoTen.TabIndex = 20;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = false;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKhachHang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaKhachHang.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaKhachHang.BorderRadius = 10;
            this.txtMaKhachHang.BorderSize = 2;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaKhachHang.Location = new System.Drawing.Point(176, 12);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaKhachHang.Multiline = false;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtMaKhachHang.PasswordChar = false;
            this.txtMaKhachHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKhachHang.PlaceholderText = "";
            this.txtMaKhachHang.Size = new System.Drawing.Size(193, 39);
            this.txtMaKhachHang.TabIndex = 19;
            this.txtMaKhachHang.Texts = "";
            this.txtMaKhachHang.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "CMND";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(283, 118);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(45, 20);
            this.rbFemale.TabIndex = 14;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(176, 118);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 20);
            this.rbMale.TabIndex = 13;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(28, 267);
            this.lblMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(41, 16);
            this.lblMajor.TabIndex = 4;
            this.lblMajor.Text = "Email";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(25, 214);
            this.lblDTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(85, 16);
            this.lblDTB.TabIndex = 3;
            this.lblDTB.Text = "Số điện thoại";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(28, 123);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Giới tính";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(27, 166);
            this.lblTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(47, 16);
            this.lblTenSV.TabIndex = 1;
            this.lblTenSV.Text = "Địa chỉ";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(25, 71);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(128, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Họ Tên Khách Hàng";
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 566);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.grbStudentInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyKhachHang";
            this.Text = "frmQuanLyKhachSan";
            this.Load += new System.EventHandler(this.frmQuanLyKhachSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Components.VBButton btnThemSua;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.GroupBox grbStudentInfo;
        private Components.VBTextBox txtCMND;
        private Components.VBTextBox txtEmail;
        private Components.VBTextBox txtSDT;
        private Components.VBTextBox txtDiaChi;
        private Components.VBTextBox txtHoTen;
        private Components.VBTextBox txtMaKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblMaSV;
    }
}