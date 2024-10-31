namespace QuanLyKhachSan.NhanVien
{
    partial class frmDatPhong
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
            this.Giá = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnExit = new QuanLyKhachSan.Components.VBButton();
            this.btnSave = new QuanLyKhachSan.Components.VBButton();
            this.txtPrice = new QuanLyKhachSan.Components.VBTextBox();
            this.txtCustomerName = new QuanLyKhachSan.Components.VBTextBox();
            this.txtTenNV = new QuanLyKhachSan.Components.VBTextBox();
            this.btnSearch = new QuanLyKhachSan.Components.VBButton();
            this.txtCustomerId = new QuanLyKhachSan.Components.VBTextBox();
            this.btnCheckOut = new QuanLyKhachSan.Components.VBButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // Giá
            // 
            this.Giá.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Giá.AutoSize = true;
            this.Giá.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giá.Location = new System.Drawing.Point(624, 227);
            this.Giá.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Giá.Name = "Giá";
            this.Giá.Size = new System.Drawing.Size(60, 41);
            this.Giá.TabIndex = 0;
            this.Giá.Text = "Giá";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày trả";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.CustomFormat = "dd/MM/yyyy HH";
            this.dtpCheckOut.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(632, 181);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckOut.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOut.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(272, 42);
            this.dtpCheckOut.TabIndex = 7;
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Quicksand", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRoom.Location = new System.Drawing.Point(454, 48);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(201, 83);
            this.lblRoom.TabIndex = 9;
            this.lblRoom.Text = "Phòng";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(743, 473);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 50);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(347, 473);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 50);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Đặt";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrice.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrice.BorderRadius = 20;
            this.txtPrice.BorderSize = 2;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(632, 273);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.Size = new System.Drawing.Size(271, 56);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerName.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCustomerName.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCustomerName.BorderRadius = 20;
            this.txtCustomerName.BorderSize = 2;
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCustomerName.Location = new System.Drawing.Point(137, 273);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCustomerName.PasswordChar = false;
            this.txtCustomerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(271, 56);
            this.txtCustomerName.TabIndex = 3;
            this.txtCustomerName.Texts = "";
            this.txtCustomerName.UnderlinedStyle = false;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenNV.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTenNV.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTenNV.BorderRadius = 20;
            this.txtTenNV.BorderSize = 2;
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNV.Location = new System.Drawing.Point(137, 377);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNV.Multiline = false;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTenNV.PasswordChar = false;
            this.txtTenNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.Size = new System.Drawing.Size(271, 56);
            this.txtTenNV.TabIndex = 4;
            this.txtTenNV.Texts = "";
            this.txtTenNV.UnderlinedStyle = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(137, 473);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerId.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerId.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCustomerId.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCustomerId.BorderRadius = 20;
            this.txtCustomerId.BorderSize = 2;
            this.txtCustomerId.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCustomerId.Location = new System.Drawing.Point(137, 166);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerId.Multiline = false;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCustomerId.PasswordChar = false;
            this.txtCustomerId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerId.PlaceholderText = "";
            this.txtCustomerId.Size = new System.Drawing.Size(271, 56);
            this.txtCustomerId.TabIndex = 1;
            this.txtCustomerId.Texts = "";
            this.txtCustomerId.UnderlinedStyle = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCheckOut.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCheckOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCheckOut.BorderRadius = 20;
            this.btnCheckOut.BorderSize = 0;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(555, 473);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(160, 50);
            this.btnCheckOut.TabIndex = 11;
            this.btnCheckOut.Text = "Trả phòng";
            this.btnCheckOut.TextColor = System.Drawing.Color.White;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 636);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Giá);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDatPhong";
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Giá;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Components.VBButton btnSearch;
        private Components.VBTextBox txtCustomerId;
        private Components.VBTextBox txtTenNV;
        private Components.VBTextBox txtCustomerName;
        private Components.VBTextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private Components.VBButton btnSave;
        private System.Windows.Forms.Label lblRoom;
        private Components.VBButton btnExit;
        private Components.VBButton btnCheckOut;
    }
}