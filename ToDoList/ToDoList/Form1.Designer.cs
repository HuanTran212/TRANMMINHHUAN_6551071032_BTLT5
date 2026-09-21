namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            đánhDấuHoànThànhToolStripMenuItem = new ToolStripMenuItem();
            xóaCôngViệcNàyToolStripMenuItem = new ToolStripMenuItem();
            xóaTấtCảToolStripMenuItem = new ToolStripMenuItem();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Dock = DockStyle.Top;
            txtCongViecMoi.Location = new Point(0, 0);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(800, 27);
            txtCongViecMoi.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Bottom;
            btnThem.Location = new Point(0, 421);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(800, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.Dock = DockStyle.Fill;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(0, 27);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(800, 394);
            lstCongViec.TabIndex = 2;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { đánhDấuHoànThànhToolStripMenuItem, xóaCôngViệcNàyToolStripMenuItem, xóaTấtCảToolStripMenuItem });
            cmsCongViec.Name = "contextMenuStrip1";
            cmsCongViec.Size = new Size(221, 76);
            cmsCongViec.Opening += contextMenuStrip1_Opening;
            // 
            // đánhDấuHoànThànhToolStripMenuItem
            // 
            đánhDấuHoànThànhToolStripMenuItem.Name = "đánhDấuHoànThànhToolStripMenuItem";
            đánhDấuHoànThànhToolStripMenuItem.Size = new Size(220, 24);
            đánhDấuHoànThànhToolStripMenuItem.Text = "Đánh dấu hoàn thành";
            đánhDấuHoànThànhToolStripMenuItem.Click += mnuDanhDauHoanThanh_Click;
            // 
            // xóaCôngViệcNàyToolStripMenuItem
            // 
            xóaCôngViệcNàyToolStripMenuItem.Name = "xóaCôngViệcNàyToolStripMenuItem";
            xóaCôngViệcNàyToolStripMenuItem.Size = new Size(220, 24);
            xóaCôngViệcNàyToolStripMenuItem.Text = "Xóa công việc này";
            xóaCôngViệcNàyToolStripMenuItem.Click += mnuXoaCongViec_Click;
            // 
            // xóaTấtCảToolStripMenuItem
            // 
            xóaTấtCảToolStripMenuItem.Name = "xóaTấtCảToolStripMenuItem";
            xóaTấtCảToolStripMenuItem.Size = new Size(220, 24);
            xóaTấtCảToolStripMenuItem.Text = "Xóa tất cả";
            xóaTấtCảToolStripMenuItem.Click += mnuXoaTatCa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            Name = "Form1";
            Text = "Form1";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem đánhDấuHoànThànhToolStripMenuItem;
        private ToolStripMenuItem xóaCôngViệcNàyToolStripMenuItem;
        private ToolStripMenuItem xóaTấtCảToolStripMenuItem;
    }
}
