namespace FormBanHang
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
            txtDonGia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            txtSanPham = new TextBox();
            txtSoLuong = new TextBox();
            SuspendLayout();
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(263, 168);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(193, 27);
            txtDonGia.TabIndex = 2;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 74);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 125);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 175);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 20);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 6;
            label4.Text = "Bán Hàng";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(168, 228);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(381, 228);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 29);
            btnXoaTrang.TabIndex = 8;
            btnXoaTrang.Text = "Xóa Trang";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(146, 292);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(310, 124);
            lstKetQua.TabIndex = 9;
            // 
            // txtSanPham
            // 
            txtSanPham.Location = new Point(263, 74);
            txtSanPham.Name = "txtSanPham";
            txtSanPham.Size = new Size(193, 27);
            txtSanPham.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(263, 125);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(193, 27);
            txtSoLuong.TabIndex = 11;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoLuong);
            Controls.Add(txtSanPham);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDonGia);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonGia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
        private TextBox txtSanPham;
        private TextBox txtSoLuong;
    }
}
