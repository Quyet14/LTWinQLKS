namespace QuanLyKhachSan.QuanLy
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.roundedPanel3 = new QuanLyKhachSan.Components.RoundedPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new QuanLyKhachSan.Components.RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new QuanLyKhachSan.Components.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Location = new System.Drawing.Point(33, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 450);
            this.panel1.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(605, 225);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Doanh thu phòng";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Doanh thu DV";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Tổng doanh thu";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(550, 450);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // cbbThang
            // 
            this.cbbThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(33, 177);
            this.cbbThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(165, 32);
            this.cbbThang.TabIndex = 11;
            this.cbbThang.Text = "Chọn tháng";
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // cbbNam
            // 
            this.cbbNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(619, 180);
            this.cbbNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(165, 32);
            this.cbbNam.TabIndex = 12;
            this.cbbNam.Text = "Chọn năm";
            this.cbbNam.SelectedIndexChanged += new System.EventHandler(this.cbbNam_SelectedIndexChanged);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(164)))));
            this.roundedPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.BorderSize = 0;
            this.roundedPanel3.Controls.Add(this.label5);
            this.roundedPanel3.Controls.Add(this.label6);
            this.roundedPanel3.Location = new System.Drawing.Point(831, 18);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(284, 134);
            this.roundedPanel3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(164)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng phòng đặt";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(164)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "0 Phòng";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(233)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Controls.Add(this.label3);
            this.roundedPanel2.Location = new System.Drawing.Point(429, 18);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(274, 134);
            this.roundedPanel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(233)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "0,000 VND";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(233)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doanh thu dịch vụ";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(228)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Location = new System.Drawing.Point(48, 18);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(264, 134);
            this.roundedPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doanh thu phòng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "0,000 VND";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1188, 722);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.cbbNam);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.ComboBox cbbNam;
        private Components.RoundedPanel roundedPanel1;
        private Components.RoundedPanel roundedPanel2;
        private Components.RoundedPanel roundedPanel3;
    }
}