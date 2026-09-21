namespace GymFitLife
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 161);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 223);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 289);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Gói tập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 355);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Số buổi tuần";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 6;
            toolTip1.SetToolTip(textBox1, "Nhập đầy đủ họ và tên hội viên");
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 7;
            toolTip1.SetToolTip(textBox2, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 8;
            toolTip1.SetToolTip(textBox3, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(156, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            toolTip1.SetToolTip(dateTimePicker1, "Chọn ngày tháng năm sinh của hội viên");
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Basic", "Vip", "Premium" });
            comboBox1.Location = new Point(156, 289);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 10;
            toolTip1.SetToolTip(comboBox1, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(156, 353);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(250, 27);
            numericUpDown1.TabIndex = 11;
            toolTip1.SetToolTip(numericUpDown1, "Nhấn để đăng ký hội viên");
            // 
            // button1
            // 
            button1.Location = new Point(192, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDangKy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 450);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private ToolTip toolTip1;
        private Button button1;
    }
}
