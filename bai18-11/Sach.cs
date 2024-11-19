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

namespace bai18_11
{
    public partial class Sach : Form
    {
        public Sach()
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
                string query = "SELECT * FROM Sach";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table; // Hiển thị dữ liệu lên DataGridView
            }
        }


        private void Sach_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)// txt Mã sách
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)// txt Tên Sách
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)// txt Tác Giả
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)// txt Giá Bán
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)// txt Số lượng
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)//txt Mô Tả
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)//txt mã loại sách
        {

        }

        private void button1_Click(object sender, EventArgs e) //btn Thêm 
        {
            string connectionString = @"Data Source=DESKTOP-FDIFMF1\SQLEXPRESS;Initial Catalog=NhaSach;Integrated Security=True";

            string tenSach = textBox2.Text;
            string tacGia = textBox3.Text;
            string giaBan = textBox4.Text;
            string soLuongTrongKho = textBox5.Text;
            string moTa = textBox6.Text;
            string maLoaiSach = textBox7.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Sach (TenSach, TacGia, GiaBan, SoLuongTrongKho, MoTa, MaLoaiSach) " +
                                   "VALUES (@TenSach, @TacGia, @GiaBan, @SoLuongTrongKho, @MoTa, @MaLoaiSach)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenSach", tenSach);
                        command.Parameters.AddWithValue("@TacGia", tacGia);
                        command.Parameters.AddWithValue("@GiaBan", giaBan);
                        command.Parameters.AddWithValue("@SoLuongTrongKho", soLuongTrongKho);
                        command.Parameters.AddWithValue("@MoTa", moTa);
                        command.Parameters.AddWithValue("@MaLoaiSach", maLoaiSach);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //btn Sửa
        {
            string connectionString = @"Data Source=DESKTOP-FDIFMF1\SQLEXPRESS;Initial Catalog=NhaSach;Integrated Security=True";

            string maSach = textBox1.Text;
            string tenSach = textBox2.Text;
            string tacGia = textBox3.Text;
            string giaBan = textBox4.Text;
            string soLuongTrongKho = textBox5.Text;
            string moTa = textBox6.Text;
            string maLoaiSach = textBox7.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Sach SET TenSach = @TenSach, TacGia = @TacGia, GiaBan = @GiaBan, " +
                                   "SoLuongTrongKho = @SoLuongTrongKho, MoTa = @MoTa, MaLoaiSach = @MaLoaiSach WHERE MaSach = @MaSach";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSach", maSach);
                        command.Parameters.AddWithValue("@TenSach", tenSach);
                        command.Parameters.AddWithValue("@TacGia", tacGia);
                        command.Parameters.AddWithValue("@GiaBan", giaBan);
                        command.Parameters.AddWithValue("@SoLuongTrongKho", soLuongTrongKho);
                        command.Parameters.AddWithValue("@MoTa", moTa);
                        command.Parameters.AddWithValue("@MaLoaiSach", maLoaiSach);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa thông tin sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // btn Xóa
        {
            string connectionString = @"Data Source=DESKTOP-FDIFMF1\SQLEXPRESS;Initial Catalog=NhaSach;Integrated Security=True";

            // Lấy Mã Sách từ TextBox
            string maSach = textBox1.Text;

            if (string.IsNullOrEmpty(maSach))
            {
                MessageBox.Show("Vui lòng nhập Mã Sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Sach WHERE MaSach = @MaSach";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Gán tham số
                        command.Parameters.AddWithValue("@MaSach", maSach);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}