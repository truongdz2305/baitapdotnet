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
    public partial class QuanLyMayBay : Form
    {
        public QuanLyMayBay()
        {
            InitializeComponent();
        }

        private void btnXemMayBay_Click(object sender, EventArgs e)
        {
            MayBay frmXemMayBay = new MayBay();
            frmXemMayBay.ShowDialog();
        }

        private void btnThemMayBay_Click(object sender, EventArgs e)
        {
            ThemMayBay frmThemMayBay = new ThemMayBay();
            frmThemMayBay.ShowDialog();
        }

        private void btnSuaMayBay_Click(object sender, EventArgs e)
        {
            SuaMayBay frmSuaMayBay = new SuaMayBay();
            frmSuaMayBay.ShowDialog();
        }
    }
}
