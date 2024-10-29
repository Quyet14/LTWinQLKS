namespace QuanLyKhachSan
{
    partial class frmPhong
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.fpnlRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnRoom = new System.Windows.Forms.RadioButton();
            this.rbtnBooked = new System.Windows.Forms.RadioButton();
            this.rbtnRoomCleaning = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(1191, 18);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 28);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1221, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phòng trống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1221, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng đã sử dụng";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 24;
            this.iconPictureBox2.Location = new System.Drawing.Point(1191, 48);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(24, 28);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1221, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phòng đang dọn dẹp";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 24;
            this.iconPictureBox3.Location = new System.Drawing.Point(1191, 82);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(24, 28);
            this.iconPictureBox3.TabIndex = 5;
            this.iconPictureBox3.TabStop = false;
            // 
            // fpnlRoom
            // 
            this.fpnlRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fpnlRoom.Location = new System.Drawing.Point(55, 165);
            this.fpnlRoom.Name = "fpnlRoom";
            this.fpnlRoom.Size = new System.Drawing.Size(1308, 625);
            this.fpnlRoom.TabIndex = 8;
            // 
            // rbtnRoom
            // 
            this.rbtnRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnRoom.AutoSize = true;
            this.rbtnRoom.ForeColor = System.Drawing.Color.Black;
            this.rbtnRoom.Location = new System.Drawing.Point(103, 112);
            this.rbtnRoom.Name = "rbtnRoom";
            this.rbtnRoom.Size = new System.Drawing.Size(143, 29);
            this.rbtnRoom.TabIndex = 9;
            this.rbtnRoom.TabStop = true;
            this.rbtnRoom.Text = "Phòng trống";
            this.rbtnRoom.UseVisualStyleBackColor = true;
            this.rbtnRoom.CheckedChanged += new System.EventHandler(this.rbtnRoom_CheckedChanged);
            // 
            // rbtnBooked
            // 
            this.rbtnBooked.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnBooked.AutoSize = true;
            this.rbtnBooked.ForeColor = System.Drawing.Color.Black;
            this.rbtnBooked.Location = new System.Drawing.Point(288, 112);
            this.rbtnBooked.Name = "rbtnBooked";
            this.rbtnBooked.Size = new System.Drawing.Size(94, 29);
            this.rbtnBooked.TabIndex = 10;
            this.rbtnBooked.TabStop = true;
            this.rbtnBooked.Text = "Đã đặt";
            this.rbtnBooked.UseVisualStyleBackColor = true;
            this.rbtnBooked.CheckedChanged += new System.EventHandler(this.rbtnBooked_CheckedChanged);
            // 
            // rbtnRoomCleaning
            // 
            this.rbtnRoomCleaning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnRoomCleaning.AutoSize = true;
            this.rbtnRoomCleaning.ForeColor = System.Drawing.Color.Black;
            this.rbtnRoomCleaning.Location = new System.Drawing.Point(431, 112);
            this.rbtnRoomCleaning.Name = "rbtnRoomCleaning";
            this.rbtnRoomCleaning.Size = new System.Drawing.Size(160, 29);
            this.rbtnRoomCleaning.TabIndex = 11;
            this.rbtnRoomCleaning.TabStop = true;
            this.rbtnRoomCleaning.Text = "Đang dọn dẹp";
            this.rbtnRoomCleaning.UseVisualStyleBackColor = true;
            this.rbtnRoomCleaning.CheckedChanged += new System.EventHandler(this.rbtnRoomCleaning_CheckedChanged);
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 896);
            this.Controls.Add(this.rbtnRoomCleaning);
            this.Controls.Add(this.rbtnBooked);
            this.Controls.Add(this.rbtnRoom);
            this.Controls.Add(this.fpnlRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.FlowLayoutPanel fpnlRoom;
        private System.Windows.Forms.RadioButton rbtnRoom;
        private System.Windows.Forms.RadioButton rbtnBooked;
        private System.Windows.Forms.RadioButton rbtnRoomCleaning;
    }
}