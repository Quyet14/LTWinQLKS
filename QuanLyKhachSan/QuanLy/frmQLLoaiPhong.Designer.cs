namespace QuanLyKhachSan.QuanLy
{
    partial class frmQLLoaiPhong
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
            this.components = new System.ComponentModel.Container();
            this.dgvRoomType = new System.Windows.Forms.DataGridView();
            this.colMaLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTLP = new QuanLyKhachSan.Components.VBTextBox();
            this.txtMLP = new QuanLyKhachSan.Components.VBTextBox();
            this.btnDelete = new QuanLyKhachSan.Components.VBButton();
            this.btnAddOrUpdate = new QuanLyKhachSan.Components.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoomType
            // 
            this.dgvRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRoomType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLP,
            this.colTenLP});
            this.dgvRoomType.Location = new System.Drawing.Point(60, 230);
            this.dgvRoomType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRoomType.Name = "dgvRoomType";
            this.dgvRoomType.RowHeadersWidth = 72;
            this.dgvRoomType.RowTemplate.Height = 31;
            this.dgvRoomType.Size = new System.Drawing.Size(541, 235);
            this.dgvRoomType.TabIndex = 0;
            this.dgvRoomType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomType_CellContentClick);
            // 
            // colMaLP
            // 
            this.colMaLP.HeaderText = "Mã Loại Phòng";
            this.colMaLP.MinimumWidth = 9;
            this.colMaLP.Name = "colMaLP";
            // 
            // colTenLP
            // 
            this.colTenLP.HeaderText = "Tên Loại Phòng";
            this.colTenLP.MinimumWidth = 9;
            this.colTenLP.Name = "colTenLP";
            // 
            // lblMa
            // 
            this.lblMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(55, 95);
            this.lblMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(144, 25);
            this.lblMa.TabIndex = 6;
            this.lblMa.Text = "Mã Loại Phòng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên loại phòng";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtTLP
            // 
            this.txtTLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTLP.BackColor = System.Drawing.SystemColors.Window;
            this.txtTLP.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTLP.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTLP.BorderRadius = 15;
            this.txtTLP.BorderSize = 2;
            this.txtTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTLP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTLP.Location = new System.Drawing.Point(234, 147);
            this.txtTLP.Multiline = false;
            this.txtTLP.Name = "txtTLP";
            this.txtTLP.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtTLP.PasswordChar = false;
            this.txtTLP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTLP.PlaceholderText = "";
            this.txtTLP.Size = new System.Drawing.Size(238, 36);
            this.txtTLP.TabIndex = 5;
            this.txtTLP.Texts = "";
            this.txtTLP.UnderlinedStyle = false;
            // 
            // txtMLP
            // 
            this.txtMLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMLP.BackColor = System.Drawing.SystemColors.Window;
            this.txtMLP.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMLP.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMLP.BorderRadius = 15;
            this.txtMLP.BorderSize = 2;
            this.txtMLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMLP.Location = new System.Drawing.Point(234, 95);
            this.txtMLP.Multiline = false;
            this.txtMLP.Name = "txtMLP";
            this.txtMLP.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtMLP.PasswordChar = false;
            this.txtMLP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMLP.PlaceholderText = "";
            this.txtMLP.Size = new System.Drawing.Size(238, 36);
            this.txtMLP.TabIndex = 4;
            this.txtMLP.Texts = "";
            this.txtMLP.UnderlinedStyle = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(487, 147);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOrUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddOrUpdate.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddOrUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddOrUpdate.BorderRadius = 15;
            this.btnAddOrUpdate.BorderSize = 0;
            this.btnAddOrUpdate.FlatAppearance.BorderSize = 0;
            this.btnAddOrUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrUpdate.ForeColor = System.Drawing.Color.White;
            this.btnAddOrUpdate.Location = new System.Drawing.Point(487, 95);
            this.btnAddOrUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(115, 31);
            this.btnAddOrUpdate.TabIndex = 1;
            this.btnAddOrUpdate.Text = "Thêm/Sửa";
            this.btnAddOrUpdate.TextColor = System.Drawing.Color.White;
            this.btnAddOrUpdate.UseVisualStyleBackColor = false;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // frmQLLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtTLP);
            this.Controls.Add(this.txtMLP);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.dgvRoomType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQLLoaiPhong";
            this.Text = "Quản Lý Loại Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomType;
        private Components.VBButton btnAddOrUpdate;
        private Components.VBButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLP;
        private Components.VBTextBox txtMLP;
        private Components.VBTextBox txtTLP;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider err;
    }
}