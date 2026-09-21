using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiWindowListItem
{
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();
        public frmBenhNhan()
        {
            InitializeComponent();
            numTuoi.Minimum = 0;
            numTuoi.Maximum = 120;
        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string benhNhan =
                txtHoTen.Text.Trim()
                + " - "
                + numTuoi.Value
                + " tuổi - "
                + txtTrieuChung.Text.Trim();

            danhSachBenhNhan.Add(benhNhan);

            lstBenhNhan.Items.Add(benhNhan);

            txtHoTen.Clear();
            txtTrieuChung.Clear();
            numTuoi.Value = 0;

            txtHoTen.Focus();
        }
    }
}
