namespace QuanLyKhachSan
{
    partial class frmHoaDon
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
        //
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPhong1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDatDV = new QuanLyKhachSan.Components.VBButton();
            this.colMaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong1
            // 
            this.dgvPhong1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.column3,
            this.Column4,
            this.Column5});
            this.dgvPhong1.Location = new System.Drawing.Point(74, 69);
            this.dgvPhong1.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhong1.Name = "dgvPhong1";
            this.dgvPhong1.RowHeadersWidth = 51;
            this.dgvPhong1.RowTemplate.Height = 24;
            this.dgvPhong1.Size = new System.Drawing.Size(500, 197);
            this.dgvPhong1.TabIndex = 0;
            this.dgvPhong1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phiếu";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Phòng";
            this.Column2.Name = "Column2";
            // 
            // column3
            // 
            this.column3.HeaderText = "Ngày Đặt Phòng";
            this.column3.Name = "column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Trả Phòng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tổng Tiền";
            this.Column5.Name = "Column5";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDichVu,
            this.colTenDichVu,
            this.colGiaDichVu,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvDichVu.Location = new System.Drawing.Point(74, 296);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(500, 176);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(231, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dịch  Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng";
            // 
            // btnDatDV
            // 
            this.btnDatDV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDatDV.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDatDV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDatDV.BorderRadius = 20;
            this.btnDatDV.BorderSize = 0;
            this.btnDatDV.FlatAppearance.BorderSize = 0;
            this.btnDatDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatDV.ForeColor = System.Drawing.Color.White;
            this.btnDatDV.Location = new System.Drawing.Point(237, 494);
            this.btnDatDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatDV.Name = "btnDatDV";
            this.btnDatDV.Size = new System.Drawing.Size(112, 32);
            this.btnDatDV.TabIndex = 3;
            this.btnDatDV.Text = "Đặt Dịch Vụ";
            this.btnDatDV.TextColor = System.Drawing.Color.White;
            this.btnDatDV.UseVisualStyleBackColor = false;
            this.btnDatDV.Click += new System.EventHandler(this.btnDatDV_Click);
            // 
            // colMaDichVu
            // 
            this.colMaDichVu.HeaderText = "Mã Chi Tiết Dịch Vụ";
            this.colMaDichVu.MinimumWidth = 6;
            this.colMaDichVu.Name = "colMaDichVu";
            // 
            // colTenDichVu
            // 
            this.colTenDichVu.HeaderText = "Mã hóa đơn";
            this.colTenDichVu.MinimumWidth = 6;
            this.colTenDichVu.Name = "colTenDichVu";
            // 
            // colGiaDichVu
            // 
            this.colGiaDichVu.HeaderText = "Mã dịch vụ";
            this.colGiaDichVu.MinimumWidth = 6;
            this.colGiaDichVu.Name = "colGiaDichVu";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số lượng";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Đơn giá";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Thành tiền";
            this.Column8.Name = "Column8";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDatDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.dgvPhong1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong1;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Label label1;
        private Components.VBButton btnDatDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}