namespace hoccsharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            System.Windows.Forms.Label l1 = new System.Windows.Forms.Label { Text = "Đơn giá:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
            this.txtDonGia.Location = new System.Drawing.Point(110, 17);
            this.txtDonGia.TabIndex = 0;

            System.Windows.Forms.Label l2 = new System.Windows.Forms.Label { Text = "Số lượng:", Location = new System.Drawing.Point(20, 50), AutoSize = true };
            this.txtSoLuong.Location = new System.Drawing.Point(110, 47);
            this.txtSoLuong.TabIndex = 1;

            System.Windows.Forms.Label l3 = new System.Windows.Forms.Label { Text = "% Giảm:", Location = new System.Drawing.Point(20, 80), AutoSize = true };
            this.txtGiamGia.Location = new System.Drawing.Point(110, 77);
            this.txtGiamGia.TabIndex = 2;

            System.Windows.Forms.Label l4 = new System.Windows.Forms.Label { Text = "Tổng tiền:", Location = new System.Drawing.Point(20, 110), AutoSize = true };
            this.lblTongTien.Text = "0 VNĐ";
            this.lblTongTien.Location = new System.Drawing.Point(110, 110);
            this.lblTongTien.AutoSize = true;

            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Location = new System.Drawing.Point(20, 145);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);

            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(110, 145);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.ClientSize = new System.Drawing.Size(240, 190);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { l1, l2, l3, l4, txtDonGia, txtSoLuong, txtGiamGia, lblTongTien, btnTinhTien, btnLamMoi });
            this.Text = "Bai 1";
        }

        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnLamMoi;
    }
}