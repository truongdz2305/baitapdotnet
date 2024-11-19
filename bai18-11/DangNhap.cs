using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bai18_11
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(50, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng Nhập";
            // 
            // button1
            // 
            button1.Location = new Point(100, 164);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 6;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 90);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Tài Khoản";
            // 
            // DangNhap
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(groupBox1);
            Name = "DangNhap";
            Text = "Đăng nhập hệ thống";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void button1_Click_1(object sender, EventArgs e)//đăng nhập
        {
            // Lấy thông tin đăng nhập từ các textbox
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Chuỗi kết nối đến database
            string connectionString = @"Data Source=DESKTOP-FDIFMF1\SQLEXPRESS;Initial Catalog=NhaSach;Integrated Security=True";

            // Kiểm tra thông tin đăng nhập trong database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @username AND MatKhau = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Gắn tham số vào câu truy vấn
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        // Thực thi truy vấn
                        int result = (int)command.ExecuteScalar();

                        if (result > 0)
                        {
                            // Đăng nhập thành công
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Hiển thị form hệ thống và ẩn form đăng nhập
                            HeThong heThong = new HeThong(); // Thay bằng tên form hệ thống của bạn
                            this.Hide(); // Ẩn form hiện tại
                            heThong.ShowDialog();
                            this.Close(); // Đóng form đăng nhập sau khi form hệ thống đóng
                        }
                        else
                        {
                            // Đăng nhập thất bại
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu có vấn đề xảy ra với kết nối hoặc truy vấn
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
