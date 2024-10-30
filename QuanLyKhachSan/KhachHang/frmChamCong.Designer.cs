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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vbtGioRa = new QuanLyKhachSan.Components.VBButton();
            this.vbtGioVao = new QuanLyKhachSan.Components.VBButton();
            this.vtbChamCong = new QuanLyKhachSan.Components.VBTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vtbMaCC = new QuanLyKhachSan.Components.VBTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Location = new System.Drawing.Point(12, 252);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(776, 186);
            this.dgvChamCong.TabIndex = 0;
            this.dgvChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Chấm Công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // vbtGioRa
            // 
            this.vbtGioRa.BackColor = System.Drawing.Color.MediumBlue;
            this.vbtGioRa.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.vbtGioRa.BorderColor = System.Drawing.Color.Transparent;
            this.vbtGioRa.BorderRadius = 20;
            this.vbtGioRa.BorderSize = 1;
            this.vbtGioRa.FlatAppearance.BorderSize = 0;
            this.vbtGioRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtGioRa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtGioRa.ForeColor = System.Drawing.SystemColors.Window;
            this.vbtGioRa.Location = new System.Drawing.Point(496, 189);
            this.vbtGioRa.Name = "vbtGioRa";
            this.vbtGioRa.Size = new System.Drawing.Size(150, 40);
            this.vbtGioRa.TabIndex = 3;
            this.vbtGioRa.Text = "Giờ Ra";
            this.vbtGioRa.TextColor = System.Drawing.SystemColors.Window;
            this.vbtGioRa.UseVisualStyleBackColor = false;
            this.vbtGioRa.Click += new System.EventHandler(this.vbtGioRa_Click_1);
            // 
            // vbtGioVao
            // 
            this.vbtGioVao.BackColor = System.Drawing.Color.MediumBlue;
            this.vbtGioVao.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.vbtGioVao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbtGioVao.BorderRadius = 20;
            this.vbtGioVao.BorderSize = 0;
            this.vbtGioVao.FlatAppearance.BorderSize = 0;
            this.vbtGioVao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtGioVao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtGioVao.ForeColor = System.Drawing.Color.White;
            this.vbtGioVao.Location = new System.Drawing.Point(165, 189);
            this.vbtGioVao.Name = "vbtGioVao";
            this.vbtGioVao.Size = new System.Drawing.Size(150, 40);
            this.vbtGioVao.TabIndex = 2;
            this.vbtGioVao.Text = "Giờ Vào";
            this.vbtGioVao.TextColor = System.Drawing.Color.White;
            this.vbtGioVao.UseVisualStyleBackColor = false;
            this.vbtGioVao.Click += new System.EventHandler(this.vbtGioVao_Click_1);
            // 
            // vtbChamCong
            // 
            this.vtbChamCong.BackColor = System.Drawing.SystemColors.Window;
            this.vtbChamCong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.vtbChamCong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.vtbChamCong.BorderRadius = 15;
            this.vtbChamCong.BorderSize = 2;
            this.vtbChamCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtbChamCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vtbChamCong.Location = new System.Drawing.Point(285, 136);
            this.vtbChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.vtbChamCong.Multiline = false;
            this.vtbChamCong.Name = "vtbChamCong";
            this.vtbChamCong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.vtbChamCong.PasswordChar = false;
            this.vtbChamCong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.vtbChamCong.PlaceholderText = "";
            this.vtbChamCong.Size = new System.Drawing.Size(299, 37);
            this.vtbChamCong.TabIndex = 1;
            this.vtbChamCong.Texts = "";
            this.vtbChamCong.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Chấm Công";
            // 
            // vtbMaCC
            // 
            this.vtbMaCC.BackColor = System.Drawing.SystemColors.Window;
            this.vtbMaCC.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.vtbMaCC.BorderFocusColor = System.Drawing.Color.HotPink;
            this.vtbMaCC.BorderRadius = 15;
            this.vtbMaCC.BorderSize = 2;
            this.vtbMaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtbMaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vtbMaCC.Location = new System.Drawing.Point(285, 81);
            this.vtbMaCC.Margin = new System.Windows.Forms.Padding(4);
            this.vtbMaCC.Multiline = false;
            this.vtbMaCC.Name = "vtbMaCC";
            this.vtbMaCC.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.vtbMaCC.PasswordChar = false;
            this.vtbMaCC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.vtbMaCC.PlaceholderText = "";
            this.vtbMaCC.Size = new System.Drawing.Size(299, 37);
            this.vtbMaCC.TabIndex = 5;
            this.vtbMaCC.Texts = "";
            this.vtbMaCC.UnderlinedStyle = false;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vtbMaCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vbtGioRa);
            this.Controls.Add(this.vbtGioVao);
            this.Controls.Add(this.vtbChamCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChamCong);
            this.Name = "frmChamCong";
            this.Text = "frmChamCong";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Components.VBTextBox vtbChamCong;
        private Components.VBButton vbtGioVao;
        private Components.VBButton vbtGioRa;
        private System.Windows.Forms.Label label3;
        private Components.VBTextBox vtbMaCC;
    }
}