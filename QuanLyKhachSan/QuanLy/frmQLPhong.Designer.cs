namespace QuanLyKhachSan.QuanLy
{
    partial class frmQLPhong
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
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.colMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddorUpdate = new QuanLyKhachSan.Components.VBButton();
            this.btnSearch = new QuanLyKhachSan.Components.VBButton();
            this.cmbTLP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtPrice = new QuanLyKhachSan.Components.VBTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTLP1 = new System.Windows.Forms.ComboBox();
            this.checkEmpty = new System.Windows.Forms.CheckBox();
            this.txtMTP = new QuanLyKhachSan.Components.VBTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoom
            // 
            this.dgvRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMP,
            this.colTLP,
            this.colPrice,
            this.colStatus});
            this.dgvRoom.Location = new System.Drawing.Point(11, 239);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 72;
            this.dgvRoom.RowTemplate.Height = 31;
            this.dgvRoom.Size = new System.Drawing.Size(928, 230);
            this.dgvRoom.TabIndex = 0;
            this.dgvRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellContentClick);
            // 
            // colMP
            // 
            this.colMP.HeaderText = "Mã Phòng";
            this.colMP.MinimumWidth = 9;
            this.colMP.Name = "colMP";
            // 
            // colTLP
            // 
            this.colTLP.HeaderText = "Tên Loại Phòng";
            this.colTLP.MinimumWidth = 9;
            this.colTLP.Name = "colTLP";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá Phòng";
            this.colPrice.MinimumWidth = 9;
            this.colPrice.Name = "colPrice";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Tình trạng";
            this.colStatus.MinimumWidth = 9;
            this.colStatus.Name = "colStatus";
            // 
            // btnAddorUpdate
            // 
            this.btnAddorUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddorUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnAddorUpdate.BackgroundColor = System.Drawing.Color.Blue;
            this.btnAddorUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddorUpdate.BorderRadius = 15;
            this.btnAddorUpdate.BorderSize = 0;
            this.btnAddorUpdate.FlatAppearance.BorderSize = 0;
            this.btnAddorUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddorUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddorUpdate.ForeColor = System.Drawing.Color.White;
            this.btnAddorUpdate.Location = new System.Drawing.Point(124, 188);
            this.btnAddorUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddorUpdate.Name = "btnAddorUpdate";
            this.btnAddorUpdate.Size = new System.Drawing.Size(124, 33);
            this.btnAddorUpdate.TabIndex = 1;
            this.btnAddorUpdate.Text = "Thêm/Sửa";
            this.btnAddorUpdate.TextColor = System.Drawing.Color.White;
            this.btnAddorUpdate.UseVisualStyleBackColor = false;
            this.btnAddorUpdate.Click += new System.EventHandler(this.btnAddorUpdate_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(491, 188);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbTLP
            // 
            this.cmbTLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTLP.FormattingEnabled = true;
            this.cmbTLP.Location = new System.Drawing.Point(625, 53);
            this.cmbTLP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTLP.Name = "cmbTLP";
            this.cmbTLP.Size = new System.Drawing.Size(229, 33);
            this.cmbTLP.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Loại phòng";
            // 
            // lblMa
            // 
            this.lblMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(96, 53);
            this.lblMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(88, 22);
            this.lblMa.TabIndex = 12;
            this.lblMa.Text = "Mã phòng";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrice.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrice.BorderRadius = 20;
            this.txtPrice.BorderSize = 2;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(204, 111);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.Size = new System.Drawing.Size(228, 36);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giá phòng";
            // 
            // cmbTLP1
            // 
            this.cmbTLP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTLP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTLP1.FormattingEnabled = true;
            this.cmbTLP1.Location = new System.Drawing.Point(293, 189);
            this.cmbTLP1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTLP1.Name = "cmbTLP1";
            this.cmbTLP1.Size = new System.Drawing.Size(139, 33);
            this.cmbTLP1.TabIndex = 15;
            // 
            // checkEmpty
            // 
            this.checkEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkEmpty.AutoSize = true;
            this.checkEmpty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEmpty.Location = new System.Drawing.Point(662, 192);
            this.checkEmpty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkEmpty.Name = "checkEmpty";
            this.checkEmpty.Size = new System.Drawing.Size(125, 26);
            this.checkEmpty.TabIndex = 16;
            this.checkEmpty.Text = "Phòng trống";
            this.checkEmpty.UseVisualStyleBackColor = true;
            this.checkEmpty.CheckedChanged += new System.EventHandler(this.checkEmpty_CheckedChanged);
            // 
            // txtMTP
            // 
            this.txtMTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMTP.BackColor = System.Drawing.SystemColors.Window;
            this.txtMTP.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtMTP.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMTP.BorderRadius = 20;
            this.txtMTP.BorderSize = 2;
            this.txtMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMTP.Location = new System.Drawing.Point(204, 50);
            this.txtMTP.Multiline = false;
            this.txtMTP.Name = "txtMTP";
            this.txtMTP.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtMTP.PasswordChar = false;
            this.txtMTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMTP.PlaceholderText = "";
            this.txtMTP.Size = new System.Drawing.Size(228, 36);
            this.txtMTP.TabIndex = 17;
            this.txtMTP.Texts = "";
            this.txtMTP.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tình trạng phòng";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(625, 111);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(229, 33);
            this.cmbStatus.TabIndex = 18;
            // 
            // frmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtMTP);
            this.Controls.Add(this.checkEmpty);
            this.Controls.Add(this.cmbTLP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbTLP);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddorUpdate);
            this.Controls.Add(this.dgvRoom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQLPhong";
            this.Text = "Quản lý Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoom;
        private Components.VBButton btnAddorUpdate;
        private Components.VBButton btnSearch;
        private System.Windows.Forms.ComboBox cmbTLP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMa;
        private Components.VBTextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTLP1;
        private System.Windows.Forms.CheckBox checkEmpty;
        private Components.VBTextBox txtMTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}