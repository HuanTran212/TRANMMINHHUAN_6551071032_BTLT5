using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Enabled = true;

            lblTenquan.Text = "CAFE ÁNH DƯƠNG";

            CapNhatTrangThai();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CapNhatTrangThai();
        }

        private void CapNhatTrangThai()
        {
            DateTime now = DateTime.Now;

            lblGio.Text = now.ToString("HH:mm:ss");

            if (now.Hour >= 6 && now.Hour < 22)
            {
                az.Text = "Mở cửa";
                az.ForeColor = Color.Green;
            }
            else
            {
                az.Text = "Đóng cửa";
                az.ForeColor = Color.Red;
            }
        }

        private void mnuDoiMauNen_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                }
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}