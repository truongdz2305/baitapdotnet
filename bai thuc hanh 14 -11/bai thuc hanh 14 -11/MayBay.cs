using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_thuc_hanh_14__11
{
    public partial class MayBay : Form
    {
        private KetNoi ketNoi;
        public MayBay()
        {
            InitializeComponent();
            ketNoi = new KetNoi();
            LoadDanhSachMayBay();
        }

        private void LoadDanhSachMayBay()
        {
            try
            {
                string truyVan = "SELECT * FROM MayBay ORDER BY TenMayBay ASC";
                DataSet ds = ketNoi.LayDuLieu(truyVan);

                if (ds != null && ds.Tables.Count > 0)
                {
                    dataGridViewMayBay.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách máy bay: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MayBay_Load(object sender, EventArgs e)
        {
            LoadDanhSachMayBay();
        }
    }
}
