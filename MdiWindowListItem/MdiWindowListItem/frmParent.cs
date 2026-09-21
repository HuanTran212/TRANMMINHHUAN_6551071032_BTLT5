using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiWindowListItem
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }
        private void menuBenhNhan_Click(object sender, EventArgs e)
        {
            frmBenhNhan formBenhNhan = new frmBenhNhan();

            formBenhNhan.MdiParent = this;

            formBenhNhan.Show();
        }

        private void menuLichHen_Click(object sender, EventArgs e)
        {
            frmLichHen formLichHen = new frmLichHen();

            formLichHen.MdiParent = this;

            formLichHen.Show();
        }
    }
}
