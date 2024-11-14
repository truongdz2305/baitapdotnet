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
    public partial class SuaMayBay : Form
    {
        private KetNoi ketNoi;
        public SuaMayBay()
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

        private void txtNamSX_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewMayBay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một máy bay để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewMayBay.SelectedRows[0];
            int maMayBay = Convert.ToInt32(selectedRow.Cells["MaMB"].Value);
            string tenMayBay = txtTen.Text.Trim();
            int namSX;
            int soGioBay;

            if (string.IsNullOrEmpty(tenMayBay) ||
                !int.TryParse(txtNam.Text.Trim(), out namSX) ||
                !int.TryParse(txtGio.Text.Trim(), out soGioBay))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string truyVan = $"UPDATE MayBay SET TenMayBay = N'{tenMayBay}', NamSX = {namSX}, SoGioBay = {soGioBay} WHERE MaMB = {maMayBay}";

            if (ketNoi.ThucThi(truyVan))
            {
                MessageBox.Show("Cập nhật máy bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachMayBay();
            }
            else
            {
                MessageBox.Show("Cập nhật máy bay thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMayBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMayBay.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMayBay.SelectedRows[0];
                txtTenMayBay.Text = selectedRow.Cells["TenMayBay"].Value.ToString();
                txtNamSX.Text = selectedRow.Cells["NamSX"].Value.ToString();
                txtSoGioBay.Text = selectedRow.Cells["SoGioBay"].Value.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
