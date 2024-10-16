namespace QuanLyKhachSan
{
    partial class TrangChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tolHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tslGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tslHotline = new System.Windows.Forms.ToolStripMenuItem();
            this.tslSearcher = new System.Windows.Forms.ToolStripMenuItem();
            this.tolGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tolHotline = new System.Windows.Forms.ToolStripMenuItem();
            this.tolSearcher = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolHome,
            this.tolGioiThieu,
            this.tolHotline,
            this.tolSearcher});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1336, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tolHome
            // 
            this.tolHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslGioiThieu,
            this.tslHotline,
            this.tslSearcher});
            this.tolHome.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tolHome.Name = "tolHome";
            this.tolHome.Size = new System.Drawing.Size(71, 26);
            this.tolHome.Text = "Home";
            // 
            // tslGioiThieu
            // 
            this.tslGioiThieu.Name = "tslGioiThieu";
            this.tslGioiThieu.Size = new System.Drawing.Size(224, 26);
            this.tslGioiThieu.Text = "Giới Thiệu";
            this.tslGioiThieu.Click += new System.EventHandler(this.tolGioiThieu_Click);
            // 
            // tslHotline
            // 
            this.tslHotline.Name = "tslHotline";
            this.tslHotline.Size = new System.Drawing.Size(224, 26);
            this.tslHotline.Text = "Hotline";
            this.tslHotline.Click += new System.EventHandler(this.tolHotline_Click);
            // 
            // tslSearcher
            // 
            this.tslSearcher.Name = "tslSearcher";
            this.tslSearcher.Size = new System.Drawing.Size(224, 26);
            this.tslSearcher.Text = "Searcher";
            this.tslSearcher.Click += new System.EventHandler(this.tolSearcher_Click);
            // 
            // tolGioiThieu
            // 
            this.tolGioiThieu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tolGioiThieu.Name = "tolGioiThieu";
            this.tolGioiThieu.Size = new System.Drawing.Size(116, 26);
            this.tolGioiThieu.Text = "Giới Thiệu ";
            this.tolGioiThieu.Click += new System.EventHandler(this.tolGioiThieu_Click);
            // 
            // tolHotline
            // 
            this.tolHotline.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tolHotline.Name = "tolHotline";
            this.tolHotline.Size = new System.Drawing.Size(83, 26);
            this.tolHotline.Text = "Hotline";
            this.tolHotline.Click += new System.EventHandler(this.tolHotline_Click);
            // 
            // tolSearcher
            // 
            this.tolSearcher.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tolSearcher.Name = "tolSearcher";
            this.tolSearcher.Size = new System.Drawing.Size(94, 26);
            this.tolSearcher.Text = "Searcher";
            this.tolSearcher.Click += new System.EventHandler(this.tolSearcher_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 688);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TrangChinh";
            this.Text = "Trang Chính";
            this.Load += new System.EventHandler(this.TrangChinh_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tolHome;
        private System.Windows.Forms.ToolStripMenuItem tslGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem tslHotline;
        private System.Windows.Forms.ToolStripMenuItem tslSearcher;
        private System.Windows.Forms.ToolStripMenuItem tolGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem tolHotline;
        private System.Windows.Forms.ToolStripMenuItem tolSearcher;
    }
}

