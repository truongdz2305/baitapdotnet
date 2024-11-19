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
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//loai sach
        {
            LoaiSach formLoaiSach = new LoaiSach();
            formLoaiSach.Show();
        }

        private void button2_Click(object sender, EventArgs e)//sach
        {
            Sach formSach = new Sach();
            formSach.Show();
        }

        private void button3_Click(object sender, EventArgs e)//hóa đơn
        {
            HoaDon formHoaDon = new HoaDon();
            formHoaDon.Show();
        }

        private void button4_Click(object sender, EventArgs e)//thoongs kê
        {
            ThongKe formThongKe = new ThongKe();
            formThongKe.Show();
        }
    }
}
