using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class TrangChinh : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public TrangChinh()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 99);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(126, 245, 249);
            public static Color color2 = Color.FromArgb(126, 245, 249);
            public static Color color3 = Color.FromArgb(126, 245, 249);
            public static Color color4 = Color.FromArgb(126, 245, 249);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 120, 215);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.Padding = new Padding(20, 0, 0, 0);
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconHome.IconChar = currentBtn.IconChar;
                iconHome.IconColor = color;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void hideForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();
            }
        }
        private void ShowLoginForm()
        {
            //DangNhap loginForm = new DangNhap();
            //DialogResult result = loginForm.ShowDialog();

            //if (result == DialogResult.OK && loginForm.IsLoginSuccessful)
            //{
            //    this.Show(); // Show the main form after successful login
            //    //ShowDichVuForm();
            //}
            //else
            //{
            //    Application.Exit(); // Exit the application if login is unsuccessful
            //}
        }
        private void TrangChinh_Load_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide the main form initially
            ShowLoginForm();
        }

        private void TrangChinh_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmXemPhongTrong());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }


        //private void ShowDichVuForm()
        //{
        //    DichVu dv = new DichVu();
        //    dv.MdiParent = this;
        //    dv.WindowState = FormWindowState.Maximized;
        //    dv.Show();
        //}
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

        