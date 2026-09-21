namespace MdiWindowListItem
{
    partial class frmBenhNhan
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
            lblHoTen = new Label();
            lblTuoi = new Label();
            lblTrieuChung = new Label();
            txtHoTen = new TextBox();
            txtTrieuChung = new TextBox();
            numTuoi = new NumericUpDown();
            button1 = new Button();
            lstBenhNhan = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numTuoi).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(49, 26);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Location = new Point(49, 85);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(38, 20);
            lblTuoi.TabIndex = 1;
            lblTuoi.Text = "Tuổi";
            // 
            // lblTrieuChung
            // 
            lblTrieuChung.AutoSize = true;
            lblTrieuChung.Location = new Point(49, 138);
            lblTrieuChung.Name = "lblTrieuChung";
            lblTrieuChung.Size = new Size(86, 20);
            lblTrieuChung.TabIndex = 2;
            lblTrieuChung.Text = "Triệu chứng";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(145, 26);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(150, 27);
            txtHoTen.TabIndex = 3;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(145, 138);
            txtTrieuChung.Multiline = true;
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(150, 63);
            txtTrieuChung.TabIndex = 4;
            // 
            // numTuoi
            // 
            numTuoi.Location = new Point(145, 85);
            numTuoi.Name = "numTuoi";
            numTuoi.Size = new Size(150, 27);
            numTuoi.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(172, 219);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Lưu tạm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLuuTam_Click;
            // 
            // lstBenhNhan
            // 
            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.Location = new Point(49, 299);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(246, 104);
            lstBenhNhan.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 265);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 8;
            label1.Text = "Bệnh nhân đã nhập";
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(label1);
            Controls.Add(lstBenhNhan);
            Controls.Add(button1);
            Controls.Add(numTuoi);
            Controls.Add(txtTrieuChung);
            Controls.Add(txtHoTen);
            Controls.Add(lblTrieuChung);
            Controls.Add(lblTuoi);
            Controls.Add(lblHoTen);
            Name = "frmBenhNhan";
            Text = "frmBenhNhan";
            ((System.ComponentModel.ISupportInitialize)numTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblTuoi;
        private Label lblTrieuChung;
        private TextBox txtHoTen;
        private TextBox txtTrieuChung;
        private NumericUpDown numTuoi;
        private Button button1;
        private ListBox lstBenhNhan;
        private Label label1;
    }
}