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
            // btnThemSua
            // 
            this.btnThemSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemSua.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemSua.BorderRadius = 20;
            this.btnThemSua.BorderSize = 0;
            this.btnThemSua.FlatAppearance.BorderSize = 0;
            this.btnThemSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSua.ForeColor = System.Drawing.Color.White;
            this.btnThemSua.Location = new System.Drawing.Point(114, 390);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(150, 40);
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
            this.dgvKhachHang.Location = new System.Drawing.Point(399, 81);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 72;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(605, 248);
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
            this.grbStudentInfo.Location = new System.Drawing.Point(23, 49);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(341, 325);
            this.grbStudentInfo.TabIndex = 31;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Thông tin khách hàng";
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.SystemColors.Window;
            this.txtCMND.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCMND.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCMND.BorderRadius = 10;
            this.txtCMND.BorderSize = 2;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCMND.Location = new System.Drawing.Point(132, 258);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Multiline = false;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCMND.PasswordChar = false;
            this.txtCMND.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCMND.PlaceholderText = "";
            this.txtCMND.Size = new System.Drawing.Size(145, 31);
            this.txtCMND.TabIndex = 24;
            this.txtCMND.Texts = "";
            this.txtCMND.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEmail.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(132, 208);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(145, 31);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDT.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSDT.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSDT.BorderRadius = 10;
            this.txtSDT.BorderSize = 2;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSDT.Location = new System.Drawing.Point(132, 165);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.Size = new System.Drawing.Size(145, 31);
            this.txtSDT.TabIndex = 22;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDiaChi.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDiaChi.BorderRadius = 10;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.Location = new System.Drawing.Point(132, 126);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(145, 31);
            this.txtDiaChi.TabIndex = 21;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtHoTen.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtHoTen.BorderRadius = 10;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTen.Location = new System.Drawing.Point(132, 49);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.Size = new System.Drawing.Size(145, 31);
            this.txtHoTen.TabIndex = 20;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = false;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKhachHang.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaKhachHang.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaKhachHang.BorderRadius = 10;
            this.txtMaKhachHang.BorderSize = 2;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaKhachHang.Location = new System.Drawing.Point(132, 10);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhachHang.Multiline = false;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaKhachHang.PasswordChar = false;
            this.txtMaKhachHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKhachHang.PlaceholderText = "";
            this.txtMaKhachHang.Size = new System.Drawing.Size(145, 31);
            this.txtMaKhachHang.TabIndex = 19;
            this.txtMaKhachHang.Texts = "";
            this.txtMaKhachHang.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "CMND";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(212, 96);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(39, 17);
            this.rbFemale.TabIndex = 14;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(132, 96);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.TabIndex = 13;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(21, 217);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(32, 13);
            this.lblMajor.TabIndex = 4;
            this.lblMajor.Text = "Email";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(19, 174);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(70, 13);
            this.lblDTB.TabIndex = 3;
            this.lblDTB.Text = "Số điện thoại";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(21, 100);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Giới tính";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(20, 135);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(40, 13);
            this.lblTenSV.TabIndex = 1;
            this.lblTenSV.Text = "Địa chỉ";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(19, 58);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(106, 13);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Họ Tên Khách Hàng";
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1027, 460);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.grbStudentInfo);
            this.Name = "frmQuanLyKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmQuanLyKhachSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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