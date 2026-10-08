using System;
using System.Windows.Forms;

namespace hoccsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0 ||
                !int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Nhập dữ liệu không hợp lệ!");
                return;
            }

            decimal giamGia = 0;
            if (!string.IsNullOrEmpty(txtGiamGia.Text) && (!decimal.TryParse(txtGiamGia.Text, out giamGia) || giamGia < 0 || giamGia > 100))
            {
                MessageBox.Show("Phần trăm giảm giá không hợp lệ!");
                return;
            }

            lblTongTien.Text = ((donGia * soLuong) * (100 - giamGia) / 100).ToString("N0") + " VNĐ";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "0 VNĐ";
            txtDonGia.Focus();
        }
    }
}