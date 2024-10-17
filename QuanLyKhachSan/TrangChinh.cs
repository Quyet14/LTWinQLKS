        using System;
        using System.Collections.Generic;
        using System.ComponentModel;
        using System.Data;
        using System.Drawing;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;
        using System.Windows.Forms;

        namespace QuanLyKhachSan
        {
            public partial class TrangChinh : Form
            {
                    public TrangChinh()
                    {
                        InitializeComponent();
                    }
                    private void hideForm()
                    {
                        foreach (Form f in this.MdiChildren)
                        {
                            f.Hide();
                        }
                    }

        

        private void tolGioiThieu_Click(object sender, EventArgs e)
                {
                    MessageBox.Show("Welcome to our application!");
                }
                 private void tslGioiThieu_Click(object sender, EventArgs e)
                {
                    MessageBox.Show("Welcome to our application!");
                }

                private void tolHotline_Click(object sender, EventArgs e)
                {
                    MessageBox.Show("Hotline: 1800-1234");
                }
                private void tslHotline_Click(object sender, EventArgs e)
                {
                    MessageBox.Show("Hotline: 1800-1234");
                }
                private void tolSearcher_Click(object sender, EventArgs e)
                {
                    SearchForm searchForm = new SearchForm();
                    searchForm.ShowDialog();
                }
                private void tslSearcher_Click(object sender, EventArgs e)
                {
                    SearchForm searchForm = new SearchForm();
                    searchForm.ShowDialog();
                }
        private void TrangChinh_Load_1(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "DangNhap")
                {
                    f.Activate();
                    return;
                }
            }
            DangNhap dn = new DangNhap();
            dn.MdiParent = this;
            dn.WindowState = FormWindowState.Maximized;
            dn.Show();
        }

       
    }
        }
        public partial class SearchForm : Form
        {
            public SearchForm()
            {
                this.Text = "Tìm kiếm";
                this.Size = new Size(400, 300);
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
                this.MinimizeBox = false;

                Label label = new Label();
                label.Text = "Nhập từ khóa tìm kiếm:";
                label.Location = new Point(10, 10);
                label.Size = new Size(200, 20);
                this.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Location = new Point(10, 40);
                textBox.Size = new Size(200, 20);
                this.Controls.Add(textBox);

                Button button = new Button();
                button.Text = "Tìm kiếm";
                button.Location = new Point(10, 70);
                button.Size = new Size(100, 20);
                button.Click += (sender, e) => MessageBox.Show("Tìm kiếm thành công!");
                this.Controls.Add(button);
            }
        }

        