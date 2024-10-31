using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DoAnN6_QLKS_DAL.Entity;

namespace QuanLyKhachSan.Khachhang
{
    public partial class frmDanhGia : Form
    {
        private int Star = 0;
        private readonly customerServices customerServices = new customerServices();
        private readonly DanhGiaServices danhGiaServices = new DanhGiaServices();
        private int customerId { get; set; }

        public frmDanhGia(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.WindowState = FormWindowState.Normal;
            ResetStars(); // Initialize stars to default state
        }

        // Helper method to reset all stars to default color
        private void ResetStars()
        {
            iconStar1.IconColor = Color.Gray;
            iconStar2.IconColor = Color.Gray;
            iconStar3.IconColor = Color.Gray;
            iconStar4.IconColor = Color.Gray;
            iconStar5.IconColor = Color.Gray;
        }

        // Helper method to set stars up to a specific number
        private void SetStars(int starCount)
        {
            ResetStars();
            Star = starCount;

            switch (starCount)
            {
                case 5:
                    iconStar5.IconColor = Color.Yellow;
                    goto case 4;
                case 4:
                    iconStar4.IconColor = Color.Yellow;
                    goto case 3;
                case 3:
                    iconStar3.IconColor = Color.Yellow;
                    goto case 2;
                case 2:
                    iconStar2.IconColor = Color.Yellow;
                    goto case 1;
                case 1:
                    iconStar1.IconColor = Color.Yellow;
                    break;
            }
        }

        private void iconStar1_Click(object sender, EventArgs e)
        {
            SetStars(1);
        }

        private void iconStar2_Click(object sender, EventArgs e)
        {
            SetStars(2);
        }

        private void iconStar3_Click(object sender, EventArgs e)
        {
            SetStars(3);
        }

        private void iconStar4_Click(object sender, EventArgs e)
        {
            SetStars(4);
        }

        private void iconStar5_Click(object sender, EventArgs e)
        {
            SetStars(5);
        }

        private bool ValidateInput()
        {
            if (!string.IsNullOrEmpty(txtFeedback.Texts) &&
                !txtFeedback.Texts.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Không hợp lệ. Vui lòng nhập đúng ký tự và không chứa ký tự đặc biệt.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Star == 0)
            {
                MessageBox.Show("Vui lòng chọn số sao đánh giá.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                // Check if customer can submit review
                if (!danhGiaServices.CanCustomerReview(this.customerId))
                {
                    MessageBox.Show("Bạn chỉ có thể đánh giá một lần trong thời gian lưu trú.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new review object
                PhanHoiKhachHang review = new PhanHoiKhachHang
                {
                    MaKhachHang = this.customerId,
                    NoiDung = txtFeedback.Texts.Trim(),
                    NgayPhanHoi = DateTime.Now,
                    Rating = Star
                };

                // Attempt to save the review
                if (danhGiaServices.AddReview(review))
                {
                    MessageBox.Show("Đánh giá của bạn đã được lưu thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear inputs after successful submission
                    txtFeedback.Texts = string.Empty;
                    ResetStars();
                    Star = 0;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể lưu đánh giá. Vui lòng kiểm tra lại thời gian lưu trú của bạn.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}