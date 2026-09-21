namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text.Trim());
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
        }

        private void mnuDanhDauHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                int viTri = lstCongViec.SelectedIndex;
                string congViec = lstCongViec.SelectedItem.ToString();

                if (!congViec.StartsWith("[Hoàn thành] "))
                {
                    lstCongViec.Items[viTri] =
                        "[Hoàn thành] " + congViec;
                }
            }
        }

        private void mnuXoaCongViec_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.RemoveAt(
                    lstCongViec.SelectedIndex);
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn công việc trước khi xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void mnuXoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa tất cả công việc không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
