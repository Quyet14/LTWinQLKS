﻿namespace QuanLyKhachSan.QuanLy
{
    partial class frmQuanLyDanhGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRespond = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new QuanLyKhachSan.Components.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRespond
            // 
            this.dgvRespond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRespond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRespond.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRespond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespond.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colMaKH,
            this.colRating,
            this.colND,
            this.colDateSent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRespond.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRespond.Location = new System.Drawing.Point(11, 88);
            this.dgvRespond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRespond.Name = "dgvRespond";
            this.dgvRespond.RowHeadersWidth = 72;
            this.dgvRespond.RowTemplate.Height = 31;
            this.dgvRespond.Size = new System.Drawing.Size(926, 268);
            this.dgvRespond.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.FillWeight = 25F;
            this.colId.HeaderText = "Mã Phản Hồi";
            this.colId.MinimumWidth = 9;
            this.colId.Name = "colId";
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã Khách Hàng";
            this.colMaKH.MinimumWidth = 9;
            this.colMaKH.Name = "colMaKH";
            // 
            // colRating
            // 
            this.colRating.HeaderText = "Rating";
            this.colRating.MinimumWidth = 9;
            this.colRating.Name = "colRating";
            // 
            // colND
            // 
            this.colND.FillWeight = 125.3012F;
            this.colND.HeaderText = "Nội dung phản hồi";
            this.colND.MinimumWidth = 9;
            this.colND.Name = "colND";
            this.colND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colDateSent
            // 
            this.colDateSent.FillWeight = 125.3012F;
            this.colDateSent.HeaderText = "Ngày gửi";
            this.colDateSent.MinimumWidth = 9;
            this.colDateSent.Name = "colDateSent";
            // 
            // ratingBox
            // 
            this.ratingBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingBox.Location = new System.Drawing.Point(688, 31);
            this.ratingBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ratingBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(87, 30);
            this.ratingBox.TabIndex = 1;
            this.ratingBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(605, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rating";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.Blue;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(803, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmQuanLyDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 367);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.dgvRespond);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLyDanhGia";
            this.Text = "Quản Lý Đánh Giá";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRespond;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn colND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateSent;
        private System.Windows.Forms.NumericUpDown ratingBox;
        private System.Windows.Forms.Label label1;
        private Components.VBButton btnSearch;
    }
}