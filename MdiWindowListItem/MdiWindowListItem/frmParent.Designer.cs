namespace MdiWindowListItem
{
    partial class frmParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            mnuBenhNhan = new ToolStripMenuItem();
            mnuDatLichHen = new ToolStripMenuItem();
            cửaSốToolStripMenuItem = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            mnuLichHen = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nghiệpVụToolStripMenuItem, cửaSốToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = cửaSốToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuBenhNhan, mnuDatLichHen });
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Size = new Size(91, 24);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // mnuBenhNhan
            // 
            mnuBenhNhan.Name = "mnuBenhNhan";
            mnuBenhNhan.Size = new Size(228, 26);
            mnuBenhNhan.Text = "Thông tin bệnh nhân";
            mnuBenhNhan.Click += menuBenhNhan_Click;
            // 
            // mnuDatLichHen
            // 
            mnuDatLichHen.Name = "mnuDatLichHen";
            mnuDatLichHen.Size = new Size(228, 26);
            mnuDatLichHen.Text = "Đặt lịch hẹn";
            mnuDatLichHen.Click += menuLichHen_Click;
            // 
            // cửaSốToolStripMenuItem
            // 
            cửaSốToolStripMenuItem.Name = "cửaSốToolStripMenuItem";
            cửaSốToolStripMenuItem.Size = new Size(68, 24);
            cửaSốToolStripMenuItem.Text = "Cửa số";
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(68, 24);
            mnuCuaSo.Text = "Cửa sổ";
            // 
            // mnuLichHen
            // 
            mnuLichHen.Name = "mnuLichHen";
            mnuLichHen.Size = new Size(228, 26);
            mnuLichHen.Text = "Đặt lịch hẹn";
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmParent";
            Text = "frmParent";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;

        private ToolStripMenuItem mnuLichHen;
        private ToolStripMenuItem mnuCuaSo;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem cửaSốToolStripMenuItem;
        private ToolStripMenuItem mnuBenhNhan;
        private ToolStripMenuItem mnuDatLichHen;
    }
}