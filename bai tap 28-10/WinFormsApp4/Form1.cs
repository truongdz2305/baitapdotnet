using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MaSinhVien", "Mã Sinh Viên");
            dataGridView1.Columns.Add("Ten", "Tên");
            dataGridView1.Columns.Add("Lop", "Lớp");
            dataGridView1.Columns.Add("Diem", "Điểm");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value?.ToString() ?? "";
                textBox2.Text = row.Cells[1].Value?.ToString() ?? "";
                textBox3.Text = row.Cells[2].Value?.ToString() ?? "";
                textBox4.Text = row.Cells[3].Value?.ToString() ?? "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để xóa.");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    clearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                return;
            }

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            clearInputFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells[0].Value = textBox1.Text;
                selectedRow.Cells[1].Value = textBox2.Text;
                selectedRow.Cells[2].Value = textBox3.Text;
                selectedRow.Cells[3].Value = textBox4.Text;
                clearInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.");
            }
        }
        private void clearInputFields()
        {
            // Làm mới các trường nhập liệu
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string maSinhVien = textBox5.Text.Trim(); // TextBox để nhập mã sinh viên
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["MaSinhVien"].Value?.ToString() == maSinhVien)
                { 
                    string diem = row.Cells["Diem"].Value?.ToString();

                    MessageBox.Show($"Điểm: {diem}", "Kết quả Tra cứu");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã đã nhập.", "Thông báo");
            }
        }
    }
}

