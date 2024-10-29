namespace QuanLyKhachSan.Components
{
    partial class CardRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCard = new QuanLyKhachSan.Components.RoundedPanel();
            this.lblRoom = new System.Windows.Forms.Label();
            this.iconTinhTrang = new FontAwesome.Sharp.IconPictureBox();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTinhTrang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelCard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelCard.BorderRadius = 30;
            this.panelCard.BorderSize = 0;
            this.panelCard.Controls.Add(this.lblRoom);
            this.panelCard.Controls.Add(this.iconTinhTrang);
            this.panelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard.Location = new System.Drawing.Point(0, 0);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(391, 168);
            this.panelCard.TabIndex = 2;
            this.panelCard.MouseEnter += new System.EventHandler(this.panelCard_MouseEnter);
            this.panelCard.MouseLeave += new System.EventHandler(this.panelCard_MouseLeave);
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRoom.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.White;
            this.lblRoom.Location = new System.Drawing.Point(160, 61);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(188, 63);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "lblRoom";
            // 
            // iconTinhTrang
            // 
            this.iconTinhTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.iconTinhTrang.ForeColor = System.Drawing.Color.Lime;
            this.iconTinhTrang.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconTinhTrang.IconColor = System.Drawing.Color.Lime;
            this.iconTinhTrang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTinhTrang.IconSize = 53;
            this.iconTinhTrang.Location = new System.Drawing.Point(108, 62);
            this.iconTinhTrang.Name = "iconTinhTrang";
            this.iconTinhTrang.Size = new System.Drawing.Size(53, 53);
            this.iconTinhTrang.TabIndex = 2;
            this.iconTinhTrang.TabStop = false;
            // 
            // CardRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCard);
            this.Name = "CardRoom";
            this.Size = new System.Drawing.Size(391, 168);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTinhTrang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel panelCard;
        public FontAwesome.Sharp.IconPictureBox iconTinhTrang;
        public System.Windows.Forms.Label lblRoom;
    }
}
