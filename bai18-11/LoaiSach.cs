using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai18_11
{
    public partial class LoaiSach : Form
    {
        public LoaiSach()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=DESKTOP-FDIFMF1\SQLEXPRESS;Initial Catalog=NhaSach;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM LoaiSach";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table; // Hiển thị dữ liệu lên DataGridView
            }
        }


        private void button1_Click(object sender, EventArgs e)//thêm
        {
            string connectionString = @"Data Source=DESKTOP-FDIFMF1\SQLEXPRESS;Initial Catalog=NhaSach;Integrated Security=True";

            // Lấy dữ liệu từ các textbox
            string maLoai = textBox1.Text; // Mã loại
            string tenLoai = textBox2.Text; // Tên loại
            string moTa = textBox3.Text; // Mô tả

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO LoaiSach (MaLoaiSach, TenLoaiSach, MoTa) VALUES (@MaLoaiSach, @TenLoaiSach, @MoTa)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLoaiSach", maLoai);
                        command.Parameters.AddWithValue("@TenLoaiSach", tenLoai);
                        command.Parameters.AddWithValue("@MoTa", moTa);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu
                        }
                        else
                        {
                            MessageBox.Show("Không thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//sửa
        {
            string connectionString = @"Data Source=DESKTOP-FDIFMF1\SQLEXPRESS;Initial Catalog=NhaSach;Integrated Security=True";

            // Lấy dữ liệu từ các textbox
            string maLoai = textBox1.Text; // Mã loại
            string tenLoai = textBox2.Text; // Tên loại
            string moTa = textBox3.Text; // Mô tả

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE LoaiSach SET TenLoaiSach = @TenLoaiSach, MoTa = @MoTa WHERE MaLoaiSach = @MaLoaiSach";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLoaiSach", maLoai);
                        command.Parameters.AddWithValue("@TenLoaiSach", tenLoai);
                        command.Parameters.AddWithValue("@MoTa", moTa);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu
                        }
                        else
                        {
                            MessageBox.Show("Không sửa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)//xóa
        {
            string connectionString = @"Data Source=DESKTOP-FDIFMF1\SQLEXPRESS;Initial Catalog=NhaSach;Integrated Security=True";

            // Lấy mã loại từ textbox
            string maLoai = textBox1.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM LoaiSach WHERE MaLoaiSach = @MaLoaiSach";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLoaiSach", maLoai);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu
                        }
                        else
                        {
                            MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
