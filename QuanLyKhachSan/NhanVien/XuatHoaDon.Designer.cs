﻿namespace QuanLyKhachSan.NhanVien
{
    partial class XuatHoaDon
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
            this.txtMaKhachHang = new QuanLyKhachSan.Components.VBTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuat = new QuanLyKhachSan.Components.VBButton();
            this.SuspendLayout();
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKhachHang.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaKhachHang.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMaKhachHang.BorderRadius = 0;
            this.txtMaKhachHang.BorderSize = 2;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaKhachHang.Location = new System.Drawing.Point(566, 140);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtMaKhachHang.Multiline = false;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Padding = new System.Windows.Forms.Padding(18, 13, 18, 13);
            this.txtMaKhachHang.PasswordChar = false;
            this.txtMaKhachHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKhachHang.PlaceholderText = "";
            this.txtMaKhachHang.Size = new System.Drawing.Size(358, 56);
            this.txtMaKhachHang.TabIndex = 0;
            this.txtMaKhachHang.Texts = "";
            this.txtMaKhachHang.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.MaximumSize = new System.Drawing.Size(610, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXuat.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuat.BorderRadius = 20;
            this.btnXuat.BorderSize = 0;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(566, 266);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(275, 74);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất Hóa Đơn";
            this.btnXuat.TextColor = System.Drawing.Color.White;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // XuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKhachHang);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "XuatHoaDon";
            this.Text = "Xuất hoá đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.VBTextBox txtMaKhachHang;
        private System.Windows.Forms.Label label1;
        private Components.VBButton btnXuat;
    }
}