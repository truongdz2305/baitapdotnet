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
    public partial class ThemMayBay : Form
    {
        private KetNoi ketNoi;
        public ThemMayBay()
        {
            InitializeComponent();
            ketNoi = new KetNoi();
            LoadDanhSachMayBay();
        }
        private void LoadDanhSachMayBay()
        {
            try
            {
                string truyVan = "SELECT * FROM MayBay";
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

        private void ThemMayBay_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenMayBay = txtTenMayBay.Text.Trim();
            int namSX;
            int soGioBay;

            if (string.IsNullOrEmpty(tenMayBay) ||
                !int.TryParse(txtNamSX.Text.Trim(), out namSX) ||
                !int.TryParse(txtSoGioBay.Text.Trim(), out soGioBay))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string truyVan = $"INSERT INTO MayBay (TenMayBay, NamSX, SoGioBay) VALUES (N'{tenMayBay}', {namSX}, {soGioBay})";

            if (ketNoi.ThucThi(truyVan))
            {
                MessageBox.Show("Thêm máy bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                LoadDanhSachMayBay();
            }
            else
            {
                MessageBox.Show("Thêm máy bay thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtTenMayBay.Text = "";
            txtNamSX.Text = "";
            txtSoGioBay.Text = ""; 
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
