using System;
using System.Windows.Forms;

namespace GymFitLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;

            comboBox1.Items.Add("Basic");
            comboBox1.Items.Add("VIP");
            comboBox1.Items.Add("Premium");

            comboBox1.SelectedIndex = 0;

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 7;
            numericUpDown1.Value = 1;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string thongTin =
                "THÔNG TIN ĐĂNG KÝ\n\n" +
                "Họ tên: " + textBox1.Text + "\n" +
                "SĐT: " + textBox2.Text + "\n" +
                "Gói tập: " + comboBox1.Text + "\n" +
                "Số buổi/tuần: " + numericUpDown1.Value;

            MessageBox.Show(
                thongTin,
                "Đăng ký thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}