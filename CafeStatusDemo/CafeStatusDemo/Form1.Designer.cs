namespace CafeStatusDemo
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đổiMàuNềnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip2 = new StatusStrip();
            lblGio = new ToolStripStatusLabel();
            lblTenquan = new ToolStripStatusLabel();
            az = new ToolStripStatusLabel();
            lblTrangthai = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMàuNềnToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMàuNềnToolStripMenuItem
            // 
            đổiMàuNềnToolStripMenuItem.Name = "đổiMàuNềnToolStripMenuItem";
            đổiMàuNềnToolStripMenuItem.Size = new Size(224, 26);
            đổiMàuNềnToolStripMenuItem.Text = "Đổi màu nền";
            đổiMàuNềnToolStripMenuItem.Click += mnuDoiMauNen_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += mnuThoat_Click;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(94, 20);
            toolStripStatusLabel3.Text = "TRẠNG THÁI";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(20, 20);
            statusStrip2.Items.AddRange(new ToolStripItem[] { lblGio, lblTenquan, az });
            statusStrip2.Location = new Point(0, 424);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(800, 26);
            statusStrip2.TabIndex = 2;
            statusStrip2.Text = "statusStrip2";
            // 
            // lblGio
            // 
            lblGio.Name = "lblGio";
            lblGio.Size = new Size(32, 20);
            lblGio.Text = "Giờ";
            // 
            // lblTenquan
            // 
            lblTenquan.Name = "lblTenquan";
            lblTenquan.Size = new Size(659, 20);
            lblTenquan.Spring = true;
            lblTenquan.Text = "CAFE ÁNH DƯƠNG";
            // 
            // az
            // 
            az.Name = "az";
            az.Size = new Size(94, 20);
            az.Text = "TRẠNG THÁI";
            // 
            // lblTrangthai
            // 
            lblTrangthai.Name = "lblTrangthai";
            lblTrangthai.Size = new Size(94, 20);
            lblTrangthai.Text = "TRẠNG THÁI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMàuNềnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel lblTrangthai;
        private ToolStripStatusLabel lblGio;
        private ToolStripStatusLabel lblTenquan;
        private ToolStripStatusLabel az;
    }
}
