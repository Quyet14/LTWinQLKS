namespace QuanLyKhachSan
{
    partial class DangNhap
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
            this.btnDangNhap = new QuanLyKhachSan.Components.VBButton();
            this.txtPassword = new QuanLyKhachSan.Components.VBTextBox();
            this.txtUsername = new QuanLyKhachSan.Components.VBTextBox();
            this.btnThoat = new QuanLyKhachSan.Components.VBButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(264, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông Tin Đăng Nhập";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDangNhap.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDangNhap.BorderColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BorderRadius = 20;
            this.btnDangNhap.BorderSize = 1;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(252, 392);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(164, 50);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextColor = System.Drawing.Color.White;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(374, 299);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(334, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.White;
            this.txtUsername.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857142F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(374, 221);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(334, 31);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoat.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoat.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoat.BorderRadius = 20;
            this.btnThoat.BorderSize = 1;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(544, 392);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 50);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(951, 546);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Components.VBButton btnThoat;
        private Components.VBTextBox txtUsername;
        private Components.VBTextBox txtPassword;
        private Components.VBButton btnDangNhap;
    }
}