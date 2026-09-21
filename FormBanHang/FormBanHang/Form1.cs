namespace FormBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void FormBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn thoát?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }

                e.Handled = true;
            }
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSanPham.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập Mã sản phẩm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSanPham.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập Số lượng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoLuong.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập Đơn giá!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDonGia.Focus();
                return;
            }

            string dong = txtSanPham.Text.Trim()
                         + " | "
                         + txtSoLuong.Text.Trim()
                         + " | "
                         + txtDonGia.Text.Trim();

            lstKetQua.Items.Add(dong);

            txtSanPham.Focus();
        }

        // Nút Xóa trắng
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtSanPham.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            txtSanPham.Focus();
        }
    }
}
