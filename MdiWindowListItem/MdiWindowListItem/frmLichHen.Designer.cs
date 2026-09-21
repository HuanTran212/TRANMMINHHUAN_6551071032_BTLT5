namespace MdiWindowListItem
{
    partial class frmLichHen
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
            label1 = new Label();
            label2 = new Label();
            lstLichHen = new ListBox();
            btnDatLich = new Button();
            txtTenBenhNhan = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 37);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngày giờ hẹn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 98);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên bệnh nhân";
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(64, 266);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(375, 104);
            lstLichHen.TabIndex = 3;
            // 
            // btnDatLich
            // 
            btnDatLich.Location = new Point(237, 164);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(94, 29);
            btnDatLich.TabIndex = 4;
            btnDatLich.Text = "Đặt lịch";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(189, 98);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(250, 27);
            txtTenBenhNhan.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 227);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 6;
            label3.Text = "DANH SÁCH LỊCH HẸN";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            dateTimePicker1.Location = new Point(189, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(btnDatLich);
            Controls.Add(lstLichHen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLichHen";
            Text = "frmLichHen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstLichHen;
        private Button btnDatLich;
        private TextBox txtTenBenhNhan;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}