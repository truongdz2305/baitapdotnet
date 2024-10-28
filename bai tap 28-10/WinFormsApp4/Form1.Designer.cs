namespace WinFormsApp4
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            button5 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 33);
            button1.Name = "button1";
            button1.Size = new Size(114, 32);
            button1.TabIndex = 0;
            button1.Text = "làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(62, 71);
            button2.Name = "button2";
            button2.Size = new Size(114, 32);
            button2.TabIndex = 1;
            button2.Text = "thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(62, 115);
            button3.Name = "button3";
            button3.Size = new Size(114, 32);
            button3.TabIndex = 2;
            button3.Text = "xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(62, 150);
            button4.Name = "button4";
            button4.Size = new Size(114, 32);
            button4.TabIndex = 3;
            button4.Text = "sửa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(516, 287);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 198);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "nút bấm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 5;
            label1.Text = "mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 67);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 6;
            label2.Text = "tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 108);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 7;
            label3.Text = "lop";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 124);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(299, 27);
            textBox3.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(7, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(487, 179);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(100, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(299, 27);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 153);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 12;
            label5.Text = "điểm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(747, 186);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(8, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(771, 266);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bảng";
            // 
            // button5
            // 
            button5.Location = new Point(694, 20);
            button5.Name = "button5";
            button5.Size = new Size(71, 26);
            button5.TabIndex = 17;
            button5.Text = "tra cứu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(385, 20);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(299, 27);
            textBox5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 23);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 16;
            label6.Text = "mã";
            label6.Click += label6_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(639, -26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 577);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private Label label5;
        private CheckBox checkBox1;
        private TextBox textBox5;
        private Label label6;
        private Button button5;
    }
}
