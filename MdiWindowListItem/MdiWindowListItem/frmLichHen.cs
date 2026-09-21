using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiWindowListItem
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();

        public frmLichHen()
        {
            InitializeComponent();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên bệnh nhân!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string lichHen =
                dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm")
                + " - "
                + txtTenBenhNhan.Text.Trim();

            danhSachLichHen.Add(lichHen);

            lstLichHen.Items.Add(lichHen);

            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }
    }
}
