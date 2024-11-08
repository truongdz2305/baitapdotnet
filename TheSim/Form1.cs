using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TheSim
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối tới cơ sở dữ liệu
        private string connectionString = @"Data Source=DESKTOP-FDIFMF1\SQLEXPRESS;Initial Catalog=SimThe;Integrated Security=True";

        public Form1() // Phương thức khởi tạo
        {
            InitializeComponent(); // Khởi tạo các thành phần của form
            LoadSimData(); // Gọi hàm để tải dữ liệu khi form được mở
        }

        // Hàm tải dữ liệu từ cơ sở dữ liệu và hiển thị lên DataGridView
        private void LoadSimData()
        {
            // Câu lệnh SQL để lấy dữ liệu từ bảng Sim theo thứ tự ngày kích hoạt tăng dần
            string query = "SELECT * FROM Sim ORDER BY ngaykichhoat ASC";

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection); // Tạo SqlDataAdapter để truy vấn

                // Tạo DataTable để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();

                try
                {
                    // Mở kết nối và điền dữ liệu vào DataTable
                    connection.Open();
                    dataAdapter.Fill(dataTable); // Điền dữ liệu từ SqlDataAdapter vào DataTable

                    // Gán DataTable vào DataGridView để hiển thị dữ liệu
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu có
                    MessageBox.Show("Lỗi kết nối hoặc truy vấn: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Có thể thêm mã xử lý khi bấm nút, ví dụ tải lại dữ liệu
            LoadSimData();
        }
    }
}
