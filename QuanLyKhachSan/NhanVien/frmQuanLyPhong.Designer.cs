using System.Data;

namespace QuanLyKhachSan.NhanVien
{
    partial class frmQuanLyPhong
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblBedType = new System.Windows.Forms.Label();
            this.cmbBedType = new System.Windows.Forms.ComboBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAdd = new QuanLyKhachSan.Components.VBButton();
            this.btnEdit = new QuanLyKhachSan.Components.VBButton();
            this.btnDelete = new QuanLyKhachSan.Components.VBButton();
            this.txtCustomerName = new QuanLyKhachSan.Components.VBTextBox();
            this.txtPhoneNumber = new QuanLyKhachSan.Components.VBTextBox();
            this.txtPrice = new QuanLyKhachSan.Components.VBTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(39, 49);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(160, 25);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Tên khách hàng:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(39, 116);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(132, 25);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(39, 188);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(115, 25);
            this.lblRoomType.TabIndex = 4;
            this.lblRoomType.Text = "Loại phòng:";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Single Bedroom",
            "Twin Bedroom",
            "Double Bedroom",
            "Triple Bedroom"});
            this.cmbRoomType.Location = new System.Drawing.Point(213, 182);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(325, 33);
            this.cmbRoomType.TabIndex = 3;
            // 
            // lblBedType
            // 
            this.lblBedType.AutoSize = true;
            this.lblBedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedType.Location = new System.Drawing.Point(39, 262);
            this.lblBedType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBedType.Name = "lblBedType";
            this.lblBedType.Size = new System.Drawing.Size(119, 25);
            this.lblBedType.TabIndex = 6;
            this.lblBedType.Text = "Loại giường:";
            // 
            // cmbBedType
            // 
            this.cmbBedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBedType.FormattingEnabled = true;
            this.cmbBedType.Items.AddRange(new object[] {
            "Single bed",
            "Double bed",
            "Queen size bed",
            "King size bed",
            "Super king size bed"});
            this.cmbBedType.Location = new System.Drawing.Point(213, 262);
            this.cmbBedType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBedType.Name = "cmbBedType";
            this.cmbBedType.Size = new System.Drawing.Size(325, 33);
            this.cmbBedType.TabIndex = 4;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(614, 54);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(113, 25);
            this.lblCheckIn.TabIndex = 8;
            this.lblCheckIn.Text = "Ngày nhận:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Location = new System.Drawing.Point(741, 50);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(333, 30);
            this.dtpCheckIn.TabIndex = 9;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(618, 110);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(91, 25);
            this.lblCheckOut.TabIndex = 10;
            this.lblCheckOut.Text = "Ngày trả:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Location = new System.Drawing.Point(741, 110);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(333, 30);
            this.dtpCheckOut.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(614, 184);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(84, 25);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Giá tiền:";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(11, 411);
            this.dgvBookings.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.RowTemplate.Height = 29;
            this.dgvBookings.Size = new System.Drawing.Size(1117, 315);
            this.dgvBookings.TabIndex = 17;
            this.dgvBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(290, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(529, 340);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 40);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(767, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCustomerName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCustomerName.BorderRadius = 20;
            this.txtCustomerName.BorderSize = 2;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCustomerName.Location = new System.Drawing.Point(213, 45);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerName.PasswordChar = false;
            this.txtCustomerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(325, 35);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Texts = "";
            this.txtCustomerName.UnderlinedStyle = false;
            this.txtCustomerName._TextChanged += new System.EventHandler(this.txtCustomerName__TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhoneNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhoneNumber.BorderRadius = 20;
            this.txtPhoneNumber.BorderSize = 2;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(213, 110);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhoneNumber.PasswordChar = false;
            this.txtPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(325, 35);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.Texts = "";
            this.txtPhoneNumber.UnderlinedStyle = false;
            this.txtPhoneNumber._TextChanged += new System.EventHandler(this.txtPhoneNumber__TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrice.BorderRadius = 20;
            this.txtPrice.BorderSize = 2;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(741, 184);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.Size = new System.Drawing.Size(340, 35);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            this.txtPrice._TextChanged += new System.EventHandler(this.txtPrice__TextChanged);
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 737);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.cmbBedType);
            this.Controls.Add(this.lblBedType);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblCustomerName);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyPhong";
            this.Text = "Quản lý đặt phòng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblBedType;
        private System.Windows.Forms.ComboBox cmbBedType;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DataGridView dgvBookings;
        private DataTable bookingTable; // Khai báo DataTable để lưu trữ dữ liệu
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Components.VBButton btnAdd;
        private Components.VBButton btnEdit;
        private Components.VBButton btnDelete;
        private Components.VBTextBox txtCustomerName;
        private Components.VBTextBox txtPhoneNumber;
        private Components.VBTextBox txtPrice;
    }

}