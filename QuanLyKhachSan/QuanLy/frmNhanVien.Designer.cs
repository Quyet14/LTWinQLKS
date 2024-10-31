namespace QuanLyKhachSan.QuanLy
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
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.txtCMND = new QuanLyKhachSan.Components.VBTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new QuanLyKhachSan.Components.VBTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatKhau = new QuanLyKhachSan.Components.VBTextBox();
            this.btnActive = new QuanLyKhachSan.Components.VBButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnSua = new QuanLyKhachSan.Components.VBButton();
            this.lblGender = new System.Windows.Forms.Label();
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
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbQuyen);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.btnActive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";

            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(406, 677);

            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cmbQuyen.Location = new System.Drawing.Point(163, 535);
            this.cmbQuyen.Margin = new System.Windows.Forms.Padding(5);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(212, 32);
            this.cmbQuyen.TabIndex = 25;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.SystemColors.Window;
            this.txtCMND.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCMND.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCMND.BorderRadius = 10;
            this.txtCMND.BorderSize = 2;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCMND.Location = new System.Drawing.Point(163, 462);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(7);
            this.txtCMND.Multiline = false;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtCMND.PasswordChar = false;
            this.txtCMND.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCMND.PlaceholderText = "";
            this.txtCMND.Size = new System.Drawing.Size(212, 46);
            this.txtCMND.TabIndex = 24;
            this.txtCMND.Texts = "";
            this.txtCMND.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 483);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "CMND";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEmail.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(163, 271);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(212, 46);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 538);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quyền";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatKhau.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMatKhau.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMatKhau.BorderRadius = 10;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.Location = new System.Drawing.Point(163, 398);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(7);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtMatKhau.PasswordChar = true;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(212, 46);
            this.txtMatKhau.TabIndex = 19;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = false;
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnActive.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnActive.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActive.BorderRadius = 10;
            this.btnActive.BorderSize = 0;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(149, 614);
            this.btnActive.Margin = new System.Windows.Forms.Padding(4);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(102, 42);
            this.btnActive.TabIndex = 12;
            this.btnActive.Text = "Activate";
            this.btnActive.TextColor = System.Drawing.Color.White;
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 419);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mật Khẩu";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(311, 171);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(5);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(62, 29);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(163, 171);
            this.rbMale.Margin = new System.Windows.Forms.Padding(5);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(78, 29);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(273, 614);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 42);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(7, 173);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(82, 25);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Giới tính";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(12, 614);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 42);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDiaChi.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDiaChi.BorderRadius = 10;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.Location = new System.Drawing.Point(163, 334);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(7);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(210, 46);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDT.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSDT.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSDT.BorderRadius = 10;
            this.txtSDT.BorderSize = 2;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSDT.Location = new System.Drawing.Point(163, 211);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(7);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.Size = new System.Drawing.Size(212, 46);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = false;
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoten.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtHoten.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtHoten.BorderRadius = 10;
            this.txtHoten.BorderSize = 2;
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoten.Location = new System.Drawing.Point(163, 107);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(7);
            this.txtHoten.Multiline = false;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtHoten.PasswordChar = false;
            this.txtHoten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHoten.PlaceholderText = "";
            this.txtHoten.Size = new System.Drawing.Size(210, 46);
            this.txtHoten.TabIndex = 2;
            this.txtHoten.Texts = "";
            this.txtHoten.UnderlinedStyle = false;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNhanVien.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaNhanVien.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaNhanVien.BorderRadius = 10;
            this.txtMaNhanVien.BorderSize = 2;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaNhanVien.Location = new System.Drawing.Point(163, 43);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaNhanVien.Multiline = false;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.txtMaNhanVien.PasswordChar = false;
            this.txtMaNhanVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNhanVien.PlaceholderText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(210, 46);
            this.txtMaNhanVien.TabIndex = 1;
            this.txtMaNhanVien.Texts = "";
            this.txtMaNhanVien.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 355);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.CMND,
            this.Column7});
            this.dgvNhanVien.Location = new System.Drawing.Point(494, 122);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1216, 452);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 9;
            this.Column6.Name = "Column6";
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 9;
            this.CMND.Name = "CMND";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "perm";
            this.Column7.MinimumWidth = 9;
            this.Column7.Name = "Column7";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1759, 793);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private QuanLyKhachSan.Components.VBButton btnSua;
        private QuanLyKhachSan.Components.VBButton btnActive;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Components.VBTextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Components.VBTextBox txtCMND;
        private System.Windows.Forms.ComboBox cmbQuyen;
    }
}